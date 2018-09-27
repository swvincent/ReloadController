/////////////////////////////////////////////////////////////////////////////////////////
/// ReloadController
/// http://www.lungStruck.com/projects/reload-controller
/// 
/// This code has been developed for .NET Framework 4.0 with
/// Microsoft Visual Studio 2010.
/// 
/// Originally released on my website 9/3/2015. Added to Git version control 9/27/2018.
/// 
/// Copyright (c) 2015 Scott W. Vincent
/// 
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
/////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dsub;                                 //ComPort class
using ReloadController.Properties;          //for Application settings
using scooter;                              //Utility code
using System.IO.Ports;                      //For serial port settings

namespace ReloadController
{
    public partial class MainForm : Form
    {

        #region Declarations

        private delegate void AccessFormMarshalDelegate(ComPort.ComPortEvent userInterfaceAction, string comPortData);
        private ComPort comPort;
        private DateTime shutdownDateTime;
        private decimal shutdownVoltage;

        #endregion Declarations

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Access Form

        /// <summary>
        /// Perform functions in form from a different thread.  See AccessFormMarshal.
        /// </summary>
        /// <remarks>
        /// Based on methods used by Jan Axelson in Serial Port Complete 2nd edition.  I break it out a little further
        /// as I handle exceptions seperately.
        /// </remarks>
        /// <param name="userInterfaceAction">Enum that indicates which action to perform</param>
        /// <param name="comPortData">Com Port data being returned if applicable</param>
        private void AccessForm(ComPort.ComPortEvent userInterfaceAction, string comPortData)
        {
            switch (userInterfaceAction)
            {
                case ComPort.ComPortEvent.ReturnNewData:
                    //Retrieve new com port data.
                    ProcessReloadData(comPortData);
                    break;
                case ComPort.ComPortEvent.ReportStatus:
                    //Display ComPort status.
                    comPortStatusLabel.Text = comPortData;
                    break;
                case ComPort.ComPortEvent.ReportException:
                    //Exception occured in ComPort.
                    MessageBox.Show(comPortData, "Exception Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case ComPort.ComPortEvent.ReportSerialError:
                    //Serial error occured in ComPort.
                    comPortErrorsTextBox.AppendText(DateTime.Now.ToString() + " - " + comPortData + Environment.NewLine);
                    break;
            }
        }


        /// <summary>
        /// Enables accessing the form from another thread.  The parameters match those of AccessForm.
        /// </summary>
        /// <remarks>
        /// Based on methods used by Jan Axelson in Serial Port Complete 2nd edition, except I use
        /// BeginInvoke rather than Invoke, to avoid the deadlock issue.
        /// </remarks>
        /// <param name="userInterfaceAction">Enum that indicates which action to perform</param>
        /// <param name="comPortData">Com Port data being returned if applicable</param>
        private void AccessFormMarshal(ComPort.ComPortEvent userInterfaceAction, string comPortData)
        {
            AccessFormMarshalDelegate accessFormMarshalDelegate = new AccessFormMarshalDelegate(AccessForm);

            object[] args = { userInterfaceAction, comPortData };

            //Call AccessForm, passing the parameters in args. I use BeginInvoke, after reading several sources indicating
            //it should be used to avoid a deadlock when the port is closed. Initially I saw it in Alex F.'s comments here:
            //http://forums.codeguru.com/showthread.php?516248-RESOLVED-Serial-port-hangs-on-form-close, more explanation here:
            //http://blogs.msdn.com/b/bclteam/archive/2006/10/10/top-5-serialport-tips-_5b00_kim-hamilton_5d00_.aspx. I'm not
            //sure if there are any downsides yet, but it fixed the deadlock for me, and everything still seems to work okay.
            base.BeginInvoke(accessFormMarshalDelegate, args);
        }

        #endregion Access Form

        #region Form Load Unload

        /// <summary>
        /// Runs required actions on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Load(object sender, EventArgs e)
        {
            //Specify routine that executes on events in other modules.  The routine can receive data from other modules.
            //Based on methods used by Jan Axelson in Serial Port Complete 2nd edition.
            ComPort.UserInterfaceData += new ComPort.UserInterfaceDataEventHandler(AccessFormMarshal);

            //Create ComPort.
            comPort = new ComPort();
            RefreshPortSettings();

            if (Settings.Default.ConnectOnStartup)
                OpenPort();

            ToggleFormMode();

            comPortErrorsTextBox.AppendText("Application loaded at @ " + DateTime.Now.ToString() + Environment.NewLine);
        }


        /// <summary>
        /// Close port before form closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //I originally added this to see if it would fix the deadlock when port is closed;
            //it didn't. Probably still not a bad idea to have it, so I left it in.
            ComPort.UserInterfaceData -= AccessFormMarshal;

            ClosePort();
        }

        #endregion Form Load Unload

        #region Private Methods

        /// <summary>
        /// Toggle form between editing/not editing to determine which controls are enabled/disabled.
        /// </summary>
        /// <param name="editing"></param>
        private void ToggleFormMode()
        {
            bool portIsOpen = comPort.IsOpen;

            WinFormHelper.ToggleMenuStripItems(mainMenuStrip, portIsOpen);

            //Enable setpoint controls only if connected
            foreach (Control c in setpointGroupBox.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Enabled = portIsOpen;
                }
            }

            startStopButton.Enabled = portIsOpen;
        }

        /// <summary>
        /// Open connection to Re:load Pro and start monitoring.
        /// </summary>
        private void OpenPort()
        {
            comPort.OpenPort();

            if (comPort.IsOpen)
            {
                //Request fw version, get current setpoint, and start receiving current/voltage readings
                //Re:load Pro seems to need a pause in between commands, 20ms seems to do it.
                comPort.WriteToComPort("version\n");
                System.Threading.Thread.Sleep(20);
                comPort.WriteToComPort("set\n");
                System.Threading.Thread.Sleep(20);
                //1 second monitor frequency. Set too low it may not give enough time to respond to
                //data, and too high will affect timed shutdown process.
                comPort.WriteToComPort("monitor 1000\n");
            }
        }


        /// <summary>
        /// Instruct Re:load Pro to stop monitoring and close port.
        /// </summary>
        private void ClosePort()
        {
            if (comPort.IsOpen)
            {
                comPort.WriteToComPort("monitor 0\n");
                comPort.ClosePort();
                SetpointTextBox.Text = "?";
                CurrentTextBox.Text = "?";
                VoltageTextBox.Text = "?";
                PowerTextBox.Text = "?";
                ResistanceTextBox.Text = "?";
            }
        }


        /// <summary>
        /// Reset Re:load Pro after overtemp/undervolt situation.
        /// </summary>
        private void ResetReload()
        {
            comPort.WriteToComPort("reset\n");
            System.Threading.Thread.Sleep(20);
            comPort.WriteToComPort("set\n");
        }


        #endregion Private Methods

        #region Public Methods

        /// <summary>
        /// Refresh port settings from application settings.
        /// </summary>
        public void RefreshPortSettings()
        {
            if (!(comPort == null))
            {
                comPort.ChangeSettings(Settings.Default.ComPort, 115200, Parity.None, 8, StopBits.One, Handshake.None, "\r\n");
                portStatusLabel.Text = comPort.PortName;
            }
        }

        #endregion Public Methods

        #region Menu Code

        /// <summary>
        /// Exit application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Open Port.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPort();
            ToggleFormMode();
        }


        /// <summary>
        /// Close Port and stop shutdown procedure if one is running.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startStopButton.Text == "&Stop")
            {
                startStopButton_Click(startStopButton, null);
            }
            ClosePort();
            ToggleFormMode();
        }


        /// <summary>
        /// Show settings form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm f = new SettingsForm(this);
            f.Show();
        }


        /// <summary>
        /// Show about form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm a = new AboutForm();
            a.ShowDialog();
        }

        #endregion Menu Code

        #region Increment Setpoint

        /// <summary>
        /// Increment setpoint by specified amount (can be negative amounts too)
        /// </summary>
        /// <param name="amount">amount to change setpoint by</param>
        private void IncrementSetpoint(int amountChange)
        {
            int newSetpoint = int.Parse(SetpointTextBox.Text) + amountChange;
            comPort.WriteToComPort("set " + newSetpoint.ToString() + "\n");
        }


        private void IncrOneButton_Click(object sender, EventArgs e)
        {
            IncrementSetpoint(1);
        }


        private void DecrOneButton_Click(object sender, EventArgs e)
        {
            IncrementSetpoint(-1);
        }


        private void IncrFiveButton_Click(object sender, EventArgs e)
        {
            IncrementSetpoint(5);
        }


        private void DecrFiveButton_Click(object sender, EventArgs e)
        {
            IncrementSetpoint(-5);
        }


        private void IncrTenButton_Click(object sender, EventArgs e)
        {
            IncrementSetpoint(10);
        }


        private void DecrTenButton_Click(object sender, EventArgs e)
        {
            IncrementSetpoint(-10);
        }


        private void IncrHundredButton_Click(object sender, EventArgs e)
        {
            IncrementSetpoint(100);
        }


        private void DecrHundredButton_Click(object sender, EventArgs e)
        {
            IncrementSetpoint(-100);
        }


        /// <summary>
        /// Allow user to enter a setpoint directly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpecifySetpointButton_Click(object sender, EventArgs e)
        {
            int newSetpoint;
            //Why yes I am using the VB InputBox
            string input = Microsoft.VisualBasic.Interaction.InputBox("New setpoint (ma):", "Specify Setpoint", "", -1, -1);
            if (int.TryParse(input, out newSetpoint))
                comPort.WriteToComPort("set " + newSetpoint + "\n");
            else
                MessageBox.Show("Setpoint must be a numeric value - no change was made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Increment Setpoint

        #region ProcessReloadData

        /// <summary>
        /// Process data from Re:load Pro and take appropriate action.
        /// </summary>
        /// <param name="comPortData">Data received from Re:load Pro</param>
        private void ProcessReloadData(string comPortData)
        {
            try
            {
                //Split data on spaces, easier to work with
                string[] splitComPortData = comPortData.Split(' ');

                switch (splitComPortData[0])
                {
                    case "read":
                        //Display readings and calc'd power
                        decimal i = int.Parse(splitComPortData[1]) / 1000M;
                        decimal v = decimal.Parse(splitComPortData[2]) / 1000M;
                        decimal p = i * v;
                        decimal r = i > 0 ? v / i : 0;

                        CurrentTextBox.Text = splitComPortData[1];
                        VoltageTextBox.Text = v.ToString("#0.00");
                        PowerTextBox.Text = p.ToString("#0.00");
                        ResistanceTextBox.Text = r.ToString("#0.00");

                        ProcessShutdownEvent(v);
                        break;
                    case "set":
                        //Setpoint updated
                        SetpointTextBox.Text = splitComPortData[1];
                        break;
                    case "version":
                        fwVersionStatusLabel.Text = "FW v" + splitComPortData[1];
                        break;
                    case "err":
                        //Error reported by Re:load Pro
                        comPortErrorsTextBox.AppendText("Error reported @" + DateTime.Now.ToString() + ": " + comPortData.Substring(4) + Environment.NewLine);
                        break;
                    case "overtemp":
                        //Re:load Pro's FET exceeded safe operating temperature, must reset
                        comPortErrorsTextBox.AppendText("Overtemp @ " + DateTime.Now.ToString() + "!" + Environment.NewLine);
                        MessageBox.Show("FET temperature exceeded safe limits! Unit must be reset to continue.", "Overtemp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetReload();
                        break;
                    case "undervolt":
                        //Re:load Pro's has detected undervoltage condition.
                        comPortErrorsTextBox.AppendText("Undervolt condition @ " + DateTime.Now.ToString() + "!" + Environment.NewLine);
                        MessageBox.Show("Unit has detected an undervoltage condition and must be reset to continue.", "Undervolt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetReload();
                        break;
                    default:
                        //Some other message was received from Re:load Pro, display it.
                        comPortErrorsTextBox.AppendText("Message @ " + DateTime.Now.ToString() + ": " + comPortData + Environment.NewLine);
                        break;
                }
            }
            catch (FormatException)
            {
                //Most likely occurs when corrupt data in buffer causes a Parse to fail. I've seen it happen after unit reset from overtemp/undervolt.
                //Haven't been able to test it real thoroughly since I don't want to keep abusing my Re:load Pro to trigger it.
                comPortErrorsTextBox.AppendText("Corrupt data in buffer @ " + DateTime.Now.ToString() + ", contents: \"" + comPortData + "\"" + Environment.NewLine);
            }
            catch (Exception caught)
            {
                //Some other exception occured.
                MessageBox.Show("Exception occured while processing data from the serial buffer. Contents of the buffer: \"" + comPortData + "\"." +
                    Environment.NewLine + Environment.NewLine + "Exception message: " + caught.Message, "Exception occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion ProcessReloadData

        #region Shutdown Procedure code

        /// <summary>
        /// Start/stop shutdown procedure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (startStopButton.Text == "&Start")
            {
                if (timerRadioButton.Checked)
                {
                    TimeSpan shutdownTimeSpan;
                    if (TimeSpan.TryParseExact(shutdownTimeTextBox.Text, @"m\:ss", System.Globalization.CultureInfo.InvariantCulture, out shutdownTimeSpan))
                    {
                        shutdownDateTime = DateTime.Now.Add(shutdownTimeSpan);
                        startStopButton.Text = "&Stop";
                        comPortErrorsTextBox.AppendText("Timed shutdown started @ " + DateTime.Now.ToString() + "; ends @ " + shutdownDateTime.ToString() + Environment.NewLine);
                    }
                    else
                        MessageBox.Show("The specified shutdown time is invalid.", "Invalid voltage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (voltageRadioButton.Checked)
                {
                    if (decimal.TryParse(shutdownVoltageTextBox.Text, out shutdownVoltage))
                    {
                        if (shutdownVoltage >= 0 && shutdownVoltage <= 60)
                        {
                            startStopButton.Text = "&Stop";
                            comPortErrorsTextBox.AppendText("Voltage shutdown started @ " + DateTime.Now.ToString() + "; ends when v <="
                                + shutdownVoltage.ToString() + Environment.NewLine);
                        }
                        else
                            MessageBox.Show("Shutdown voltage must be between 0 and 60.", "Invalid voltage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Shutdown voltage must be numeric.", "Invalid voltage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                startStopButton.Text = "&Start";
                if (sender == startStopButton)
                    comPortErrorsTextBox.AppendText("Shutdown cancelled by user @ " + DateTime.Now.ToString() + Environment.NewLine);
            }

            ToggleShutdownControls();
        }

        
        private void timerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToggleShutdownControls();
        }

        
        private void voltageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToggleShutdownControls();
        }


        /// <summary>
        /// Enable/disable controls based on shutdown settings.
        /// </summary>
        private void ToggleShutdownControls()
        {
            timerRadioButton.Enabled = startStopButton.Text == "&Start";
            voltageRadioButton.Enabled = startStopButton.Text == "&Start";
            shutdownTimeTextBox.Enabled = timerRadioButton.Checked && startStopButton.Text == "&Start";
            shutdownVoltageTextBox.Enabled = voltageRadioButton.Checked && startStopButton.Text == "&Start";
        }


        /// <summary>
        /// Check if shutdown should occur.
        /// </summary>
        /// <param name="voltage">measured voltage</param>
        private void ProcessShutdownEvent(decimal voltage)
        {
            if (startStopButton.Text == "&Stop")
            {
                if (timerRadioButton.Checked)
                {
                    //if (DateTime.Compare(DateTime.Now, shutdownDateTime) > 0)
                    if (DateTime.Now >= shutdownDateTime)
                    {
                        //Shutdown time arrived
                        comPort.WriteToComPort("set 0\n");
                        comPortErrorsTextBox.AppendText("Timed Shutdown complete @ " + DateTime.Now.ToString() + Environment.NewLine);
                        startStopButton_Click(null, null);
                    }
                }
                else if (voltageRadioButton.Checked)
                {
                    if (voltage <= shutdownVoltage)
                    {
                        //Shutdown voltage achieved
                        comPort.WriteToComPort("set 0\n");
                        comPortErrorsTextBox.AppendText("Shutdown @ " + DateTime.Now.ToString() + ": " + "Voltage was " + voltage.ToString() + Environment.NewLine);
                        startStopButton_Click(null, null);
                    }
                }
            }
        }

        #endregion Shutdown Procedure code

    }
}