namespace ReloadController
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VoltageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.measGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResistanceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.portStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.comPortStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fwVersionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortErrorsTextBox = new System.Windows.Forms.TextBox();
            this.SetpointTextBox = new System.Windows.Forms.TextBox();
            this.IncrOneButton = new System.Windows.Forms.Button();
            this.IncrFiveButton = new System.Windows.Forms.Button();
            this.IncrTenButton = new System.Windows.Forms.Button();
            this.DecrTenButton = new System.Windows.Forms.Button();
            this.DecrFiveButton = new System.Windows.Forms.Button();
            this.DecrOneButton = new System.Windows.Forms.Button();
            this.SpecifySetpointButton = new System.Windows.Forms.Button();
            this.setpointGroupBox = new System.Windows.Forms.GroupBox();
            this.DecrHundredButton = new System.Windows.Forms.Button();
            this.IncrHundredButton = new System.Windows.Forms.Button();
            this.shutdownGroupBox = new System.Windows.Forms.GroupBox();
            this.shutdownTimeTextBox = new System.Windows.Forms.TextBox();
            this.startStopButton = new System.Windows.Forms.Button();
            this.shutdownVoltageTextBox = new System.Windows.Forms.TextBox();
            this.voltageRadioButton = new System.Windows.Forms.RadioButton();
            this.timerRadioButton = new System.Windows.Forms.RadioButton();
            this.measGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.setpointGroupBox.SuspendLayout();
            this.shutdownGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current";
            // 
            // CurrentTextBox
            // 
            this.CurrentTextBox.Location = new System.Drawing.Point(69, 29);
            this.CurrentTextBox.Name = "CurrentTextBox";
            this.CurrentTextBox.ReadOnly = true;
            this.CurrentTextBox.Size = new System.Drawing.Size(59, 20);
            this.CurrentTextBox.TabIndex = 2;
            this.CurrentTextBox.Text = "?";
            this.CurrentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "v";
            // 
            // VoltageTextBox
            // 
            this.VoltageTextBox.Location = new System.Drawing.Point(69, 55);
            this.VoltageTextBox.Name = "VoltageTextBox";
            this.VoltageTextBox.ReadOnly = true;
            this.VoltageTextBox.Size = new System.Drawing.Size(59, 20);
            this.VoltageTextBox.TabIndex = 3;
            this.VoltageTextBox.Text = "?";
            this.VoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Voltage";
            // 
            // measGroupBox
            // 
            this.measGroupBox.Controls.Add(this.label1);
            this.measGroupBox.Controls.Add(this.ResistanceTextBox);
            this.measGroupBox.Controls.Add(this.label9);
            this.measGroupBox.Controls.Add(this.label7);
            this.measGroupBox.Controls.Add(this.PowerTextBox);
            this.measGroupBox.Controls.Add(this.label8);
            this.measGroupBox.Controls.Add(this.CurrentTextBox);
            this.measGroupBox.Controls.Add(this.label5);
            this.measGroupBox.Controls.Add(this.label3);
            this.measGroupBox.Controls.Add(this.VoltageTextBox);
            this.measGroupBox.Controls.Add(this.label4);
            this.measGroupBox.Controls.Add(this.label6);
            this.measGroupBox.Location = new System.Drawing.Point(11, 141);
            this.measGroupBox.Name = "measGroupBox";
            this.measGroupBox.Size = new System.Drawing.Size(352, 93);
            this.measGroupBox.TabIndex = 1;
            this.measGroupBox.TabStop = false;
            this.measGroupBox.Text = "Measurements";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ω";
            // 
            // ResistanceTextBox
            // 
            this.ResistanceTextBox.Location = new System.Drawing.Point(245, 55);
            this.ResistanceTextBox.Name = "ResistanceTextBox";
            this.ResistanceTextBox.ReadOnly = true;
            this.ResistanceTextBox.Size = new System.Drawing.Size(59, 20);
            this.ResistanceTextBox.TabIndex = 9;
            this.ResistanceTextBox.Text = "?";
            this.ResistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Resistance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "w";
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.Location = new System.Drawing.Point(245, 29);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.ReadOnly = true;
            this.PowerTextBox.Size = new System.Drawing.Size(59, 20);
            this.PowerTextBox.TabIndex = 8;
            this.PowerTextBox.Text = "?";
            this.PowerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Power";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portStatusLabel,
            this.comPortStatusLabel,
            this.toolStripStatusLabel1,
            this.fwVersionStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // portStatusLabel
            // 
            this.portStatusLabel.AutoSize = false;
            this.portStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.portStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.portStatusLabel.Name = "portStatusLabel";
            this.portStatusLabel.Size = new System.Drawing.Size(60, 17);
            this.portStatusLabel.Text = "COM00";
            // 
            // comPortStatusLabel
            // 
            this.comPortStatusLabel.AutoSize = false;
            this.comPortStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.comPortStatusLabel.Name = "comPortStatusLabel";
            this.comPortStatusLabel.Size = new System.Drawing.Size(90, 17);
            this.comPortStatusLabel.Text = "Port Closed";
            this.comPortStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(321, 17);
            // 
            // fwVersionStatusLabel
            // 
            this.fwVersionStatusLabel.AutoSize = false;
            this.fwVersionStatusLabel.Name = "fwVersionStatusLabel";
            this.fwVersionStatusLabel.Size = new System.Drawing.Size(80, 17);
            this.fwVersionStatusLabel.Text = "FW v?";
            this.fwVersionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.comPortToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(551, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comPortToolStripMenuItem
            // 
            this.comPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.comPortToolStripMenuItem.Name = "comPortToolStripMenuItem";
            this.comPortToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.comPortToolStripMenuItem.Text = "&Device";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openToolStripMenuItem.Tag = "enableNotEditing";
            this.openToolStripMenuItem.Text = "&Open Connection";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.closeToolStripMenuItem.Tag = "enableEditing";
            this.closeToolStripMenuItem.Text = "&Close Connection";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.settingsToolStripMenuItem.Tag = "enableNotEditing";
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // comPortErrorsTextBox
            // 
            this.comPortErrorsTextBox.Location = new System.Drawing.Point(12, 247);
            this.comPortErrorsTextBox.Multiline = true;
            this.comPortErrorsTextBox.Name = "comPortErrorsTextBox";
            this.comPortErrorsTextBox.ReadOnly = true;
            this.comPortErrorsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.comPortErrorsTextBox.Size = new System.Drawing.Size(528, 74);
            this.comPortErrorsTextBox.TabIndex = 3;
            this.comPortErrorsTextBox.TabStop = false;
            // 
            // SetpointTextBox
            // 
            this.SetpointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetpointTextBox.Location = new System.Drawing.Point(15, 31);
            this.SetpointTextBox.Name = "SetpointTextBox";
            this.SetpointTextBox.ReadOnly = true;
            this.SetpointTextBox.Size = new System.Drawing.Size(77, 40);
            this.SetpointTextBox.TabIndex = 0;
            this.SetpointTextBox.Text = "?";
            this.SetpointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IncrOneButton
            // 
            this.IncrOneButton.Location = new System.Drawing.Point(126, 26);
            this.IncrOneButton.Name = "IncrOneButton";
            this.IncrOneButton.Size = new System.Drawing.Size(28, 23);
            this.IncrOneButton.TabIndex = 2;
            this.IncrOneButton.Text = "+1";
            this.IncrOneButton.UseVisualStyleBackColor = true;
            this.IncrOneButton.Click += new System.EventHandler(this.IncrOneButton_Click);
            // 
            // IncrFiveButton
            // 
            this.IncrFiveButton.Location = new System.Drawing.Point(155, 26);
            this.IncrFiveButton.Name = "IncrFiveButton";
            this.IncrFiveButton.Size = new System.Drawing.Size(28, 23);
            this.IncrFiveButton.TabIndex = 4;
            this.IncrFiveButton.Text = "+5";
            this.IncrFiveButton.UseVisualStyleBackColor = true;
            this.IncrFiveButton.Click += new System.EventHandler(this.IncrFiveButton_Click);
            // 
            // IncrTenButton
            // 
            this.IncrTenButton.Location = new System.Drawing.Point(183, 26);
            this.IncrTenButton.Name = "IncrTenButton";
            this.IncrTenButton.Size = new System.Drawing.Size(40, 23);
            this.IncrTenButton.TabIndex = 6;
            this.IncrTenButton.Text = "+10";
            this.IncrTenButton.UseVisualStyleBackColor = true;
            this.IncrTenButton.Click += new System.EventHandler(this.IncrTenButton_Click);
            // 
            // DecrTenButton
            // 
            this.DecrTenButton.Location = new System.Drawing.Point(183, 50);
            this.DecrTenButton.Name = "DecrTenButton";
            this.DecrTenButton.Size = new System.Drawing.Size(40, 23);
            this.DecrTenButton.TabIndex = 7;
            this.DecrTenButton.Text = "-10";
            this.DecrTenButton.UseVisualStyleBackColor = true;
            this.DecrTenButton.Click += new System.EventHandler(this.DecrTenButton_Click);
            // 
            // DecrFiveButton
            // 
            this.DecrFiveButton.Location = new System.Drawing.Point(155, 50);
            this.DecrFiveButton.Name = "DecrFiveButton";
            this.DecrFiveButton.Size = new System.Drawing.Size(28, 23);
            this.DecrFiveButton.TabIndex = 5;
            this.DecrFiveButton.Text = "-5";
            this.DecrFiveButton.UseVisualStyleBackColor = true;
            this.DecrFiveButton.Click += new System.EventHandler(this.DecrFiveButton_Click);
            // 
            // DecrOneButton
            // 
            this.DecrOneButton.Location = new System.Drawing.Point(126, 50);
            this.DecrOneButton.Name = "DecrOneButton";
            this.DecrOneButton.Size = new System.Drawing.Size(28, 23);
            this.DecrOneButton.TabIndex = 3;
            this.DecrOneButton.Text = "-1";
            this.DecrOneButton.UseVisualStyleBackColor = true;
            this.DecrOneButton.Click += new System.EventHandler(this.DecrOneButton_Click);
            // 
            // SpecifySetpointButton
            // 
            this.SpecifySetpointButton.Location = new System.Drawing.Point(271, 39);
            this.SpecifySetpointButton.Name = "SpecifySetpointButton";
            this.SpecifySetpointButton.Size = new System.Drawing.Size(70, 23);
            this.SpecifySetpointButton.TabIndex = 10;
            this.SpecifySetpointButton.Text = "Specify...";
            this.SpecifySetpointButton.UseVisualStyleBackColor = true;
            this.SpecifySetpointButton.Click += new System.EventHandler(this.SpecifySetpointButton_Click);
            // 
            // setpointGroupBox
            // 
            this.setpointGroupBox.Controls.Add(this.DecrHundredButton);
            this.setpointGroupBox.Controls.Add(this.IncrHundredButton);
            this.setpointGroupBox.Controls.Add(this.SetpointTextBox);
            this.setpointGroupBox.Controls.Add(this.SpecifySetpointButton);
            this.setpointGroupBox.Controls.Add(this.label2);
            this.setpointGroupBox.Controls.Add(this.DecrTenButton);
            this.setpointGroupBox.Controls.Add(this.IncrOneButton);
            this.setpointGroupBox.Controls.Add(this.DecrFiveButton);
            this.setpointGroupBox.Controls.Add(this.IncrFiveButton);
            this.setpointGroupBox.Controls.Add(this.DecrOneButton);
            this.setpointGroupBox.Controls.Add(this.IncrTenButton);
            this.setpointGroupBox.Location = new System.Drawing.Point(11, 33);
            this.setpointGroupBox.Name = "setpointGroupBox";
            this.setpointGroupBox.Size = new System.Drawing.Size(352, 93);
            this.setpointGroupBox.TabIndex = 0;
            this.setpointGroupBox.TabStop = false;
            this.setpointGroupBox.Text = "Setpoint";
            // 
            // DecrHundredButton
            // 
            this.DecrHundredButton.Location = new System.Drawing.Point(223, 50);
            this.DecrHundredButton.Name = "DecrHundredButton";
            this.DecrHundredButton.Size = new System.Drawing.Size(40, 23);
            this.DecrHundredButton.TabIndex = 9;
            this.DecrHundredButton.Text = "-100";
            this.DecrHundredButton.UseVisualStyleBackColor = true;
            this.DecrHundredButton.Click += new System.EventHandler(this.DecrHundredButton_Click);
            // 
            // IncrHundredButton
            // 
            this.IncrHundredButton.Location = new System.Drawing.Point(223, 26);
            this.IncrHundredButton.Name = "IncrHundredButton";
            this.IncrHundredButton.Size = new System.Drawing.Size(40, 23);
            this.IncrHundredButton.TabIndex = 8;
            this.IncrHundredButton.Text = "+100";
            this.IncrHundredButton.UseVisualStyleBackColor = true;
            this.IncrHundredButton.Click += new System.EventHandler(this.IncrHundredButton_Click);
            // 
            // shutdownGroupBox
            // 
            this.shutdownGroupBox.Controls.Add(this.shutdownTimeTextBox);
            this.shutdownGroupBox.Controls.Add(this.startStopButton);
            this.shutdownGroupBox.Controls.Add(this.shutdownVoltageTextBox);
            this.shutdownGroupBox.Controls.Add(this.voltageRadioButton);
            this.shutdownGroupBox.Controls.Add(this.timerRadioButton);
            this.shutdownGroupBox.Location = new System.Drawing.Point(379, 33);
            this.shutdownGroupBox.Name = "shutdownGroupBox";
            this.shutdownGroupBox.Size = new System.Drawing.Size(160, 201);
            this.shutdownGroupBox.TabIndex = 2;
            this.shutdownGroupBox.TabStop = false;
            this.shutdownGroupBox.Text = "Shutdown";
            // 
            // shutdownTimeTextBox
            // 
            this.shutdownTimeTextBox.Location = new System.Drawing.Point(93, 58);
            this.shutdownTimeTextBox.Name = "shutdownTimeTextBox";
            this.shutdownTimeTextBox.Size = new System.Drawing.Size(42, 20);
            this.shutdownTimeTextBox.TabIndex = 1;
            this.shutdownTimeTextBox.Text = "0:30";
            this.shutdownTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(40, 133);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 4;
            this.startStopButton.Text = "&Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // shutdownVoltageTextBox
            // 
            this.shutdownVoltageTextBox.Enabled = false;
            this.shutdownVoltageTextBox.Location = new System.Drawing.Point(93, 90);
            this.shutdownVoltageTextBox.Name = "shutdownVoltageTextBox";
            this.shutdownVoltageTextBox.Size = new System.Drawing.Size(42, 20);
            this.shutdownVoltageTextBox.TabIndex = 3;
            this.shutdownVoltageTextBox.Text = "0.00";
            this.shutdownVoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // voltageRadioButton
            // 
            this.voltageRadioButton.AutoSize = true;
            this.voltageRadioButton.Location = new System.Drawing.Point(25, 92);
            this.voltageRadioButton.Name = "voltageRadioButton";
            this.voltageRadioButton.Size = new System.Drawing.Size(61, 17);
            this.voltageRadioButton.TabIndex = 2;
            this.voltageRadioButton.Text = "Voltage";
            this.voltageRadioButton.UseVisualStyleBackColor = true;
            this.voltageRadioButton.CheckedChanged += new System.EventHandler(this.voltageRadioButton_CheckedChanged);
            // 
            // timerRadioButton
            // 
            this.timerRadioButton.AutoSize = true;
            this.timerRadioButton.Checked = true;
            this.timerRadioButton.Location = new System.Drawing.Point(25, 59);
            this.timerRadioButton.Name = "timerRadioButton";
            this.timerRadioButton.Size = new System.Drawing.Size(51, 17);
            this.timerRadioButton.TabIndex = 0;
            this.timerRadioButton.TabStop = true;
            this.timerRadioButton.Text = "Timer";
            this.timerRadioButton.UseVisualStyleBackColor = true;
            this.timerRadioButton.CheckedChanged += new System.EventHandler(this.timerRadioButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 355);
            this.Controls.Add(this.shutdownGroupBox);
            this.Controls.Add(this.setpointGroupBox);
            this.Controls.Add(this.comPortErrorsTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.measGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reload Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.measGroupBox.ResumeLayout(false);
            this.measGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.setpointGroupBox.ResumeLayout(false);
            this.setpointGroupBox.PerformLayout();
            this.shutdownGroupBox.ResumeLayout(false);
            this.shutdownGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CurrentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VoltageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox measGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PowerTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel comPortStatusLabel;
        private System.Windows.Forms.TextBox comPortErrorsTextBox;
        private System.Windows.Forms.ToolStripMenuItem comPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TextBox SetpointTextBox;
        private System.Windows.Forms.Button IncrOneButton;
        private System.Windows.Forms.Button IncrFiveButton;
        private System.Windows.Forms.Button IncrTenButton;
        private System.Windows.Forms.Button DecrTenButton;
        private System.Windows.Forms.Button DecrFiveButton;
        private System.Windows.Forms.Button DecrOneButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel fwVersionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel portStatusLabel;
        private System.Windows.Forms.Button SpecifySetpointButton;
        private System.Windows.Forms.GroupBox setpointGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResistanceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox shutdownGroupBox;
        private System.Windows.Forms.RadioButton voltageRadioButton;
        private System.Windows.Forms.RadioButton timerRadioButton;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.TextBox shutdownVoltageTextBox;
        private System.Windows.Forms.TextBox shutdownTimeTextBox;
        private System.Windows.Forms.Button DecrHundredButton;
        private System.Windows.Forms.Button IncrHundredButton;
    }
}

