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
            tabControlLeftSide = new TabControl();
            tabPageCompanyDetails = new TabPage();
            label9 = new Label();
            btnCompanyEditCancel = new Button();
            label6 = new Label();
            rtxtCompanyDescription = new RichTextBox();
            label5 = new Label();
            btnCompanyToggleIsActive = new Button();
            btnCompanySave = new Button();
            rtxtCompanyWebsites = new RichTextBox();
            label4 = new Label();
            lbCompanyIsActiveInfo = new Label();
            label3 = new Label();
            txtCompanyNip = new TextBox();
            label2 = new Label();
            rtxtCompanyLocalizations = new RichTextBox();
            txtCompanyName = new TextBox();
            tabPageEmployeeData = new TabPage();
            dgvEmployeeData = new DataGridView();
            btnEmployeeEdit = new Button();
            label7 = new Label();
            btnEmployeeAdd = new Button();
            btnEmployeeShowDetails = new Button();
            tabPageWorkstationData = new TabPage();
            label8 = new Label();
            splitContainer1 = new SplitContainer();
            btnCompanyEditEmployees = new Button();
            btnCompanyShowDetails = new Button();
            chbCompanySearchOnlyActive = new CheckBox();
            btnCompanyAdd = new Button();
            btnCompanyEditDetails = new Button();
            button3 = new Button();
            button1 = new Button();
            tabControlRightSide = new TabControl();
            tabPageEmployeeDetails = new TabPage();
            tabPageWorkstationDetails = new TabPage();
            btnCloseRightPanel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompanyData).BeginInit();
            tabControlLeftSide.SuspendLayout();
            tabPageCompanyDetails.SuspendLayout();
            tabPageEmployeeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeData).BeginInit();
            tabPageWorkstationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControlRightSide.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCompanyData
            // 
            dgvCompanyData.AllowUserToAddRows = false;
            dgvCompanyData.AllowUserToDeleteRows = false;
            dgvCompanyData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompanyData.Location = new Point(46, 161);
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
            // tabControlLeftSide
            // 
            tabControlLeftSide.Controls.Add(tabPageCompanyDetails);
            tabControlLeftSide.Controls.Add(tabPageEmployeeData);
            tabControlLeftSide.Controls.Add(tabPageWorkstationData);
            tabControlLeftSide.Location = new Point(33, 55);
            tabControlLeftSide.Name = "tabControlLeftSide";
            tabControlLeftSide.SelectedIndex = 0;
            tabControlLeftSide.Size = new Size(594, 1066);
            tabControlLeftSide.TabIndex = 5;
            // 
            // tabPageCompanyDetails
            // 
            tabPageCompanyDetails.BackColor = Color.WhiteSmoke;
            tabPageCompanyDetails.Controls.Add(label9);
            tabPageCompanyDetails.Controls.Add(btnCompanyEditCancel);
            tabPageCompanyDetails.Controls.Add(label6);
            tabPageCompanyDetails.Controls.Add(rtxtCompanyDescription);
            tabPageCompanyDetails.Controls.Add(label5);
            tabPageCompanyDetails.Controls.Add(btnCompanyToggleIsActive);
            tabPageCompanyDetails.Controls.Add(btnCompanySave);
            tabPageCompanyDetails.Controls.Add(rtxtCompanyWebsites);
            tabPageCompanyDetails.Controls.Add(label4);
            tabPageCompanyDetails.Controls.Add(lbCompanyIsActiveInfo);
            tabPageCompanyDetails.Controls.Add(label3);
            tabPageCompanyDetails.Controls.Add(txtCompanyNip);
            tabPageCompanyDetails.Controls.Add(label2);
            tabPageCompanyDetails.Controls.Add(rtxtCompanyLocalizations);
            tabPageCompanyDetails.Controls.Add(txtCompanyName);
            tabPageCompanyDetails.Location = new Point(4, 34);
            tabPageCompanyDetails.Name = "tabPageCompanyDetails";
            tabPageCompanyDetails.Padding = new Padding(3);
            tabPageCompanyDetails.Size = new Size(586, 1028);
            tabPageCompanyDetails.TabIndex = 0;
            tabPageCompanyDetails.Text = "Client details";
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
            // btnCompanyEditCancel
            // 
            btnCompanyEditCancel.Location = new Point(442, 714);
            btnCompanyEditCancel.Name = "btnCompanyEditCancel";
            btnCompanyEditCancel.Size = new Size(107, 68);
            btnCompanyEditCancel.TabIndex = 7;
            btnCompanyEditCancel.Text = "Cancel";
            btnCompanyEditCancel.UseVisualStyleBackColor = true;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 398);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 8;
            label5.Text = "Websites";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 272);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 6;
            label4.Text = "Localizations";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 124);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 2;
            label2.Text = "Company Name";
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
            // txtCompanyName
            // 
            txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
            txtCompanyName.Location = new Point(26, 152);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.ReadOnly = true;
            txtCompanyName.Size = new Size(523, 31);
            txtCompanyName.TabIndex = 0;
            // 
            // tabPageEmployeeData
            // 
            tabPageEmployeeData.BackColor = Color.WhiteSmoke;
            tabPageEmployeeData.Controls.Add(dgvEmployeeData);
            tabPageEmployeeData.Controls.Add(btnEmployeeEdit);
            tabPageEmployeeData.Controls.Add(label7);
            tabPageEmployeeData.Controls.Add(btnEmployeeAdd);
            tabPageEmployeeData.Controls.Add(btnEmployeeShowDetails);
            tabPageEmployeeData.Location = new Point(4, 34);
            tabPageEmployeeData.Name = "tabPageEmployeeData";
            tabPageEmployeeData.Padding = new Padding(3);
            tabPageEmployeeData.Size = new Size(586, 1028);
            tabPageEmployeeData.TabIndex = 1;
            tabPageEmployeeData.Text = "Employees";
            // 
            // dgvEmployeeData
            // 
            dgvEmployeeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeData.Location = new Point(6, 72);
            dgvEmployeeData.Name = "dgvEmployeeData";
            dgvEmployeeData.RowHeadersWidth = 62;
            dgvEmployeeData.Size = new Size(574, 852);
            dgvEmployeeData.TabIndex = 7;
            // 
            // btnEmployeeEdit
            // 
            btnEmployeeEdit.Location = new Point(329, 930);
            btnEmployeeEdit.Name = "btnEmployeeEdit";
            btnEmployeeEdit.Size = new Size(156, 68);
            btnEmployeeEdit.TabIndex = 17;
            btnEmployeeEdit.Text = "Edit";
            btnEmployeeEdit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(6, 18);
            label7.Name = "label7";
            label7.Size = new Size(173, 45);
            label7.TabIndex = 16;
            label7.Text = "Employees";
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.Location = new Point(167, 930);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Size = new Size(156, 68);
            btnEmployeeAdd.TabIndex = 16;
            btnEmployeeAdd.Text = "Add new";
            btnEmployeeAdd.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeShowDetails
            // 
            btnEmployeeShowDetails.Location = new Point(6, 930);
            btnEmployeeShowDetails.Name = "btnEmployeeShowDetails";
            btnEmployeeShowDetails.Size = new Size(156, 68);
            btnEmployeeShowDetails.TabIndex = 16;
            btnEmployeeShowDetails.Text = "Show details ";
            btnEmployeeShowDetails.UseVisualStyleBackColor = true;
            // 
            // tabPageWorkstationData
            // 
            tabPageWorkstationData.BackColor = Color.WhiteSmoke;
            tabPageWorkstationData.Controls.Add(label8);
            tabPageWorkstationData.Location = new Point(4, 34);
            tabPageWorkstationData.Name = "tabPageWorkstationData";
            tabPageWorkstationData.Padding = new Padding(3);
            tabPageWorkstationData.Size = new Size(586, 1028);
            tabPageWorkstationData.TabIndex = 2;
            tabPageWorkstationData.Text = "Workstations";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(6, 7);
            label8.Name = "label8";
            label8.Size = new Size(206, 45);
            label8.TabIndex = 19;
            label8.Text = "Workstations";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCompanyEditEmployees);
            splitContainer1.Panel1.Controls.Add(btnCompanyShowDetails);
            splitContainer1.Panel1.Controls.Add(chbCompanySearchOnlyActive);
            splitContainer1.Panel1.Controls.Add(btnCompanyAdd);
            splitContainer1.Panel1.Controls.Add(btnCompanyEditDetails);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(btnCompanySearch);
            splitContainer1.Panel1.Controls.Add(cbCompanySelectedFilter);
            splitContainer1.Panel1.Controls.Add(txtCompanySearchValue);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(dgvCompanyData);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel2.Controls.Add(btnCloseRightPanel);
            splitContainer1.Panel2.Controls.Add(tabControlLeftSide);
            splitContainer1.Panel2.Controls.Add(tabControlRightSide);
            splitContainer1.Size = new Size(1407, 1156);
            splitContainer1.SplitterDistance = 763;
            splitContainer1.TabIndex = 6;
            // 
            // btnCompanyEditEmployees
            // 
            btnCompanyEditEmployees.Location = new Point(603, 1019);
            btnCompanyEditEmployees.Name = "btnCompanyEditEmployees";
            btnCompanyEditEmployees.Size = new Size(156, 68);
            btnCompanyEditEmployees.TabIndex = 15;
            btnCompanyEditEmployees.Text = "Edit employees";
            btnCompanyEditEmployees.UseVisualStyleBackColor = true;
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
            // btnCompanyAdd
            // 
            btnCompanyAdd.Location = new Point(279, 1019);
            btnCompanyAdd.Name = "btnCompanyAdd";
            btnCompanyAdd.Size = new Size(156, 68);
            btnCompanyAdd.TabIndex = 10;
            btnCompanyAdd.Text = "Add new";
            btnCompanyAdd.UseVisualStyleBackColor = true;
            // 
            // btnCompanyEditDetails
            // 
            btnCompanyEditDetails.Location = new Point(441, 1019);
            btnCompanyEditDetails.Name = "btnCompanyEditDetails";
            btnCompanyEditDetails.Size = new Size(156, 68);
            btnCompanyEditDetails.TabIndex = 12;
            btnCompanyEditDetails.Text = "Edit details";
            btnCompanyEditDetails.UseVisualStyleBackColor = true;
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
            // tabControlRightSide
            // 
            tabControlRightSide.Controls.Add(tabPageEmployeeDetails);
            tabControlRightSide.Controls.Add(tabPageWorkstationDetails);
            tabControlRightSide.Location = new Point(707, 122);
            tabControlRightSide.Name = "tabControlRightSide";
            tabControlRightSide.SelectedIndex = 0;
            tabControlRightSide.Size = new Size(592, 891);
            tabControlRightSide.TabIndex = 18;
            // 
            // tabPageEmployeeDetails
            // 
            tabPageEmployeeDetails.BackColor = Color.WhiteSmoke;
            tabPageEmployeeDetails.Location = new Point(4, 34);
            tabPageEmployeeDetails.Name = "tabPageEmployeeDetails";
            tabPageEmployeeDetails.Padding = new Padding(3);
            tabPageEmployeeDetails.Size = new Size(584, 853);
            tabPageEmployeeDetails.TabIndex = 0;
            tabPageEmployeeDetails.Text = "Employee details";
            // 
            // tabPageWorkstationDetails
            // 
            tabPageWorkstationDetails.BackColor = Color.WhiteSmoke;
            tabPageWorkstationDetails.Location = new Point(4, 34);
            tabPageWorkstationDetails.Name = "tabPageWorkstationDetails";
            tabPageWorkstationDetails.Padding = new Padding(3);
            tabPageWorkstationDetails.Size = new Size(584, 853);
            tabPageWorkstationDetails.TabIndex = 1;
            tabPageWorkstationDetails.Text = "Workstation details";
            // 
            // btnCloseRightPanel
            // 
            btnCloseRightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseRightPanel.Location = new Point(541, 0);
            btnCloseRightPanel.Name = "btnCloseRightPanel";
            btnCloseRightPanel.Size = new Size(56, 34);
            btnCloseRightPanel.TabIndex = 6;
            btnCloseRightPanel.Text = "X";
            btnCloseRightPanel.UseVisualStyleBackColor = true;
            btnCloseRightPanel.Click += button2_Click;
            // 
            // ClientManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ClientManagementUC";
            Size = new Size(1407, 1156);
            ((System.ComponentModel.ISupportInitialize)dgvCompanyData).EndInit();
            tabControlLeftSide.ResumeLayout(false);
            tabPageCompanyDetails.ResumeLayout(false);
            tabPageCompanyDetails.PerformLayout();
            tabPageEmployeeData.ResumeLayout(false);
            tabPageEmployeeData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeData).EndInit();
            tabPageWorkstationData.ResumeLayout(false);
            tabPageWorkstationData.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControlRightSide.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCompanyData;
        private Label label1;
        private TextBox txtCompanySearchValue;
        private ComboBox cbCompanySelectedFilter;
        private Button btnCompanySearch;
        private TabControl tabControlLeftSide;
        private TabPage tabPageCompanyDetails;
        private SplitContainer splitContainer1;
        private Button button1;
        private Button btnCloseRightPanel;
        private Button button3;
        private Button btnCompanyAdd;
        private Button btnCompanyEditDetails;
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
        private Button btnCompanyEditEmployees;
        private DataGridView dgvEmployeeData;
        private Button btnEmployeeAdd;
        private Button btnEmployeeShowDetails;
        private Button btnEmployeeEdit;
        private Label label7;
        private TabControl tabControlRightSide;
        private TabPage tabPageEmployeeDetails;
        private TabPage tabPageWorkstationDetails;
        private TabPage tabPageEmployeeData;
        private TabPage tabPageWorkstationData;
        private Label label8;
        private Label label9;
    }
}
