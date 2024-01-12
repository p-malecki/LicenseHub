namespace LicenseHubApp.Views.Forms
{
    partial class ClientManagementUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCompanyData = new DataGridView();
            label1 = new Label();
            txtCompanySearchValue = new TextBox();
            cbCompanySelectedFilter = new ComboBox();
            btnCompanySearch = new Button();
            tabControlSidePanelLeft = new TabControl();
            tpCompanyDetails = new TabPage();
            label9 = new Label();
            lbCompanyIsActiveInfo = new Label();
            label2 = new Label();
            txtCompanyName = new TextBox();
            label3 = new Label();
            txtCompanyNip = new TextBox();
            label4 = new Label();
            rtxtCompanyLocalizations = new RichTextBox();
            label5 = new Label();
            rtxtCompanyWebsites = new RichTextBox();
            label6 = new Label();
            rtxtCompanyDescription = new RichTextBox();
            btnCompanyToggleIsActive = new Button();
            btnCompanySave = new Button();
            btnCompanyEditCancel = new Button();
            tpSidePanelData = new TabPage();
            lbSidePanelLeftTabTitle = new Label();
            chbSidePanelSearchOnlyActive = new CheckBox();
            cbSidePanelSelectedFilter = new ComboBox();
            txtSidePanelSearchValue = new TextBox();
            btnSidePanelSearch = new Button();
            dgvSidePanelData = new DataGridView();
            btnSidePanelShowDetails = new Button();
            btnSidePanelAdd = new Button();
            btnSidePanelEdit = new Button();
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            button3 = new Button();
            chbCompanySearchOnlyActive = new CheckBox();
            btnCompanyShowDetails = new Button();
            btnCompanyAdd = new Button();
            btnCompanyEdit = new Button();
            btnCompanyShowEmployees = new Button();
            btnCloseSidePanel = new Button();
            tabControlSidePanelRight = new TabControl();
            tpSidePanelEmployeeDetails = new TabPage();
            label7 = new Label();
            lbEmployeeIsActiveInfo = new Label();
            label10 = new Label();
            txtEmployeeName = new TextBox();
            label11 = new Label();
            txtEmployeeProfession = new TextBox();
            label12 = new Label();
            rtxtEmployeePhoneNumbers = new RichTextBox();
            label15 = new Label();
            rtxtEmployeeEmails = new RichTextBox();
            label13 = new Label();
            rtxtEmployeeWebsites = new RichTextBox();
            label8 = new Label();
            rtxtEmployeeIPs = new RichTextBox();
            label14 = new Label();
            rtxtEmployeeDescription = new RichTextBox();
            tpSidePanelWorkstationDetails = new TabPage();
            label16 = new Label();
            lbWorkstationHasFaultInfo = new Label();
            label18 = new Label();
            txtWorkstationComputerName = new TextBox();
            label19 = new Label();
            txtWorkstationUsername = new TextBox();
            label20 = new Label();
            rtxtWorkstationHardDisk = new RichTextBox();
            label21 = new Label();
            rtxtWorkstationCpu = new RichTextBox();
            label23 = new Label();
            rtxtWorkstationBiosVersion = new RichTextBox();
            label17 = new Label();
            txtWorkstationOs = new TextBox();
            label24 = new Label();
            txtWorkstationOsBitVersion = new TextBox();
            groupBox1 = new GroupBox();
            btnSidePanelToggleIsActive = new Button();
            btnSidePanelSave = new Button();
            btnSidePanelEditCancel = new Button();
            btnCompanyShowWorkstations = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompanyData).BeginInit();
            tabControlSidePanelLeft.SuspendLayout();
            tpCompanyDetails.SuspendLayout();
            tpSidePanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSidePanelData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControlSidePanelRight.SuspendLayout();
            tpSidePanelEmployeeDetails.SuspendLayout();
            tpSidePanelWorkstationDetails.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCompanyData
            // 
            dgvCompanyData.AllowUserToAddRows = false;
            dgvCompanyData.AllowUserToDeleteRows = false;
            dgvCompanyData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompanyData.Location = new Point(46, 161);
            dgvCompanyData.MultiSelect = false;
            dgvCompanyData.Name = "dgvCompanyData";
            dgvCompanyData.ReadOnly = true;
            dgvCompanyData.RowHeadersWidth = 62;
            dgvCompanyData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompanyData.Size = new Size(1164, 852);
            dgvCompanyData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(46, 107);
            label1.Name = "label1";
            label1.Size = new Size(116, 45);
            label1.TabIndex = 1;
            label1.Text = "Clients";
            // 
            // txtCompanySearchValue
            // 
            txtCompanySearchValue.Location = new Point(210, 120);
            txtCompanySearchValue.Name = "txtCompanySearchValue";
            txtCompanySearchValue.Size = new Size(258, 31);
            txtCompanySearchValue.TabIndex = 2;
            // 
            // cbCompanySelectedFilter
            // 
            cbCompanySelectedFilter.FormattingEnabled = true;
            cbCompanySelectedFilter.Location = new Point(474, 122);
            cbCompanySelectedFilter.Name = "cbCompanySelectedFilter";
            cbCompanySelectedFilter.Size = new Size(182, 33);
            cbCompanySelectedFilter.TabIndex = 3;
            // 
            // btnCompanySearch
            // 
            btnCompanySearch.Location = new Point(662, 120);
            btnCompanySearch.Name = "btnCompanySearch";
            btnCompanySearch.Size = new Size(112, 34);
            btnCompanySearch.TabIndex = 4;
            btnCompanySearch.Text = "Search";
            btnCompanySearch.UseVisualStyleBackColor = true;
            // 
            // tabControlSidePanelLeft
            // 
            tabControlSidePanelLeft.Controls.Add(tpCompanyDetails);
            tabControlSidePanelLeft.Controls.Add(tpSidePanelData);
            tabControlSidePanelLeft.Location = new Point(33, 55);
            tabControlSidePanelLeft.Name = "tabControlSidePanelLeft";
            tabControlSidePanelLeft.SelectedIndex = 0;
            tabControlSidePanelLeft.Size = new Size(594, 1066);
            tabControlSidePanelLeft.TabIndex = 5;
            // 
            // tpCompanyDetails
            // 
            tpCompanyDetails.BackColor = Color.WhiteSmoke;
            tpCompanyDetails.Controls.Add(label9);
            tpCompanyDetails.Controls.Add(lbCompanyIsActiveInfo);
            tpCompanyDetails.Controls.Add(label2);
            tpCompanyDetails.Controls.Add(txtCompanyName);
            tpCompanyDetails.Controls.Add(label3);
            tpCompanyDetails.Controls.Add(txtCompanyNip);
            tpCompanyDetails.Controls.Add(label4);
            tpCompanyDetails.Controls.Add(rtxtCompanyLocalizations);
            tpCompanyDetails.Controls.Add(label5);
            tpCompanyDetails.Controls.Add(rtxtCompanyWebsites);
            tpCompanyDetails.Controls.Add(label6);
            tpCompanyDetails.Controls.Add(rtxtCompanyDescription);
            tpCompanyDetails.Controls.Add(btnCompanyToggleIsActive);
            tpCompanyDetails.Controls.Add(btnCompanySave);
            tpCompanyDetails.Controls.Add(btnCompanyEditCancel);
            tpCompanyDetails.Location = new Point(4, 34);
            tpCompanyDetails.Name = "tpCompanyDetails";
            tpCompanyDetails.Padding = new Padding(3);
            tpCompanyDetails.Size = new Size(586, 1028);
            tpCompanyDetails.TabIndex = 0;
            tpCompanyDetails.Text = "Client details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(6, 18);
            label9.Name = "label9";
            label9.Size = new Size(204, 45);
            label9.TabIndex = 16;
            label9.Text = "Client details";
            // 
            // lbCompanyIsActiveInfo
            // 
            lbCompanyIsActiveInfo.AutoSize = true;
            lbCompanyIsActiveInfo.ForeColor = SystemColors.ControlDark;
            lbCompanyIsActiveInfo.Location = new Point(17, 99);
            lbCompanyIsActiveInfo.Name = "lbCompanyIsActiveInfo";
            lbCompanyIsActiveInfo.Size = new Size(104, 25);
            lbCompanyIsActiveInfo.TabIndex = 5;
            lbCompanyIsActiveInfo.Text = "isActiveInfo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 124);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 2;
            label2.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
            txtCompanyName.Location = new Point(26, 152);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.ReadOnly = true;
            txtCompanyName.Size = new Size(523, 31);
            txtCompanyName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 193);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 4;
            label3.Text = "NIP";
            // 
            // txtCompanyNip
            // 
            txtCompanyNip.BorderStyle = BorderStyle.FixedSingle;
            txtCompanyNip.Location = new Point(26, 221);
            txtCompanyNip.Name = "txtCompanyNip";
            txtCompanyNip.ReadOnly = true;
            txtCompanyNip.Size = new Size(523, 31);
            txtCompanyNip.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 272);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 6;
            label4.Text = "Localizations";
            // 
            // rtxtCompanyLocalizations
            // 
            rtxtCompanyLocalizations.BorderStyle = BorderStyle.FixedSingle;
            rtxtCompanyLocalizations.Location = new Point(26, 300);
            rtxtCompanyLocalizations.Name = "rtxtCompanyLocalizations";
            rtxtCompanyLocalizations.ReadOnly = true;
            rtxtCompanyLocalizations.Size = new Size(523, 82);
            rtxtCompanyLocalizations.TabIndex = 2;
            rtxtCompanyLocalizations.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 398);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 8;
            label5.Text = "Websites";
            // 
            // rtxtCompanyWebsites
            // 
            rtxtCompanyWebsites.BorderStyle = BorderStyle.FixedSingle;
            rtxtCompanyWebsites.Location = new Point(26, 426);
            rtxtCompanyWebsites.Name = "rtxtCompanyWebsites";
            rtxtCompanyWebsites.ReadOnly = true;
            rtxtCompanyWebsites.Size = new Size(523, 82);
            rtxtCompanyWebsites.TabIndex = 3;
            rtxtCompanyWebsites.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 524);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 10;
            label6.Text = "Description";
            // 
            // rtxtCompanyDescription
            // 
            rtxtCompanyDescription.BorderStyle = BorderStyle.FixedSingle;
            rtxtCompanyDescription.Location = new Point(26, 552);
            rtxtCompanyDescription.Name = "rtxtCompanyDescription";
            rtxtCompanyDescription.ReadOnly = true;
            rtxtCompanyDescription.Size = new Size(523, 145);
            rtxtCompanyDescription.TabIndex = 4;
            rtxtCompanyDescription.Text = "";
            // 
            // btnCompanyToggleIsActive
            // 
            btnCompanyToggleIsActive.Location = new Point(26, 714);
            btnCompanyToggleIsActive.Name = "btnCompanyToggleIsActive";
            btnCompanyToggleIsActive.Size = new Size(114, 68);
            btnCompanyToggleIsActive.TabIndex = 5;
            btnCompanyToggleIsActive.Text = "Toggle\r\nIsActive";
            btnCompanyToggleIsActive.UseVisualStyleBackColor = true;
            // 
            // btnCompanySave
            // 
            btnCompanySave.Location = new Point(280, 714);
            btnCompanySave.Name = "btnCompanySave";
            btnCompanySave.Size = new Size(156, 68);
            btnCompanySave.TabIndex = 6;
            btnCompanySave.Text = "Save changes";
            btnCompanySave.UseVisualStyleBackColor = true;
            // 
            // btnCompanyEditCancel
            // 
            btnCompanyEditCancel.Location = new Point(442, 714);
            btnCompanyEditCancel.Name = "btnCompanyEditCancel";
            btnCompanyEditCancel.Size = new Size(107, 68);
            btnCompanyEditCancel.TabIndex = 7;
            btnCompanyEditCancel.Text = "Cancel";
            btnCompanyEditCancel.UseVisualStyleBackColor = true;
            // 
            // tpSidePanelData
            // 
            tpSidePanelData.BackColor = Color.WhiteSmoke;
            tpSidePanelData.Controls.Add(lbSidePanelLeftTabTitle);
            tpSidePanelData.Controls.Add(chbSidePanelSearchOnlyActive);
            tpSidePanelData.Controls.Add(cbSidePanelSelectedFilter);
            tpSidePanelData.Controls.Add(txtSidePanelSearchValue);
            tpSidePanelData.Controls.Add(btnSidePanelSearch);
            tpSidePanelData.Controls.Add(dgvSidePanelData);
            tpSidePanelData.Controls.Add(btnSidePanelShowDetails);
            tpSidePanelData.Controls.Add(btnSidePanelAdd);
            tpSidePanelData.Controls.Add(btnSidePanelEdit);
            tpSidePanelData.Location = new Point(4, 34);
            tpSidePanelData.Name = "tpSidePanelData";
            tpSidePanelData.Padding = new Padding(3);
            tpSidePanelData.Size = new Size(586, 1028);
            tpSidePanelData.TabIndex = 1;
            tpSidePanelData.Text = "SidePanel data";
            // 
            // lbSidePanelLeftTabTitle
            // 
            lbSidePanelLeftTabTitle.AutoSize = true;
            lbSidePanelLeftTabTitle.Font = new Font("Segoe UI", 16F);
            lbSidePanelLeftTabTitle.Location = new Point(6, 15);
            lbSidePanelLeftTabTitle.Name = "lbSidePanelLeftTabTitle";
            lbSidePanelLeftTabTitle.Size = new Size(173, 45);
            lbSidePanelLeftTabTitle.TabIndex = 16;
            lbSidePanelLeftTabTitle.Text = "Employees";
            // 
            // chbSidePanelSearchOnlyActive
            // 
            chbSidePanelSearchOnlyActive.AutoSize = true;
            chbSidePanelSearchOnlyActive.Location = new Point(243, 24);
            chbSidePanelSearchOnlyActive.Name = "chbSidePanelSearchOnlyActive";
            chbSidePanelSearchOnlyActive.Size = new Size(128, 29);
            chbSidePanelSearchOnlyActive.TabIndex = 19;
            chbSidePanelSearchOnlyActive.Text = "Only Active";
            chbSidePanelSearchOnlyActive.UseVisualStyleBackColor = true;
            // 
            // cbSidePanelSelectedFilter
            // 
            cbSidePanelSelectedFilter.FormattingEnabled = true;
            cbSidePanelSelectedFilter.Location = new Point(377, 28);
            cbSidePanelSelectedFilter.Name = "cbSidePanelSelectedFilter";
            cbSidePanelSelectedFilter.Size = new Size(182, 33);
            cbSidePanelSelectedFilter.TabIndex = 17;
            // 
            // txtSidePanelSearchValue
            // 
            txtSidePanelSearchValue.Location = new Point(25, 69);
            txtSidePanelSearchValue.Name = "txtSidePanelSearchValue";
            txtSidePanelSearchValue.Size = new Size(416, 31);
            txtSidePanelSearchValue.TabIndex = 16;
            // 
            // btnSidePanelSearch
            // 
            btnSidePanelSearch.Location = new Point(447, 67);
            btnSidePanelSearch.Name = "btnSidePanelSearch";
            btnSidePanelSearch.Size = new Size(112, 34);
            btnSidePanelSearch.TabIndex = 18;
            btnSidePanelSearch.Text = "Search";
            btnSidePanelSearch.UseVisualStyleBackColor = true;
            // 
            // dgvSidePanelData
            // 
            dgvSidePanelData.AllowUserToAddRows = false;
            dgvSidePanelData.AllowUserToDeleteRows = false;
            dgvSidePanelData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSidePanelData.Location = new Point(6, 107);
            dgvSidePanelData.MultiSelect = false;
            dgvSidePanelData.Name = "dgvSidePanelData";
            dgvSidePanelData.ReadOnly = true;
            dgvSidePanelData.RowHeadersWidth = 62;
            dgvSidePanelData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSidePanelData.Size = new Size(574, 817);
            dgvSidePanelData.TabIndex = 7;
            // 
            // btnSidePanelShowDetails
            // 
            btnSidePanelShowDetails.Location = new Point(6, 930);
            btnSidePanelShowDetails.Name = "btnSidePanelShowDetails";
            btnSidePanelShowDetails.Size = new Size(156, 68);
            btnSidePanelShowDetails.TabIndex = 16;
            btnSidePanelShowDetails.Text = "Show details ";
            btnSidePanelShowDetails.UseVisualStyleBackColor = true;
            // 
            // btnSidePanelAdd
            // 
            btnSidePanelAdd.Location = new Point(167, 930);
            btnSidePanelAdd.Name = "btnSidePanelAdd";
            btnSidePanelAdd.Size = new Size(156, 68);
            btnSidePanelAdd.TabIndex = 16;
            btnSidePanelAdd.Text = "Add new";
            btnSidePanelAdd.UseVisualStyleBackColor = true;
            // 
            // btnSidePanelEdit
            // 
            btnSidePanelEdit.Location = new Point(329, 930);
            btnSidePanelEdit.Name = "btnSidePanelEdit";
            btnSidePanelEdit.Size = new Size(156, 68);
            btnSidePanelEdit.TabIndex = 17;
            btnSidePanelEdit.Text = "Edit";
            btnSidePanelEdit.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(chbCompanySearchOnlyActive);
            splitContainer1.Panel1.Controls.Add(txtCompanySearchValue);
            splitContainer1.Panel1.Controls.Add(cbCompanySelectedFilter);
            splitContainer1.Panel1.Controls.Add(btnCompanySearch);
            splitContainer1.Panel1.Controls.Add(dgvCompanyData);
            splitContainer1.Panel1.Controls.Add(btnCompanyShowDetails);
            splitContainer1.Panel1.Controls.Add(btnCompanyAdd);
            splitContainer1.Panel1.Controls.Add(btnCompanyEdit);
            splitContainer1.Panel1.Controls.Add(btnCompanyShowEmployees);
            splitContainer1.Panel1.Controls.Add(btnCompanyShowWorkstations);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel2.Controls.Add(btnCloseSidePanel);
            splitContainer1.Panel2.Controls.Add(tabControlSidePanelLeft);
            splitContainer1.Panel2.Controls.Add(tabControlSidePanelRight);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1407, 1156);
            splitContainer1.SplitterDistance = 736;
            splitContainer1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(619, 3);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // chbCompanySearchOnlyActive
            // 
            chbCompanySearchOnlyActive.AutoSize = true;
            chbCompanySearchOnlyActive.Location = new Point(210, 85);
            chbCompanySearchOnlyActive.Name = "chbCompanySearchOnlyActive";
            chbCompanySearchOnlyActive.Size = new Size(222, 29);
            chbCompanySearchOnlyActive.TabIndex = 13;
            chbCompanySearchOnlyActive.Text = "Only Active Companies";
            chbCompanySearchOnlyActive.UseVisualStyleBackColor = true;
            // 
            // btnCompanyShowDetails
            // 
            btnCompanyShowDetails.Location = new Point(46, 1019);
            btnCompanyShowDetails.Name = "btnCompanyShowDetails";
            btnCompanyShowDetails.Size = new Size(225, 68);
            btnCompanyShowDetails.TabIndex = 14;
            btnCompanyShowDetails.Text = "Show details ";
            btnCompanyShowDetails.UseVisualStyleBackColor = true;
            // 
            // btnCompanyAdd
            // 
            btnCompanyAdd.Location = new Point(279, 1019);
            btnCompanyAdd.Name = "btnCompanyAdd";
            btnCompanyAdd.Size = new Size(156, 68);
            btnCompanyAdd.TabIndex = 10;
            btnCompanyAdd.Text = "Add new";
            btnCompanyAdd.UseVisualStyleBackColor = true;
            // 
            // btnCompanyEdit
            // 
            btnCompanyEdit.Location = new Point(441, 1019);
            btnCompanyEdit.Name = "btnCompanyEdit";
            btnCompanyEdit.Size = new Size(156, 68);
            btnCompanyEdit.TabIndex = 12;
            btnCompanyEdit.Text = "Edit details";
            btnCompanyEdit.UseVisualStyleBackColor = true;
            // 
            // btnCompanyShowEmployees
            // 
            btnCompanyShowEmployees.Location = new Point(603, 1019);
            btnCompanyShowEmployees.Name = "btnCompanyShowEmployees";
            btnCompanyShowEmployees.Size = new Size(156, 68);
            btnCompanyShowEmployees.TabIndex = 15;
            btnCompanyShowEmployees.Text = "Show employees";
            btnCompanyShowEmployees.UseVisualStyleBackColor = true;
            // 
            // btnCloseSidePanel
            // 
            btnCloseSidePanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseSidePanel.Location = new Point(568, 0);
            btnCloseSidePanel.Name = "btnCloseSidePanel";
            btnCloseSidePanel.Size = new Size(56, 34);
            btnCloseSidePanel.TabIndex = 6;
            btnCloseSidePanel.Text = "X";
            btnCloseSidePanel.UseVisualStyleBackColor = true;
            btnCloseSidePanel.Click += button2_Click;
            // 
            // tabControlSidePanelRight
            // 
            tabControlSidePanelRight.Controls.Add(tpSidePanelEmployeeDetails);
            tabControlSidePanelRight.Controls.Add(tpSidePanelWorkstationDetails);
            tabControlSidePanelRight.Location = new Point(671, 55);
            tabControlSidePanelRight.Name = "tabControlSidePanelRight";
            tabControlSidePanelRight.SelectedIndex = 0;
            tabControlSidePanelRight.Size = new Size(592, 988);
            tabControlSidePanelRight.TabIndex = 18;
            // 
            // tpSidePanelEmployeeDetails
            // 
            tpSidePanelEmployeeDetails.BackColor = Color.WhiteSmoke;
            tpSidePanelEmployeeDetails.Controls.Add(label7);
            tpSidePanelEmployeeDetails.Controls.Add(lbEmployeeIsActiveInfo);
            tpSidePanelEmployeeDetails.Controls.Add(label10);
            tpSidePanelEmployeeDetails.Controls.Add(txtEmployeeName);
            tpSidePanelEmployeeDetails.Controls.Add(label11);
            tpSidePanelEmployeeDetails.Controls.Add(txtEmployeeProfession);
            tpSidePanelEmployeeDetails.Controls.Add(label12);
            tpSidePanelEmployeeDetails.Controls.Add(rtxtEmployeePhoneNumbers);
            tpSidePanelEmployeeDetails.Controls.Add(label15);
            tpSidePanelEmployeeDetails.Controls.Add(rtxtEmployeeEmails);
            tpSidePanelEmployeeDetails.Controls.Add(label13);
            tpSidePanelEmployeeDetails.Controls.Add(rtxtEmployeeWebsites);
            tpSidePanelEmployeeDetails.Controls.Add(label8);
            tpSidePanelEmployeeDetails.Controls.Add(rtxtEmployeeIPs);
            tpSidePanelEmployeeDetails.Controls.Add(label14);
            tpSidePanelEmployeeDetails.Controls.Add(rtxtEmployeeDescription);
            tpSidePanelEmployeeDetails.Location = new Point(4, 34);
            tpSidePanelEmployeeDetails.Name = "tpSidePanelEmployeeDetails";
            tpSidePanelEmployeeDetails.Padding = new Padding(3);
            tpSidePanelEmployeeDetails.Size = new Size(584, 950);
            tpSidePanelEmployeeDetails.TabIndex = 0;
            tpSidePanelEmployeeDetails.Text = "Employee details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(24, 31);
            label7.Name = "label7";
            label7.Size = new Size(261, 45);
            label7.TabIndex = 31;
            label7.Text = "Employee details";
            // 
            // lbEmployeeIsActiveInfo
            // 
            lbEmployeeIsActiveInfo.AutoSize = true;
            lbEmployeeIsActiveInfo.ForeColor = SystemColors.ControlDark;
            lbEmployeeIsActiveInfo.Location = new Point(35, 112);
            lbEmployeeIsActiveInfo.Name = "lbEmployeeIsActiveInfo";
            lbEmployeeIsActiveInfo.Size = new Size(104, 25);
            lbEmployeeIsActiveInfo.TabIndex = 24;
            lbEmployeeIsActiveInfo.Text = "isActiveInfo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 137);
            label10.Name = "label10";
            label10.Size = new Size(142, 25);
            label10.TabIndex = 19;
            label10.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BorderStyle = BorderStyle.FixedSingle;
            txtEmployeeName.Location = new Point(44, 165);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(523, 31);
            txtEmployeeName.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 206);
            label11.Name = "label11";
            label11.Size = new Size(95, 25);
            label11.TabIndex = 22;
            label11.Text = "Profession";
            // 
            // txtEmployeeProfession
            // 
            txtEmployeeProfession.BorderStyle = BorderStyle.FixedSingle;
            txtEmployeeProfession.Location = new Point(44, 234);
            txtEmployeeProfession.Name = "txtEmployeeProfession";
            txtEmployeeProfession.ReadOnly = true;
            txtEmployeeProfession.Size = new Size(523, 31);
            txtEmployeeProfession.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 285);
            label12.Name = "label12";
            label12.Size = new Size(137, 25);
            label12.TabIndex = 26;
            label12.Text = "Phone numbers";
            // 
            // rtxtEmployeePhoneNumbers
            // 
            rtxtEmployeePhoneNumbers.BorderStyle = BorderStyle.FixedSingle;
            rtxtEmployeePhoneNumbers.Location = new Point(44, 313);
            rtxtEmployeePhoneNumbers.Name = "rtxtEmployeePhoneNumbers";
            rtxtEmployeePhoneNumbers.ReadOnly = true;
            rtxtEmployeePhoneNumbers.Size = new Size(523, 82);
            rtxtEmployeePhoneNumbers.TabIndex = 20;
            rtxtEmployeePhoneNumbers.Text = "";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(35, 406);
            label15.Name = "label15";
            label15.Size = new Size(62, 25);
            label15.TabIndex = 26;
            label15.Text = "Emails";
            // 
            // rtxtEmployeeEmails
            // 
            rtxtEmployeeEmails.BorderStyle = BorderStyle.FixedSingle;
            rtxtEmployeeEmails.Location = new Point(44, 434);
            rtxtEmployeeEmails.Name = "rtxtEmployeeEmails";
            rtxtEmployeeEmails.ReadOnly = true;
            rtxtEmployeeEmails.Size = new Size(523, 82);
            rtxtEmployeeEmails.TabIndex = 20;
            rtxtEmployeeEmails.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(35, 530);
            label13.Name = "label13";
            label13.Size = new Size(83, 25);
            label13.TabIndex = 29;
            label13.Text = "Websites";
            // 
            // rtxtEmployeeWebsites
            // 
            rtxtEmployeeWebsites.BorderStyle = BorderStyle.FixedSingle;
            rtxtEmployeeWebsites.Location = new Point(44, 558);
            rtxtEmployeeWebsites.Name = "rtxtEmployeeWebsites";
            rtxtEmployeeWebsites.ReadOnly = true;
            rtxtEmployeeWebsites.Size = new Size(523, 82);
            rtxtEmployeeWebsites.TabIndex = 21;
            rtxtEmployeeWebsites.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 650);
            label8.Name = "label8";
            label8.Size = new Size(35, 25);
            label8.TabIndex = 29;
            label8.Text = "IPs";
            // 
            // rtxtEmployeeIPs
            // 
            rtxtEmployeeIPs.BorderStyle = BorderStyle.FixedSingle;
            rtxtEmployeeIPs.Location = new Point(44, 678);
            rtxtEmployeeIPs.Name = "rtxtEmployeeIPs";
            rtxtEmployeeIPs.ReadOnly = true;
            rtxtEmployeeIPs.Size = new Size(523, 82);
            rtxtEmployeeIPs.TabIndex = 21;
            rtxtEmployeeIPs.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 772);
            label14.Name = "label14";
            label14.Size = new Size(102, 25);
            label14.TabIndex = 30;
            label14.Text = "Description";
            // 
            // rtxtEmployeeDescription
            // 
            rtxtEmployeeDescription.BorderStyle = BorderStyle.FixedSingle;
            rtxtEmployeeDescription.Location = new Point(44, 800);
            rtxtEmployeeDescription.Name = "rtxtEmployeeDescription";
            rtxtEmployeeDescription.ReadOnly = true;
            rtxtEmployeeDescription.Size = new Size(523, 129);
            rtxtEmployeeDescription.TabIndex = 23;
            rtxtEmployeeDescription.Text = "";
            // 
            // tpSidePanelWorkstationDetails
            // 
            tpSidePanelWorkstationDetails.BackColor = Color.WhiteSmoke;
            tpSidePanelWorkstationDetails.Controls.Add(label16);
            tpSidePanelWorkstationDetails.Controls.Add(lbWorkstationHasFaultInfo);
            tpSidePanelWorkstationDetails.Controls.Add(label18);
            tpSidePanelWorkstationDetails.Controls.Add(txtWorkstationComputerName);
            tpSidePanelWorkstationDetails.Controls.Add(label19);
            tpSidePanelWorkstationDetails.Controls.Add(txtWorkstationUsername);
            tpSidePanelWorkstationDetails.Controls.Add(label20);
            tpSidePanelWorkstationDetails.Controls.Add(rtxtWorkstationHardDisk);
            tpSidePanelWorkstationDetails.Controls.Add(label21);
            tpSidePanelWorkstationDetails.Controls.Add(rtxtWorkstationCpu);
            tpSidePanelWorkstationDetails.Controls.Add(label23);
            tpSidePanelWorkstationDetails.Controls.Add(rtxtWorkstationBiosVersion);
            tpSidePanelWorkstationDetails.Controls.Add(label17);
            tpSidePanelWorkstationDetails.Controls.Add(txtWorkstationOs);
            tpSidePanelWorkstationDetails.Controls.Add(label24);
            tpSidePanelWorkstationDetails.Controls.Add(txtWorkstationOsBitVersion);
            tpSidePanelWorkstationDetails.Location = new Point(4, 34);
            tpSidePanelWorkstationDetails.Name = "tpSidePanelWorkstationDetails";
            tpSidePanelWorkstationDetails.Padding = new Padding(3);
            tpSidePanelWorkstationDetails.Size = new Size(584, 950);
            tpSidePanelWorkstationDetails.TabIndex = 1;
            tpSidePanelWorkstationDetails.Text = "Workstation details";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 16F);
            label16.Location = new Point(22, 33);
            label16.Name = "label16";
            label16.Size = new Size(294, 45);
            label16.TabIndex = 48;
            label16.Text = "Workstation details";
            // 
            // lbWorkstationHasFaultInfo
            // 
            lbWorkstationHasFaultInfo.AutoSize = true;
            lbWorkstationHasFaultInfo.ForeColor = SystemColors.ControlDark;
            lbWorkstationHasFaultInfo.Location = new Point(33, 114);
            lbWorkstationHasFaultInfo.Name = "lbWorkstationHasFaultInfo";
            lbWorkstationHasFaultInfo.Size = new Size(108, 25);
            lbWorkstationHasFaultInfo.TabIndex = 42;
            lbWorkstationHasFaultInfo.Text = "hasFaultInfo";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(33, 139);
            label18.Name = "label18";
            label18.Size = new Size(141, 25);
            label18.TabIndex = 35;
            label18.Text = "Computer name";
            // 
            // txtWorkstationComputerName
            // 
            txtWorkstationComputerName.BorderStyle = BorderStyle.FixedSingle;
            txtWorkstationComputerName.Location = new Point(42, 167);
            txtWorkstationComputerName.Name = "txtWorkstationComputerName";
            txtWorkstationComputerName.ReadOnly = true;
            txtWorkstationComputerName.Size = new Size(523, 31);
            txtWorkstationComputerName.TabIndex = 33;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(33, 208);
            label19.Name = "label19";
            label19.Size = new Size(91, 25);
            label19.TabIndex = 40;
            label19.Text = "Username";
            // 
            // txtWorkstationUsername
            // 
            txtWorkstationUsername.BorderStyle = BorderStyle.FixedSingle;
            txtWorkstationUsername.Location = new Point(42, 236);
            txtWorkstationUsername.Name = "txtWorkstationUsername";
            txtWorkstationUsername.ReadOnly = true;
            txtWorkstationUsername.Size = new Size(523, 31);
            txtWorkstationUsername.TabIndex = 34;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(33, 287);
            label20.Name = "label20";
            label20.Size = new Size(88, 25);
            label20.TabIndex = 43;
            label20.Text = "Hard disk";
            // 
            // rtxtWorkstationHardDisk
            // 
            rtxtWorkstationHardDisk.BorderStyle = BorderStyle.FixedSingle;
            rtxtWorkstationHardDisk.Location = new Point(42, 315);
            rtxtWorkstationHardDisk.Name = "rtxtWorkstationHardDisk";
            rtxtWorkstationHardDisk.ReadOnly = true;
            rtxtWorkstationHardDisk.Size = new Size(523, 82);
            rtxtWorkstationHardDisk.TabIndex = 36;
            rtxtWorkstationHardDisk.Text = "";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(33, 408);
            label21.Name = "label21";
            label21.Size = new Size(45, 25);
            label21.TabIndex = 44;
            label21.Text = "CPU";
            // 
            // rtxtWorkstationCpu
            // 
            rtxtWorkstationCpu.BorderStyle = BorderStyle.FixedSingle;
            rtxtWorkstationCpu.Location = new Point(42, 436);
            rtxtWorkstationCpu.Name = "rtxtWorkstationCpu";
            rtxtWorkstationCpu.ReadOnly = true;
            rtxtWorkstationCpu.Size = new Size(523, 82);
            rtxtWorkstationCpu.TabIndex = 37;
            rtxtWorkstationCpu.Text = "";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(29, 536);
            label23.Name = "label23";
            label23.Size = new Size(107, 25);
            label23.TabIndex = 46;
            label23.Text = "Bios version";
            // 
            // rtxtWorkstationBiosVersion
            // 
            rtxtWorkstationBiosVersion.BorderStyle = BorderStyle.FixedSingle;
            rtxtWorkstationBiosVersion.Location = new Point(42, 564);
            rtxtWorkstationBiosVersion.Name = "rtxtWorkstationBiosVersion";
            rtxtWorkstationBiosVersion.ReadOnly = true;
            rtxtWorkstationBiosVersion.Size = new Size(523, 82);
            rtxtWorkstationBiosVersion.TabIndex = 39;
            rtxtWorkstationBiosVersion.Text = "";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(29, 663);
            label17.Name = "label17";
            label17.Size = new Size(36, 25);
            label17.TabIndex = 40;
            label17.Text = "OS";
            // 
            // txtWorkstationOs
            // 
            txtWorkstationOs.BorderStyle = BorderStyle.FixedSingle;
            txtWorkstationOs.Location = new Point(38, 691);
            txtWorkstationOs.Name = "txtWorkstationOs";
            txtWorkstationOs.ReadOnly = true;
            txtWorkstationOs.Size = new Size(523, 31);
            txtWorkstationOs.TabIndex = 34;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(29, 739);
            label24.Name = "label24";
            label24.Size = new Size(124, 25);
            label24.TabIndex = 40;
            label24.Text = "OS bit version";
            // 
            // txtWorkstationOsBitVersion
            // 
            txtWorkstationOsBitVersion.BorderStyle = BorderStyle.FixedSingle;
            txtWorkstationOsBitVersion.Location = new Point(38, 767);
            txtWorkstationOsBitVersion.Name = "txtWorkstationOsBitVersion";
            txtWorkstationOsBitVersion.ReadOnly = true;
            txtWorkstationOsBitVersion.Size = new Size(523, 31);
            txtWorkstationOsBitVersion.TabIndex = 34;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSidePanelToggleIsActive);
            groupBox1.Controls.Add(btnSidePanelSave);
            groupBox1.Controls.Add(btnSidePanelEditCancel);
            groupBox1.Location = new Point(675, 1019);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 119);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // btnSidePanelToggleIsActive
            // 
            btnSidePanelToggleIsActive.Location = new Point(38, 34);
            btnSidePanelToggleIsActive.Name = "btnSidePanelToggleIsActive";
            btnSidePanelToggleIsActive.Size = new Size(114, 68);
            btnSidePanelToggleIsActive.TabIndex = 25;
            btnSidePanelToggleIsActive.Text = "Toggle\r\nIsActive";
            btnSidePanelToggleIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSidePanelSave
            // 
            btnSidePanelSave.Location = new Point(292, 34);
            btnSidePanelSave.Name = "btnSidePanelSave";
            btnSidePanelSave.Size = new Size(156, 68);
            btnSidePanelSave.TabIndex = 27;
            btnSidePanelSave.Text = "Save changes";
            btnSidePanelSave.UseVisualStyleBackColor = true;
            // 
            // btnSidePanelEditCancel
            // 
            btnSidePanelEditCancel.Location = new Point(454, 34);
            btnSidePanelEditCancel.Name = "btnSidePanelEditCancel";
            btnSidePanelEditCancel.Size = new Size(107, 68);
            btnSidePanelEditCancel.TabIndex = 28;
            btnSidePanelEditCancel.Text = "Cancel";
            btnSidePanelEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnCompanyShowWorkstations
            // 
            btnCompanyShowWorkstations.Location = new Point(765, 1019);
            btnCompanyShowWorkstations.Name = "btnCompanyShowWorkstations";
            btnCompanyShowWorkstations.Size = new Size(185, 68);
            btnCompanyShowWorkstations.TabIndex = 16;
            btnCompanyShowWorkstations.Text = "Show workstations";
            btnCompanyShowWorkstations.UseVisualStyleBackColor = true;
            // 
            // ClientManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ClientManagementUC";
            Size = new Size(1407, 1156);
            ((System.ComponentModel.ISupportInitialize)dgvCompanyData).EndInit();
            tabControlSidePanelLeft.ResumeLayout(false);
            tpCompanyDetails.ResumeLayout(false);
            tpCompanyDetails.PerformLayout();
            tpSidePanelData.ResumeLayout(false);
            tpSidePanelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSidePanelData).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControlSidePanelRight.ResumeLayout(false);
            tpSidePanelEmployeeDetails.ResumeLayout(false);
            tpSidePanelEmployeeDetails.PerformLayout();
            tpSidePanelWorkstationDetails.ResumeLayout(false);
            tpSidePanelWorkstationDetails.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCompanyData;
        private Label label1;
        private TextBox txtCompanySearchValue;
        private ComboBox cbCompanySelectedFilter;
        private Button btnCompanySearch;
        private TabControl tabControlSidePanelLeft;
        private TabPage tpCompanyDetails;
        private SplitContainer splitContainer1;
        private Button button1;
        private Button btnCloseSidePanel;
        private Button button3;
        private Button btnCompanyAdd;
        private Button btnCompanyEdit;
        private Button btnCompanyToggleIsActive;
        private CheckBox chbCompanySearchOnlyActive;
        private Button btnCompanyShowDetails;
        private Label label3;
        private TextBox txtCompanyNip;
        private Label label2;
        private RichTextBox rtxtCompanyLocalizations;
        private TextBox txtCompanyName;
        private Label label4;
        private Label lbCompanyIsActiveInfo;
        private Label label6;
        private RichTextBox rtxtCompanyDescription;
        private Label label5;
        private RichTextBox rtxtCompanyWebsites;
        private Button btnCompanyEditCancel;
        private Button btnCompanySave;
        private Button btnCompanyShowEmployees;
        private DataGridView dgvSidePanelData;
        private Button btnSidePanelAdd;
        private Button btnSidePanelShowDetails;
        private Button btnSidePanelEdit;
        private Label lbSidePanelLeftTabTitle;
        private TabControl tabControlSidePanelRight;
        private TabPage tpSidePanelEmployeeDetails;
        private TabPage tpSidePanelWorkstationDetails;
        private TabPage tpSidePanelData;
        private Label label9;
        private CheckBox chbSidePanelSearchOnlyActive;
        private Button btnSidePanelSearch;
        private ComboBox cbSidePanelSelectedFilter;
        private TextBox txtSidePanelSearchValue;
        private Label label7;
        private Label lbEmployeeIsActiveInfo;
        private Label label10;
        private TextBox txtEmployeeName;
        private Label label11;
        private TextBox txtEmployeeProfession;
        private Label label12;
        private RichTextBox rtxtEmployeePhoneNumbers;
        private Label label13;
        private RichTextBox rtxtEmployeeIPs;
        private Label label14;
        private RichTextBox rtxtEmployeeDescription;
        private Button btnSidePanelToggleIsActive;
        private Button btnSidePanelSave;
        private Button btnSidePanelEditCancel;
        private Label label15;
        private RichTextBox rtxtEmployeeEmails;
        private Label label8;
        private RichTextBox rtxtEmployeeWebsites;
        private GroupBox groupBox1;
        private Label label16;
        private Label lbWorkstationHasFaultInfo;
        private Label label18;
        private TextBox txtWorkstationComputerName;
        private RichTextBox rtxtWorkstationBiosVersion;
        private Label label19;
        private Label label23;
        private TextBox txtWorkstationUsername;
        private Label label20;
        private RichTextBox rtxtWorkstationHardDisk;
        private RichTextBox rtxtWorkstationCpu;
        private Label label21;
        private Label label17;
        private TextBox txtWorkstationOs;
        private Label label24;
        private TextBox txtWorkstationOsBitVersion;
        private Button btnCompanyShowWorkstations;
    }
}
