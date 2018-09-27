using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dsub;                                 //Serial port communications
using ReloadController.Properties;          //For application settings
using scooter;                              //Utility code

namespace ReloadController
{
    public partial class SettingsForm : Form
    {

        #region Private declarations

        private MainForm mainForm;

        #endregion Private declarations

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Constructor which accepts mainForm reference
        /// </summary>
        /// <param name="mainForm"></param>
        public SettingsForm(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;
        }

        #endregion Constructors

        #region Event Handlers

        /// <summary>
        /// Load datasources and saved options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsForm_Load(object sender, EventArgs e)
        {
            //Set combobox data sources
            comPortComboBox.DataSource = ComPort.RetrieveComPortList();

            //Retrieve saved options
            comPortComboBox.SelectedItem = Settings.Default.ComPort;
            connectOnStartupCheckBox.Checked = Settings.Default.ConnectOnStartup;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateFormData())
            {
                Settings.Default.ComPort = comPortComboBox.SelectedItem.ToString();
                Settings.Default.ConnectOnStartup = connectOnStartupCheckBox.Checked;
                Settings.Default.Save();

                //Refresh port settings for comPort on main form.
                if (!(mainForm == null))
                    mainForm.RefreshPortSettings();

                this.Close();
            }
        }

        #endregion Event Handlers

        #region Private Methods

        /// <summary>
        /// Validate settings are correct
        /// </summary>
        /// <returns></returns>
        private bool ValidateFormData()
        {
            bool validation = true;

            if (!Validata.ValueSelected(comPortComboBox, settingsErrorProvider, "COM Port"))
                validation = false;

            return validation;
        }

        #endregion Private Methods

    }
}
