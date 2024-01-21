namespace LicenseHubApp.Views.Forms
{
    partial class WorkstationProductDetailView
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
            label16 = new Label();
            groupBox1 = new GroupBox();
            lstEmployees = new ListBox();
            lblNumberOfUsers = new Label();
            label20 = new Label();
            label4 = new Label();
            lblOrderDateOfOrder = new Label();
            lblOrderContractNumber = new Label();
            label21 = new Label();
            label2 = new Label();
            lblCompanyName = new Label();
            label1 = new Label();
            btnCloseDetailView = new Button();
            groupBox2 = new GroupBox();
            rtxProductDescription = new RichTextBox();
            txtProductName = new TextBox();
            groupBox3 = new GroupBox();
            rtxReleaseDescription = new RichTextBox();
            txtReleaseNumber = new TextBox();
            txtReleaseInstallerVerificationPasscode = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label10 = new Label();
            txtProductNewestRelease = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            dtpLicenseRegisterDate = new DateTimePicker();
            cdrLicenseEndOfLicense = new MonthCalendar();
            cdrLicenseActivationDate = new MonthCalendar();
            txtLicenseActivationCodeGenVersion = new TextBox();
            txtLicenseLeaseInDays = new TextBox();
            label19 = new Label();
            label18 = new Label();
            txtLicenseActivationCode = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label17 = new Label();
            label13 = new Label();
            txtLicenseType = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 16F);
            label16.Location = new Point(57, 79);
            label16.Name = "label16";
            label16.Size = new Size(437, 45);
            label16.TabIndex = 64;
            label16.Text = "Selected workstation product";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstEmployees);
            groupBox1.Controls.Add(lblNumberOfUsers);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblOrderDateOfOrder);
            groupBox1.Controls.Add(lblOrderContractNumber);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblCompanyName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(57, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1278, 221);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product on workstation";
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 25;
            lstEmployees.Location = new Point(940, 76);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(309, 129);
            lstEmployees.TabIndex = 66;
            // 
            // lblNumberOfUsers
            // 
            lblNumberOfUsers.AutoSize = true;
            lblNumberOfUsers.Location = new Point(337, 170);
            lblNumberOfUsers.Name = "lblNumberOfUsers";
            lblNumberOfUsers.Size = new Size(140, 25);
            lblNumberOfUsers.TabIndex = 64;
            lblNumberOfUsers.Text = "NumberOfUsers";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(931, 48);
            label20.Name = "label20";
            label20.Size = new Size(203, 25);
            label20.TabIndex = 65;
            label20.Text = "Employees that use this:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 170);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 65;
            label4.Text = "Number of users:";
            // 
            // lblOrderDateOfOrder
            // 
            lblOrderDateOfOrder.AutoSize = true;
            lblOrderDateOfOrder.Location = new Point(337, 136);
            lblOrderDateOfOrder.Name = "lblOrderDateOfOrder";
            lblOrderDateOfOrder.Size = new Size(161, 25);
            lblOrderDateOfOrder.TabIndex = 64;
            lblOrderDateOfOrder.Text = "OrderDateOfOrder";
            // 
            // lblOrderContractNumber
            // 
            lblOrderContractNumber.AutoSize = true;
            lblOrderContractNumber.Location = new Point(337, 101);
            lblOrderContractNumber.Name = "lblOrderContractNumber";
            lblOrderContractNumber.Size = new Size(190, 25);
            lblOrderContractNumber.TabIndex = 64;
            lblOrderContractNumber.Text = "OrderContractNumber";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(80, 136);
            label21.Name = "label21";
            label21.Size = new Size(123, 25);
            label21.TabIndex = 65;
            label21.Text = "Date of order:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 101);
            label2.Name = "label2";
            label2.Size = new Size(240, 25);
            label2.TabIndex = 65;
            label2.Text = "The order's contract number:";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(497, 48);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(136, 25);
            lblCompanyName.TabIndex = 64;
            lblCompanyName.Text = "CompanyName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 48);
            label1.Name = "label1";
            label1.Size = new Size(392, 25);
            label1.TabIndex = 65;
            label1.Text = "The company to which the workstation belongs:";
            // 
            // btnCloseDetailView
            // 
            btnCloseDetailView.Location = new Point(1279, 0);
            btnCloseDetailView.Name = "btnCloseDetailView";
            btnCloseDetailView.Size = new Size(56, 34);
            btnCloseDetailView.TabIndex = 67;
            btnCloseDetailView.Text = "X";
            btnCloseDetailView.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtxProductDescription);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(txtProductNewestRelease);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(57, 369);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1278, 272);
            groupBox2.TabIndex = 65;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product details";
            // 
            // rtxProductDescription
            // 
            rtxProductDescription.Location = new Point(203, 139);
            rtxProductDescription.Name = "rtxProductDescription";
            rtxProductDescription.ReadOnly = true;
            rtxProductDescription.Size = new Size(362, 91);
            rtxProductDescription.TabIndex = 67;
            rtxProductDescription.Text = "";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(203, 65);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(362, 31);
            txtProductName.TabIndex = 66;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rtxReleaseDescription);
            groupBox3.Controls.Add(txtReleaseNumber);
            groupBox3.Controls.Add(txtReleaseInstallerVerificationPasscode);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(614, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(658, 218);
            groupBox3.TabIndex = 65;
            groupBox3.TabStop = false;
            groupBox3.Text = "Release details";
            // 
            // rtxReleaseDescription
            // 
            rtxReleaseDescription.Location = new Point(274, 120);
            rtxReleaseDescription.Name = "rtxReleaseDescription";
            rtxReleaseDescription.ReadOnly = true;
            rtxReleaseDescription.Size = new Size(361, 80);
            rtxReleaseDescription.TabIndex = 67;
            rtxReleaseDescription.Text = "";
            // 
            // txtReleaseNumber
            // 
            txtReleaseNumber.Location = new Point(274, 46);
            txtReleaseNumber.Name = "txtReleaseNumber";
            txtReleaseNumber.ReadOnly = true;
            txtReleaseNumber.Size = new Size(361, 31);
            txtReleaseNumber.TabIndex = 66;
            // 
            // txtReleaseInstallerVerificationPasscode
            // 
            txtReleaseInstallerVerificationPasscode.Location = new Point(274, 83);
            txtReleaseInstallerVerificationPasscode.Name = "txtReleaseInstallerVerificationPasscode";
            txtReleaseInstallerVerificationPasscode.ReadOnly = true;
            txtReleaseInstallerVerificationPasscode.Size = new Size(361, 31);
            txtReleaseInstallerVerificationPasscode.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 123);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 65;
            label6.Text = "Description:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 49);
            label8.Name = "label8";
            label8.Size = new Size(141, 25);
            label8.TabIndex = 65;
            label8.Text = "Release number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 86);
            label10.Name = "label10";
            label10.Size = new Size(248, 25);
            label10.TabIndex = 65;
            label10.Text = "Installer verification passcode:";
            // 
            // txtProductNewestRelease
            // 
            txtProductNewestRelease.Location = new Point(203, 102);
            txtProductNewestRelease.Name = "txtProductNewestRelease";
            txtProductNewestRelease.ReadOnly = true;
            txtProductNewestRelease.Size = new Size(362, 31);
            txtProductNewestRelease.TabIndex = 66;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 139);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 65;
            label7.Text = "Description:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 65);
            label9.Name = "label9";
            label9.Size = new Size(127, 25);
            label9.TabIndex = 65;
            label9.Text = "Product name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 102);
            label11.Name = "label11";
            label11.Size = new Size(163, 25);
            label11.TabIndex = 65;
            label11.Text = "The newest release:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtpLicenseRegisterDate);
            groupBox4.Controls.Add(cdrLicenseEndOfLicense);
            groupBox4.Controls.Add(cdrLicenseActivationDate);
            groupBox4.Controls.Add(txtLicenseActivationCodeGenVersion);
            groupBox4.Controls.Add(txtLicenseLeaseInDays);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(txtLicenseActivationCode);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtLicenseType);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(57, 647);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1278, 491);
            groupBox4.TabIndex = 68;
            groupBox4.TabStop = false;
            groupBox4.Text = "License";
            // 
            // dtpLicenseRegisterDate
            // 
            dtpLicenseRegisterDate.Enabled = false;
            dtpLicenseRegisterDate.Location = new Point(160, 80);
            dtpLicenseRegisterDate.Name = "dtpLicenseRegisterDate";
            dtpLicenseRegisterDate.Size = new Size(362, 31);
            dtpLicenseRegisterDate.TabIndex = 67;
            // 
            // cdrLicenseEndOfLicense
            // 
            cdrLicenseEndOfLicense.Location = new Point(674, 213);
            cdrLicenseEndOfLicense.Name = "cdrLicenseEndOfLicense";
            cdrLicenseEndOfLicense.ShowToday = false;
            cdrLicenseEndOfLicense.TabIndex = 1;
            // 
            // cdrLicenseActivationDate
            // 
            cdrLicenseActivationDate.Location = new Point(263, 213);
            cdrLicenseActivationDate.Name = "cdrLicenseActivationDate";
            cdrLicenseActivationDate.ShowToday = false;
            cdrLicenseActivationDate.TabIndex = 1;
            // 
            // txtLicenseActivationCodeGenVersion
            // 
            txtLicenseActivationCodeGenVersion.Location = new Point(781, 83);
            txtLicenseActivationCodeGenVersion.Name = "txtLicenseActivationCodeGenVersion";
            txtLicenseActivationCodeGenVersion.ReadOnly = true;
            txtLicenseActivationCodeGenVersion.Size = new Size(362, 31);
            txtLicenseActivationCodeGenVersion.TabIndex = 66;
            // 
            // txtLicenseLeaseInDays
            // 
            txtLicenseLeaseInDays.Location = new Point(203, 117);
            txtLicenseLeaseInDays.Name = "txtLicenseLeaseInDays";
            txtLicenseLeaseInDays.ReadOnly = true;
            txtLicenseLeaseInDays.Size = new Size(319, 31);
            txtLicenseLeaseInDays.TabIndex = 66;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(674, 179);
            label19.Name = "label19";
            label19.Size = new Size(182, 25);
            label19.TabIndex = 65;
            label19.Text = "End of license period:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(26, 117);
            label18.Name = "label18";
            label18.Size = new Size(153, 25);
            label18.TabIndex = 65;
            label18.Text = "Lease term (days):";
            // 
            // txtLicenseActivationCode
            // 
            txtLicenseActivationCode.Location = new Point(781, 46);
            txtLicenseActivationCode.Name = "txtLicenseActivationCode";
            txtLicenseActivationCode.ReadOnly = true;
            txtLicenseActivationCode.Size = new Size(362, 31);
            txtLicenseActivationCode.TabIndex = 66;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(263, 179);
            label15.Name = "label15";
            label15.Size = new Size(135, 25);
            label15.TabIndex = 65;
            label15.Text = "Activation date:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(26, 85);
            label14.Name = "label14";
            label14.Size = new Size(119, 25);
            label14.TabIndex = 65;
            label14.Text = "Register date:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(635, 86);
            label17.Name = "label17";
            label17.Size = new Size(108, 25);
            label17.TabIndex = 65;
            label17.Text = "gen version:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(604, 46);
            label13.Name = "label13";
            label13.Size = new Size(139, 25);
            label13.TabIndex = 65;
            label13.Text = "Activation code:";
            // 
            // txtLicenseType
            // 
            txtLicenseType.Location = new Point(160, 43);
            txtLicenseType.Name = "txtLicenseType";
            txtLicenseType.ReadOnly = true;
            txtLicenseType.Size = new Size(362, 31);
            txtLicenseType.TabIndex = 66;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 46);
            label12.Name = "label12";
            label12.Size = new Size(112, 25);
            label12.TabIndex = 65;
            label12.Text = "License type:";
            // 
            // WorkstationProductDetailView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(btnCloseDetailView);
            Controls.Add(label16);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WorkstationProductDetailView";
            Size = new Size(1407, 1156);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label16;
        private GroupBox groupBox1;
        private Label lblCompanyName;
        private Label label1;
        private Button btnCloseDetailView;
        private Label lblNumberOfUsers;
        private Label label4;
        private Label lblOrderContractNumber;
        private Label label2;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txtProductName;
        private GroupBox groupBox3;
        private RichTextBox rtxReleaseDescription;
        private TextBox txtReleaseNumber;
        private TextBox txtReleaseInstallerVerificationPasscode;
        private Label label6;
        private Label label8;
        private Label label10;
        private TextBox txtProductNewestRelease;
        private Label label11;
        private RichTextBox rtxProductDescription;
        private Label label7;
        private GroupBox groupBox4;
        private MonthCalendar cdrLicenseActivationDate;
        private TextBox txtLicenseActivationCode;
        private Label label13;
        private TextBox txtLicenseType;
        private Label label12;
        private DateTimePicker dtpLicenseRegisterDate;
        private Label label14;
        private TextBox txtLicenseActivationCodeGenVersion;
        private Label label15;
        private Label label17;
        private TextBox txtLicenseLeaseInDays;
        private Label label18;
        private MonthCalendar cdrLicenseEndOfLicense;
        private Label label19;
        private ListBox lstEmployees;
        private Label label20;
        private Label lblOrderDateOfOrder;
        private Label label21;
    }
}
