namespace VisualWget
{
    partial class JobDialog
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.argumentLabel = new System.Windows.Forms.Label();
            this.urlsTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.argumentTextBox = new System.Windows.Forms.TextBox();
            this.argumentButton = new System.Windows.Forms.Button();
            this.startOnOkCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsListView = new System.Windows.Forms.ListView();
            this.urlsLabel = new System.Windows.Forms.Label();
            this.directoryPrefixLabel = new System.Windows.Forms.Label();
            this.directoryPrefixComboBox = new System.Windows.Forms.ComboBox();
            this.directoryPrefixButton = new System.Windows.Forms.Button();
            this.continueCheckBox = new System.Windows.Forms.CheckBox();
            this.timestampingCheckBox = new System.Windows.Forms.CheckBox();
            this.schedulerGroupBox = new System.Windows.Forms.GroupBox();
            this.autoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.autoStartNumDaysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.autoStartDaysLabel = new System.Windows.Forms.Label();
            this.autoStartNumHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.autoStartHoursLabel = new System.Windows.Forms.Label();
            this.outputDocumentLabel = new System.Windows.Forms.Label();
            this.outputDocumentTextBox = new System.Windows.Forms.TextBox();
            this.outputDocumentButton = new System.Windows.Forms.Button();
            this.presetsGroupBox = new System.Windows.Forms.GroupBox();
            this.optionsPresetComboBox = new System.Windows.Forms.ComboBox();
            this.loadEmptyButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optionsCategoryListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.generalPanel = new System.Windows.Forms.Panel();
            this.resumingGroupBox = new System.Windows.Forms.GroupBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.advancedPanel = new System.Windows.Forms.Panel();
            this.jobCatListBox = new System.Windows.Forms.ListBox();
            this.httpPanel = new System.Windows.Forms.Panel();
            this.refererTextBox = new System.Windows.Forms.TextBox();
            this.refererLabel = new System.Windows.Forms.Label();
            this.userAgentLabel = new System.Windows.Forms.Label();
            this.userAgentComboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.schedulerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoStartNumDaysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoStartNumHoursNumericUpDown)).BeginInit();
            this.presetsGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.generalPanel.SuspendLayout();
            this.resumingGroupBox.SuspendLayout();
            this.advancedPanel.SuspendLayout();
            this.httpPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // argumentLabel
            // 
            this.argumentLabel.AutoSize = true;
            this.argumentLabel.Location = new System.Drawing.Point(4, 9);
            this.argumentLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.argumentLabel.Name = "argumentLabel";
            this.argumentLabel.Size = new System.Drawing.Size(69, 17);
            this.argumentLabel.TabIndex = 0;
            this.argumentLabel.Text = "Argument";
            // 
            // urlsTextBox
            // 
            this.urlsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlsTextBox.Location = new System.Drawing.Point(4, 80);
            this.urlsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urlsTextBox.Name = "urlsTextBox";
            this.urlsTextBox.Size = new System.Drawing.Size(412, 24);
            this.urlsTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(412, 36);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(390, 426);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(491, 426);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // argumentTextBox
            // 
            this.argumentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.argumentTextBox.Location = new System.Drawing.Point(90, 5);
            this.argumentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.argumentTextBox.Name = "argumentTextBox";
            this.argumentTextBox.Size = new System.Drawing.Size(282, 24);
            this.argumentTextBox.TabIndex = 1;
            this.argumentTextBox.TextChanged += new System.EventHandler(this.argumentTextBox_TextChanged);
            // 
            // argumentButton
            // 
            this.argumentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.argumentButton.Location = new System.Drawing.Point(380, 4);
            this.argumentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.argumentButton.Name = "argumentButton";
            this.argumentButton.Size = new System.Drawing.Size(36, 29);
            this.argumentButton.TabIndex = 2;
            this.argumentButton.Text = "...";
            this.argumentButton.UseVisualStyleBackColor = true;
            this.argumentButton.Click += new System.EventHandler(this.argumentButton_Click);
            // 
            // startOnOkCheckBox
            // 
            this.startOnOkCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startOnOkCheckBox.AutoSize = true;
            this.startOnOkCheckBox.Location = new System.Drawing.Point(8, 431);
            this.startOnOkCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startOnOkCheckBox.Name = "startOnOkCheckBox";
            this.startOnOkCheckBox.Size = new System.Drawing.Size(205, 21);
            this.startOnOkCheckBox.TabIndex = 4;
            this.startOnOkCheckBox.Text = "Start this job when I click OK";
            this.startOnOkCheckBox.UseVisualStyleBackColor = true;
            this.startOnOkCheckBox.CheckedChanged += new System.EventHandler(this.startOnOkCheckBox_CheckedChanged);
            // 
            // optionsListView
            // 
            this.optionsListView.CheckBoxes = true;
            this.optionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsListView.HideSelection = false;
            this.optionsListView.Location = new System.Drawing.Point(0, 0);
            this.optionsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsListView.MultiSelect = false;
            this.optionsListView.Name = "optionsListView";
            this.optionsListView.Size = new System.Drawing.Size(244, 221);
            this.optionsListView.TabIndex = 0;
            this.optionsListView.UseCompatibleStateImageBehavior = false;
            this.optionsListView.View = System.Windows.Forms.View.List;
            this.optionsListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.optionsListView_ItemCheck);
            this.optionsListView.SelectedIndexChanged += new System.EventHandler(this.optionsListView_SelectedIndexChanged);
            // 
            // urlsLabel
            // 
            this.urlsLabel.AutoSize = true;
            this.urlsLabel.Location = new System.Drawing.Point(4, 60);
            this.urlsLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.urlsLabel.Name = "urlsLabel";
            this.urlsLabel.Size = new System.Drawing.Size(54, 17);
            this.urlsLabel.TabIndex = 0;
            this.urlsLabel.Text = "URL(s):";
            // 
            // directoryPrefixLabel
            // 
            this.directoryPrefixLabel.AutoSize = true;
            this.directoryPrefixLabel.Location = new System.Drawing.Point(4, 8);
            this.directoryPrefixLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.directoryPrefixLabel.Name = "directoryPrefixLabel";
            this.directoryPrefixLabel.Size = new System.Drawing.Size(95, 17);
            this.directoryPrefixLabel.TabIndex = 2;
            this.directoryPrefixLabel.Text = "Drawing path:";
            // 
            // directoryPrefixComboBox
            // 
            this.directoryPrefixComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryPrefixComboBox.FormattingEnabled = true;
            this.directoryPrefixComboBox.Location = new System.Drawing.Point(4, 28);
            this.directoryPrefixComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directoryPrefixComboBox.Name = "directoryPrefixComboBox";
            this.directoryPrefixComboBox.Size = new System.Drawing.Size(368, 25);
            this.directoryPrefixComboBox.TabIndex = 3;
            this.directoryPrefixComboBox.TextChanged += new System.EventHandler(this.directoryPrefixComboBox_TextChanged);
            // 
            // directoryPrefixButton
            // 
            this.directoryPrefixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryPrefixButton.Location = new System.Drawing.Point(380, 26);
            this.directoryPrefixButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directoryPrefixButton.Name = "directoryPrefixButton";
            this.directoryPrefixButton.Size = new System.Drawing.Size(36, 29);
            this.directoryPrefixButton.TabIndex = 4;
            this.directoryPrefixButton.Text = "...";
            this.directoryPrefixButton.UseVisualStyleBackColor = true;
            this.directoryPrefixButton.Click += new System.EventHandler(this.directoryPrefixButton_Click);
            // 
            // continueCheckBox
            // 
            this.continueCheckBox.AutoSize = true;
            this.continueCheckBox.Location = new System.Drawing.Point(8, 25);
            this.continueCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.continueCheckBox.Name = "continueCheckBox";
            this.continueCheckBox.Size = new System.Drawing.Size(285, 21);
            this.continueCheckBox.TabIndex = 0;
            this.continueCheckBox.Text = "Resume getting a partially-downloaded file";
            this.continueCheckBox.UseVisualStyleBackColor = true;
            this.continueCheckBox.CheckedChanged += new System.EventHandler(this.continueCheckBox_CheckedChanged);
            // 
            // timestampingCheckBox
            // 
            this.timestampingCheckBox.AutoSize = true;
            this.timestampingCheckBox.Location = new System.Drawing.Point(8, 54);
            this.timestampingCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timestampingCheckBox.Name = "timestampingCheckBox";
            this.timestampingCheckBox.Size = new System.Drawing.Size(300, 21);
            this.timestampingCheckBox.TabIndex = 1;
            this.timestampingCheckBox.Text = "Don\'t re-retrieve files unless newer than local";
            this.timestampingCheckBox.UseVisualStyleBackColor = true;
            this.timestampingCheckBox.CheckedChanged += new System.EventHandler(this.timestampingCheckBox_CheckedChanged);
            // 
            // schedulerGroupBox
            // 
            this.schedulerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schedulerGroupBox.Controls.Add(this.autoStartCheckBox);
            this.schedulerGroupBox.Controls.Add(this.autoStartNumDaysNumericUpDown);
            this.schedulerGroupBox.Controls.Add(this.autoStartDaysLabel);
            this.schedulerGroupBox.Controls.Add(this.autoStartNumHoursNumericUpDown);
            this.schedulerGroupBox.Controls.Add(this.autoStartHoursLabel);
            this.schedulerGroupBox.Location = new System.Drawing.Point(4, 201);
            this.schedulerGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schedulerGroupBox.Name = "schedulerGroupBox";
            this.schedulerGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schedulerGroupBox.Size = new System.Drawing.Size(412, 59);
            this.schedulerGroupBox.TabIndex = 6;
            this.schedulerGroupBox.TabStop = false;
            this.schedulerGroupBox.Text = "Scheduler";
            // 
            // autoStartCheckBox
            // 
            this.autoStartCheckBox.AutoSize = true;
            this.autoStartCheckBox.Location = new System.Drawing.Point(8, 26);
            this.autoStartCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autoStartCheckBox.Name = "autoStartCheckBox";
            this.autoStartCheckBox.Size = new System.Drawing.Size(183, 21);
            this.autoStartCheckBox.TabIndex = 0;
            this.autoStartCheckBox.Text = "Start automatically every";
            this.autoStartCheckBox.UseVisualStyleBackColor = true;
            this.autoStartCheckBox.CheckedChanged += new System.EventHandler(this.scheduleCheckBox_CheckedChanged);
            // 
            // autoStartNumDaysNumericUpDown
            // 
            this.autoStartNumDaysNumericUpDown.AutoSize = true;
            this.autoStartNumDaysNumericUpDown.Location = new System.Drawing.Point(199, 25);
            this.autoStartNumDaysNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autoStartNumDaysNumericUpDown.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.autoStartNumDaysNumericUpDown.Name = "autoStartNumDaysNumericUpDown";
            this.autoStartNumDaysNumericUpDown.Size = new System.Drawing.Size(60, 24);
            this.autoStartNumDaysNumericUpDown.TabIndex = 1;
            this.autoStartNumDaysNumericUpDown.ValueChanged += new System.EventHandler(this.autoStartNumDaysNumericUpDown_ValueChanged);
            // 
            // autoStartDaysLabel
            // 
            this.autoStartDaysLabel.AutoSize = true;
            this.autoStartDaysLabel.Location = new System.Drawing.Point(258, 28);
            this.autoStartDaysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoStartDaysLabel.Name = "autoStartDaysLabel";
            this.autoStartDaysLabel.Size = new System.Drawing.Size(37, 17);
            this.autoStartDaysLabel.TabIndex = 2;
            this.autoStartDaysLabel.Text = "days";
            // 
            // autoStartNumHoursNumericUpDown
            // 
            this.autoStartNumHoursNumericUpDown.Location = new System.Drawing.Point(302, 25);
            this.autoStartNumHoursNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autoStartNumHoursNumericUpDown.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.autoStartNumHoursNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.autoStartNumHoursNumericUpDown.Name = "autoStartNumHoursNumericUpDown";
            this.autoStartNumHoursNumericUpDown.Size = new System.Drawing.Size(51, 24);
            this.autoStartNumHoursNumericUpDown.TabIndex = 3;
            this.autoStartNumHoursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // autoStartHoursLabel
            // 
            this.autoStartHoursLabel.AutoSize = true;
            this.autoStartHoursLabel.Location = new System.Drawing.Point(361, 28);
            this.autoStartHoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoStartHoursLabel.Name = "autoStartHoursLabel";
            this.autoStartHoursLabel.Size = new System.Drawing.Size(43, 17);
            this.autoStartHoursLabel.TabIndex = 4;
            this.autoStartHoursLabel.Text = "hours";
            // 
            // outputDocumentLabel
            // 
            this.outputDocumentLabel.AutoSize = true;
            this.outputDocumentLabel.Location = new System.Drawing.Point(4, 268);
            this.outputDocumentLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.outputDocumentLabel.Name = "outputDocumentLabel";
            this.outputDocumentLabel.Size = new System.Drawing.Size(136, 17);
            this.outputDocumentLabel.TabIndex = 7;
            this.outputDocumentLabel.Text = "Write documents to:";
            // 
            // outputDocumentTextBox
            // 
            this.outputDocumentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDocumentTextBox.Location = new System.Drawing.Point(4, 288);
            this.outputDocumentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputDocumentTextBox.Name = "outputDocumentTextBox";
            this.outputDocumentTextBox.Size = new System.Drawing.Size(368, 24);
            this.outputDocumentTextBox.TabIndex = 8;
            this.outputDocumentTextBox.TextChanged += new System.EventHandler(this.outputDocumentTextBox_TextChanged);
            this.outputDocumentTextBox.Leave += new System.EventHandler(this.outputDocumentTextBox_Leave);
            // 
            // outputDocumentButton
            // 
            this.outputDocumentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDocumentButton.Location = new System.Drawing.Point(380, 286);
            this.outputDocumentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputDocumentButton.Name = "outputDocumentButton";
            this.outputDocumentButton.Size = new System.Drawing.Size(36, 29);
            this.outputDocumentButton.TabIndex = 9;
            this.outputDocumentButton.Text = "...";
            this.outputDocumentButton.UseVisualStyleBackColor = true;
            this.outputDocumentButton.Click += new System.EventHandler(this.outputDocumentButton_Click);
            // 
            // presetsGroupBox
            // 
            this.presetsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presetsGroupBox.Controls.Add(this.optionsPresetComboBox);
            this.presetsGroupBox.Controls.Add(this.loadEmptyButton);
            this.presetsGroupBox.Controls.Add(this.saveAsButton);
            this.presetsGroupBox.Controls.Add(this.deleteButton);
            this.presetsGroupBox.Location = new System.Drawing.Point(4, 4);
            this.presetsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.presetsGroupBox.Name = "presetsGroupBox";
            this.presetsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.presetsGroupBox.Size = new System.Drawing.Size(412, 95);
            this.presetsGroupBox.TabIndex = 0;
            this.presetsGroupBox.TabStop = false;
            this.presetsGroupBox.Text = "Presets";
            // 
            // optionsPresetComboBox
            // 
            this.optionsPresetComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsPresetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionsPresetComboBox.FormattingEnabled = true;
            this.optionsPresetComboBox.Location = new System.Drawing.Point(8, 25);
            this.optionsPresetComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsPresetComboBox.Name = "optionsPresetComboBox";
            this.optionsPresetComboBox.Size = new System.Drawing.Size(395, 25);
            this.optionsPresetComboBox.Sorted = true;
            this.optionsPresetComboBox.TabIndex = 0;
            this.optionsPresetComboBox.SelectedIndexChanged += new System.EventHandler(this.optionsPresetComboBox_SelectedIndexChanged);
            // 
            // loadEmptyButton
            // 
            this.loadEmptyButton.Location = new System.Drawing.Point(8, 59);
            this.loadEmptyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadEmptyButton.Name = "loadEmptyButton";
            this.loadEmptyButton.Size = new System.Drawing.Size(124, 29);
            this.loadEmptyButton.TabIndex = 1;
            this.loadEmptyButton.Text = "Load Empty";
            this.loadEmptyButton.UseVisualStyleBackColor = true;
            this.loadEmptyButton.Click += new System.EventHandler(this.loadEmptyButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAsButton.Location = new System.Drawing.Point(210, 59);
            this.saveAsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(94, 29);
            this.saveAsButton.TabIndex = 2;
            this.saveAsButton.Text = "Save As...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(311, 59);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 29);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.optionsCategoryListBox);
            this.panel1.Location = new System.Drawing.Point(4, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 221);
            this.panel1.TabIndex = 1;
            // 
            // optionsCategoryListBox
            // 
            this.optionsCategoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsCategoryListBox.FormattingEnabled = true;
            this.optionsCategoryListBox.HorizontalScrollbar = true;
            this.optionsCategoryListBox.IntegralHeight = false;
            this.optionsCategoryListBox.ItemHeight = 17;
            this.optionsCategoryListBox.Location = new System.Drawing.Point(0, 0);
            this.optionsCategoryListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsCategoryListBox.Name = "optionsCategoryListBox";
            this.optionsCategoryListBox.Size = new System.Drawing.Size(161, 221);
            this.optionsCategoryListBox.TabIndex = 0;
            this.optionsCategoryListBox.SelectedIndexChanged += new System.EventHandler(this.optionsCategoryListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.optionsListView);
            this.panel2.Location = new System.Drawing.Point(172, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 221);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.descriptionLabel);
            this.panel3.Location = new System.Drawing.Point(4, 335);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 36);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.argumentLabel);
            this.panel4.Controls.Add(this.argumentTextBox);
            this.panel4.Controls.Add(this.argumentButton);
            this.panel4.Location = new System.Drawing.Point(0, 375);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 36);
            this.panel4.TabIndex = 4;
            // 
            // generalPanel
            // 
            this.generalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalPanel.Controls.Add(this.resumingGroupBox);
            this.generalPanel.Controls.Add(this.noteTextBox);
            this.generalPanel.Controls.Add(this.noteLabel);
            this.generalPanel.Controls.Add(this.urlsLabel);
            this.generalPanel.Controls.Add(this.urlsTextBox);
            this.generalPanel.Controls.Add(this.directoryPrefixLabel);
            this.generalPanel.Controls.Add(this.directoryPrefixComboBox);
            this.generalPanel.Controls.Add(this.directoryPrefixButton);
            this.generalPanel.Controls.Add(this.schedulerGroupBox);
            this.generalPanel.Controls.Add(this.outputDocumentLabel);
            this.generalPanel.Controls.Add(this.outputDocumentTextBox);
            this.generalPanel.Controls.Add(this.outputDocumentButton);
            this.generalPanel.Location = new System.Drawing.Point(165, 8);
            this.generalPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(420, 411);
            this.generalPanel.TabIndex = 1;
            // 
            // resumingGroupBox
            // 
            this.resumingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resumingGroupBox.Controls.Add(this.continueCheckBox);
            this.resumingGroupBox.Controls.Add(this.timestampingCheckBox);
            this.resumingGroupBox.Location = new System.Drawing.Point(4, 111);
            this.resumingGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resumingGroupBox.Name = "resumingGroupBox";
            this.resumingGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resumingGroupBox.Size = new System.Drawing.Size(412, 82);
            this.resumingGroupBox.TabIndex = 5;
            this.resumingGroupBox.TabStop = false;
            this.resumingGroupBox.Text = "Resuming";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.Location = new System.Drawing.Point(4, 341);
            this.noteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(412, 24);
            this.noteTextBox.TabIndex = 11;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(4, 321);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(42, 17);
            this.noteLabel.TabIndex = 10;
            this.noteLabel.Text = "Note:";
            // 
            // advancedPanel
            // 
            this.advancedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel.Controls.Add(this.presetsGroupBox);
            this.advancedPanel.Controls.Add(this.panel1);
            this.advancedPanel.Controls.Add(this.panel2);
            this.advancedPanel.Controls.Add(this.panel3);
            this.advancedPanel.Controls.Add(this.panel4);
            this.advancedPanel.Location = new System.Drawing.Point(165, 8);
            this.advancedPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.advancedPanel.Name = "advancedPanel";
            this.advancedPanel.Size = new System.Drawing.Size(420, 411);
            this.advancedPanel.TabIndex = 2;
            // 
            // jobCatListBox
            // 
            this.jobCatListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobCatListBox.FormattingEnabled = true;
            this.jobCatListBox.ItemHeight = 17;
            this.jobCatListBox.Items.AddRange(new object[] {
            "General",
            "HTTP",
            "Advanced"});
            this.jobCatListBox.Location = new System.Drawing.Point(0, 0);
            this.jobCatListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jobCatListBox.Name = "jobCatListBox";
            this.jobCatListBox.Size = new System.Drawing.Size(150, 411);
            this.jobCatListBox.TabIndex = 0;
            this.jobCatListBox.SelectedIndexChanged += new System.EventHandler(this.jobCatListBox_SelectedIndexChanged);
            // 
            // httpPanel
            // 
            this.httpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.httpPanel.Controls.Add(this.refererTextBox);
            this.httpPanel.Controls.Add(this.refererLabel);
            this.httpPanel.Controls.Add(this.userAgentLabel);
            this.httpPanel.Controls.Add(this.userAgentComboBox);
            this.httpPanel.Location = new System.Drawing.Point(165, 8);
            this.httpPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.httpPanel.Name = "httpPanel";
            this.httpPanel.Size = new System.Drawing.Size(420, 411);
            this.httpPanel.TabIndex = 3;
            // 
            // refererTextBox
            // 
            this.refererTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refererTextBox.Location = new System.Drawing.Point(4, 78);
            this.refererTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refererTextBox.Name = "refererTextBox";
            this.refererTextBox.Size = new System.Drawing.Size(412, 24);
            this.refererTextBox.TabIndex = 3;
            this.refererTextBox.TextChanged += new System.EventHandler(this.refererTextBox_TextChanged);
            // 
            // refererLabel
            // 
            this.refererLabel.AutoSize = true;
            this.refererLabel.Location = new System.Drawing.Point(4, 58);
            this.refererLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.refererLabel.Name = "refererLabel";
            this.refererLabel.Size = new System.Drawing.Size(57, 17);
            this.refererLabel.TabIndex = 2;
            this.refererLabel.Text = "Referer:";
            // 
            // userAgentLabel
            // 
            this.userAgentLabel.AutoSize = true;
            this.userAgentLabel.Location = new System.Drawing.Point(4, 4);
            this.userAgentLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.userAgentLabel.Name = "userAgentLabel";
            this.userAgentLabel.Size = new System.Drawing.Size(79, 17);
            this.userAgentLabel.TabIndex = 0;
            this.userAgentLabel.Text = "User agent:";
            // 
            // userAgentComboBox
            // 
            this.userAgentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userAgentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userAgentComboBox.FormattingEnabled = true;
            this.userAgentComboBox.Location = new System.Drawing.Point(4, 24);
            this.userAgentComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userAgentComboBox.Name = "userAgentComboBox";
            this.userAgentComboBox.Size = new System.Drawing.Size(412, 25);
            this.userAgentComboBox.TabIndex = 1;
            this.userAgentComboBox.SelectedIndexChanged += new System.EventHandler(this.userAgentComboBox_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.jobCatListBox);
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 411);
            this.panel5.TabIndex = 0;
            // 
            // JobDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(592, 462);
            this.Controls.Add(this.generalPanel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startOnOkCheckBox);
            this.Controls.Add(this.advancedPanel);
            this.Controls.Add(this.httpPanel);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobDialog";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JobDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JobDialog_FormClosing);
            this.Load += new System.EventHandler(this.JobDialog_Load);
            this.Shown += new System.EventHandler(this.JobDialog_Shown);
            this.schedulerGroupBox.ResumeLayout(false);
            this.schedulerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoStartNumDaysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoStartNumHoursNumericUpDown)).EndInit();
            this.presetsGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.resumingGroupBox.ResumeLayout(false);
            this.resumingGroupBox.PerformLayout();
            this.advancedPanel.ResumeLayout(false);
            this.httpPanel.ResumeLayout(false);
            this.httpPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label argumentLabel;
        private System.Windows.Forms.TextBox urlsTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox argumentTextBox;
        private System.Windows.Forms.Button argumentButton;
        private System.Windows.Forms.CheckBox startOnOkCheckBox;
        private System.Windows.Forms.ListView optionsListView;
        private System.Windows.Forms.GroupBox presetsGroupBox;
        private System.Windows.Forms.Button directoryPrefixButton;
        private System.Windows.Forms.Label directoryPrefixLabel;
        private System.Windows.Forms.Label urlsLabel;
        private System.Windows.Forms.CheckBox timestampingCheckBox;
        private System.Windows.Forms.CheckBox continueCheckBox;
        private System.Windows.Forms.ComboBox optionsPresetComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.ComboBox directoryPrefixComboBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox optionsCategoryListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label outputDocumentLabel;
        private System.Windows.Forms.Button outputDocumentButton;
        private System.Windows.Forms.TextBox outputDocumentTextBox;
        private System.Windows.Forms.Label autoStartDaysLabel;
        private System.Windows.Forms.NumericUpDown autoStartNumDaysNumericUpDown;
        private System.Windows.Forms.CheckBox autoStartCheckBox;
        private System.Windows.Forms.GroupBox schedulerGroupBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label autoStartHoursLabel;
        private System.Windows.Forms.NumericUpDown autoStartNumHoursNumericUpDown;
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Panel advancedPanel;
        private System.Windows.Forms.ListBox jobCatListBox;
        private System.Windows.Forms.Button loadEmptyButton;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Panel httpPanel;
        private System.Windows.Forms.ComboBox userAgentComboBox;
        private System.Windows.Forms.Label userAgentLabel;
        private System.Windows.Forms.TextBox refererTextBox;
        private System.Windows.Forms.Label refererLabel;
        private System.Windows.Forms.GroupBox resumingGroupBox;
        private System.Windows.Forms.Panel panel5;
    }
}