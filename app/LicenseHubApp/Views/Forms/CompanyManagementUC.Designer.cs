namespace LicenseHubApp.Views.Forms
{
    partial class CompanyManagementUC
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtSearchValue = new TextBox();
            cbSelectedFilter = new ComboBox();
            btnSearch = new Button();
            tabContainer1 = new TabControl();
            tabPageClientDetails = new TabPage();
            btnEditCancel = new Button();
            label6 = new Label();
            rtxtDescription = new RichTextBox();
            label5 = new Label();
            btnToggleIsActive = new Button();
            btnSave = new Button();
            rtxtWebsites = new RichTextBox();
            label4 = new Label();
            lbIsActiveInfo = new Label();
            label3 = new Label();
            txtNip = new TextBox();
            label2 = new Label();
            rtxtLocalizations = new RichTextBox();
            txtCompanyName = new TextBox();
            splitContainer1 = new SplitContainer();
            btnShowDetails = new Button();
            chbSearchOnlyActiveCompanies = new CheckBox();
            btnAdd = new Button();
            btnEdit = new Button();
            button3 = new Button();
            button1 = new Button();
            btnCloseRightPanel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabContainer1.SuspendLayout();
            tabPageClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1164, 852);
            dataGridView1.TabIndex = 0;
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
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(210, 120);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(258, 31);
            txtSearchValue.TabIndex = 2;
            // 
            // cbSelectedFilter
            // 
            cbSelectedFilter.FormattingEnabled = true;
            cbSelectedFilter.Location = new Point(474, 122);
            cbSelectedFilter.Name = "cbSelectedFilter";
            cbSelectedFilter.Size = new Size(182, 33);
            cbSelectedFilter.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(662, 120);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tabContainer1
            // 
            tabContainer1.Controls.Add(tabPageClientDetails);
            tabContainer1.Location = new Point(25, 120);
            tabContainer1.Name = "tabContainer1";
            tabContainer1.SelectedIndex = 0;
            tabContainer1.Size = new Size(594, 967);
            tabContainer1.TabIndex = 5;
            // 
            // tabPageClientDetails
            // 
            tabPageClientDetails.BackColor = Color.WhiteSmoke;
            tabPageClientDetails.Controls.Add(btnEditCancel);
            tabPageClientDetails.Controls.Add(label6);
            tabPageClientDetails.Controls.Add(rtxtDescription);
            tabPageClientDetails.Controls.Add(label5);
            tabPageClientDetails.Controls.Add(btnToggleIsActive);
            tabPageClientDetails.Controls.Add(btnSave);
            tabPageClientDetails.Controls.Add(rtxtWebsites);
            tabPageClientDetails.Controls.Add(label4);
            tabPageClientDetails.Controls.Add(lbIsActiveInfo);
            tabPageClientDetails.Controls.Add(label3);
            tabPageClientDetails.Controls.Add(txtNip);
            tabPageClientDetails.Controls.Add(label2);
            tabPageClientDetails.Controls.Add(rtxtLocalizations);
            tabPageClientDetails.Controls.Add(txtCompanyName);
            tabPageClientDetails.Location = new Point(4, 34);
            tabPageClientDetails.Name = "tabPageClientDetails";
            tabPageClientDetails.Padding = new Padding(3);
            tabPageClientDetails.Size = new Size(586, 929);
            tabPageClientDetails.TabIndex = 0;
            tabPageClientDetails.Text = "ClientDetails";
            // 
            // btnEditCancel
            // 
            btnEditCancel.Location = new Point(442, 714);
            btnEditCancel.Name = "btnEditCancel";
            btnEditCancel.Size = new Size(107, 68);
            btnEditCancel.TabIndex = 26;
            btnEditCancel.Text = "Cancel";
            btnEditCancel.UseVisualStyleBackColor = true;
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
            // rtxtDescription
            // 
            rtxtDescription.BorderStyle = BorderStyle.FixedSingle;
            rtxtDescription.Location = new Point(26, 552);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.ReadOnly = true;
            rtxtDescription.Size = new Size(523, 145);
            rtxtDescription.TabIndex = 9;
            rtxtDescription.Text = "";
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
            // btnToggleIsActive
            // 
            btnToggleIsActive.Location = new Point(26, 714);
            btnToggleIsActive.Name = "btnToggleIsActive";
            btnToggleIsActive.Size = new Size(114, 68);
            btnToggleIsActive.TabIndex = 11;
            btnToggleIsActive.Text = "Toggle\r\nIsActive";
            btnToggleIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(280, 714);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 68);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // rtxtWebsites
            // 
            rtxtWebsites.BorderStyle = BorderStyle.FixedSingle;
            rtxtWebsites.Location = new Point(26, 426);
            rtxtWebsites.Name = "rtxtWebsites";
            rtxtWebsites.ReadOnly = true;
            rtxtWebsites.Size = new Size(523, 82);
            rtxtWebsites.TabIndex = 7;
            rtxtWebsites.Text = "";
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
            // lbIsActiveInfo
            // 
            lbIsActiveInfo.AutoSize = true;
            lbIsActiveInfo.ForeColor = SystemColors.ControlDark;
            lbIsActiveInfo.Location = new Point(17, 99);
            lbIsActiveInfo.Name = "lbIsActiveInfo";
            lbIsActiveInfo.Size = new Size(104, 25);
            lbIsActiveInfo.TabIndex = 5;
            lbIsActiveInfo.Text = "isActiveInfo";
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
            // txtNip
            // 
            txtNip.BorderStyle = BorderStyle.FixedSingle;
            txtNip.Location = new Point(26, 221);
            txtNip.Name = "txtNip";
            txtNip.ReadOnly = true;
            txtNip.Size = new Size(523, 31);
            txtNip.TabIndex = 3;
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
            // rtxtLocalizations
            // 
            rtxtLocalizations.BorderStyle = BorderStyle.FixedSingle;
            rtxtLocalizations.Location = new Point(26, 300);
            rtxtLocalizations.Name = "rtxtLocalizations";
            rtxtLocalizations.ReadOnly = true;
            rtxtLocalizations.Size = new Size(523, 82);
            rtxtLocalizations.TabIndex = 1;
            rtxtLocalizations.Text = "";
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnShowDetails);
            splitContainer1.Panel1.Controls.Add(chbSearchOnlyActiveCompanies);
            splitContainer1.Panel1.Controls.Add(btnAdd);
            splitContainer1.Panel1.Controls.Add(btnEdit);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(btnSearch);
            splitContainer1.Panel1.Controls.Add(cbSelectedFilter);
            splitContainer1.Panel1.Controls.Add(txtSearchValue);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel2.Controls.Add(tabContainer1);
            splitContainer1.Panel2.Controls.Add(btnCloseRightPanel);
            splitContainer1.Size = new Size(1407, 1156);
            splitContainer1.SplitterDistance = 747;
            splitContainer1.TabIndex = 6;
            // 
            // btnShowDetails
            // 
            btnShowDetails.Location = new Point(46, 1019);
            btnShowDetails.Name = "btnShowDetails";
            btnShowDetails.Size = new Size(225, 68);
            btnShowDetails.TabIndex = 14;
            btnShowDetails.Text = "Show company details ";
            btnShowDetails.UseVisualStyleBackColor = true;
            // 
            // chbSearchOnlyActiveCompanies
            // 
            chbSearchOnlyActiveCompanies.AutoSize = true;
            chbSearchOnlyActiveCompanies.Location = new Point(210, 85);
            chbSearchOnlyActiveCompanies.Name = "chbSearchOnlyActiveCompanies";
            chbSearchOnlyActiveCompanies.Size = new Size(222, 29);
            chbSearchOnlyActiveCompanies.TabIndex = 13;
            chbSearchOnlyActiveCompanies.Text = "Only Active Companies";
            chbSearchOnlyActiveCompanies.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(439, 1019);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 68);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add new company";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(277, 1019);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(156, 68);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit company";
            btnEdit.UseVisualStyleBackColor = true;
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
            // btnCloseRightPanel
            // 
            btnCloseRightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseRightPanel.Location = new Point(557, 0);
            btnCloseRightPanel.Name = "btnCloseRightPanel";
            btnCloseRightPanel.Size = new Size(56, 34);
            btnCloseRightPanel.TabIndex = 6;
            btnCloseRightPanel.Text = "X";
            btnCloseRightPanel.UseVisualStyleBackColor = true;
            btnCloseRightPanel.Click += button2_Click;
            // 
            // CompanyManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CompanyManagementUC";
            Size = new Size(1407, 1156);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabContainer1.ResumeLayout(false);
            tabPageClientDetails.ResumeLayout(false);
            tabPageClientDetails.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtSearchValue;
        private ComboBox cbSelectedFilter;
        private Button btnSearch;
        private TabControl tabContainer1;
        private TabPage tabPageClientDetails;
        private SplitContainer splitContainer1;
        private Button button1;
        private Button btnCloseRightPanel;
        private Button button3;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnToggleIsActive;
        private CheckBox chbSearchOnlyActiveCompanies;
        private Button btnShowDetails;
        private Label label3;
        private TextBox txtNip;
        private Label label2;
        private RichTextBox rtxtLocalizations;
        private TextBox txtCompanyName;
        private Label label4;
        private Label lbIsActiveInfo;
        private Label label6;
        private RichTextBox rtxtDescription;
        private Label label5;
        private RichTextBox rtxtWebsites;
        private Button btnEditCancel;
        private Button btnSave;
    }
}
