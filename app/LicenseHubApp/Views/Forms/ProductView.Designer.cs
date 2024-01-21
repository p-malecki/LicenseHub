namespace LicenseHubApp.Views.Forms
{
    partial class ProductView
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
            dgvReleaseData = new DataGridView();
            label1 = new Label();
            cbProductList = new ComboBox();
            btnProductAdd = new Button();
            gbReleaseSelected = new GroupBox();
            btnReleaseAdd = new Button();
            btnReleaseRemove = new Button();
            label3 = new Label();
            txtReleaseNumber = new TextBox();
            label5 = new Label();
            txtReleaseInstallerVerificationPasscode = new TextBox();
            label4 = new Label();
            rtxtReleaseDescription = new RichTextBox();
            btnReleaseSave = new Button();
            label2 = new Label();
            chbProductIsAvailable = new CheckBox();
            txtProductName = new TextBox();
            label6 = new Label();
            gbProductSelected = new GroupBox();
            btnProductRename = new Button();
            btnProductSave = new Button();
            btnProductRemove = new Button();
            lbNewestRelease = new Label();
            lbLicensesGranted = new Label();
            lbActiveClientBaseNumber = new Label();
            rtxProductDescription = new RichTextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvReleaseData).BeginInit();
            gbReleaseSelected.SuspendLayout();
            gbProductSelected.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReleaseData
            // 
            dgvReleaseData.AllowUserToAddRows = false;
            dgvReleaseData.AllowUserToDeleteRows = false;
            dgvReleaseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReleaseData.Location = new Point(55, 52);
            dgvReleaseData.Name = "dgvReleaseData";
            dgvReleaseData.ReadOnly = true;
            dgvReleaseData.RowHeadersWidth = 62;
            dgvReleaseData.Size = new Size(322, 349);
            dgvReleaseData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(145, 45);
            label1.TabIndex = 2;
            label1.Text = "Products";
            // 
            // cbProductList
            // 
            cbProductList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductList.Font = new Font("Segoe UI", 12F);
            cbProductList.FormattingEnabled = true;
            cbProductList.Location = new Point(394, 148);
            cbProductList.Name = "cbProductList";
            cbProductList.Size = new Size(400, 40);
            cbProductList.TabIndex = 4;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Location = new Point(817, 148);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(150, 40);
            btnProductAdd.TabIndex = 11;
            btnProductAdd.Text = "Add new";
            btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // gbReleaseSelected
            // 
            gbReleaseSelected.Controls.Add(dgvReleaseData);
            gbReleaseSelected.Controls.Add(btnReleaseAdd);
            gbReleaseSelected.Controls.Add(btnReleaseRemove);
            gbReleaseSelected.Controls.Add(label3);
            gbReleaseSelected.Controls.Add(txtReleaseNumber);
            gbReleaseSelected.Controls.Add(label5);
            gbReleaseSelected.Controls.Add(txtReleaseInstallerVerificationPasscode);
            gbReleaseSelected.Controls.Add(label4);
            gbReleaseSelected.Controls.Add(rtxtReleaseDescription);
            gbReleaseSelected.Controls.Add(btnReleaseSave);
            gbReleaseSelected.Location = new Point(35, 389);
            gbReleaseSelected.Name = "gbReleaseSelected";
            gbReleaseSelected.Size = new Size(1195, 468);
            gbReleaseSelected.TabIndex = 12;
            gbReleaseSelected.TabStop = false;
            gbReleaseSelected.Text = "Releases";
            // 
            // btnReleaseAdd
            // 
            btnReleaseAdd.Location = new Point(55, 407);
            btnReleaseAdd.Name = "btnReleaseAdd";
            btnReleaseAdd.Size = new Size(156, 40);
            btnReleaseAdd.TabIndex = 11;
            btnReleaseAdd.Text = "Add new release";
            btnReleaseAdd.UseVisualStyleBackColor = true;
            // 
            // btnReleaseRemove
            // 
            btnReleaseRemove.Enabled = false;
            btnReleaseRemove.Location = new Point(221, 407);
            btnReleaseRemove.Name = "btnReleaseRemove";
            btnReleaseRemove.Size = new Size(156, 40);
            btnReleaseRemove.TabIndex = 11;
            btnReleaseRemove.Text = "Remove release";
            btnReleaseRemove.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 98);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 5;
            label3.Text = "Release number:";
            // 
            // txtReleaseNumber
            // 
            txtReleaseNumber.Location = new Point(911, 98);
            txtReleaseNumber.Name = "txtReleaseNumber";
            txtReleaseNumber.ReadOnly = true;
            txtReleaseNumber.Size = new Size(219, 31);
            txtReleaseNumber.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(591, 140);
            label5.Name = "label5";
            label5.Size = new Size(233, 25);
            label5.TabIndex = 5;
            label5.Text = "InstallerVerificationPasscode";
            // 
            // txtReleaseInstallerVerificationPasscode
            // 
            txtReleaseInstallerVerificationPasscode.Location = new Point(599, 168);
            txtReleaseInstallerVerificationPasscode.Name = "txtReleaseInstallerVerificationPasscode";
            txtReleaseInstallerVerificationPasscode.ReadOnly = true;
            txtReleaseInstallerVerificationPasscode.Size = new Size(531, 31);
            txtReleaseInstallerVerificationPasscode.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 212);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 5;
            label4.Text = "Description";
            // 
            // rtxtReleaseDescription
            // 
            rtxtReleaseDescription.Location = new Point(599, 240);
            rtxtReleaseDescription.Name = "rtxtReleaseDescription";
            rtxtReleaseDescription.ReadOnly = true;
            rtxtReleaseDescription.Size = new Size(531, 126);
            rtxtReleaseDescription.TabIndex = 13;
            rtxtReleaseDescription.Text = "";
            // 
            // btnReleaseSave
            // 
            btnReleaseSave.Enabled = false;
            btnReleaseSave.Location = new Point(1021, 382);
            btnReleaseSave.Name = "btnReleaseSave";
            btnReleaseSave.Size = new Size(109, 33);
            btnReleaseSave.TabIndex = 11;
            btnReleaseSave.Text = "Add";
            btnReleaseSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 120);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 5;
            label2.Text = "Select product";
            // 
            // chbProductIsAvailable
            // 
            chbProductIsAvailable.AutoSize = true;
            chbProductIsAvailable.Location = new Point(458, 91);
            chbProductIsAvailable.Name = "chbProductIsAvailable";
            chbProductIsAvailable.Size = new Size(109, 29);
            chbProductIsAvailable.TabIndex = 13;
            chbProductIsAvailable.Text = "Available";
            chbProductIsAvailable.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F);
            txtProductName.Location = new Point(35, 84);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(397, 39);
            txtProductName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 56);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 5;
            label6.Text = "Product name";
            // 
            // gbProductSelected
            // 
            gbProductSelected.Controls.Add(groupBox1);
            gbProductSelected.Controls.Add(label6);
            gbProductSelected.Controls.Add(txtProductName);
            gbProductSelected.Controls.Add(chbProductIsAvailable);
            gbProductSelected.Controls.Add(btnProductRename);
            gbProductSelected.Controls.Add(btnProductSave);
            gbProductSelected.Controls.Add(btnProductRemove);
            gbProductSelected.Controls.Add(label8);
            gbProductSelected.Controls.Add(rtxProductDescription);
            gbProductSelected.Controls.Add(gbReleaseSelected);
            gbProductSelected.Location = new Point(56, 234);
            gbProductSelected.Name = "gbProductSelected";
            gbProductSelected.Size = new Size(1268, 892);
            gbProductSelected.TabIndex = 14;
            gbProductSelected.TabStop = false;
            gbProductSelected.Text = "Selected product";
            // 
            // btnProductRename
            // 
            btnProductRename.Location = new Point(35, 316);
            btnProductRename.Name = "btnProductRename";
            btnProductRename.Size = new Size(109, 33);
            btnProductRename.TabIndex = 11;
            btnProductRename.Text = "Rename";
            btnProductRename.UseVisualStyleBackColor = true;
            // 
            // btnProductSave
            // 
            btnProductSave.Location = new Point(150, 316);
            btnProductSave.Name = "btnProductSave";
            btnProductSave.Size = new Size(109, 33);
            btnProductSave.TabIndex = 11;
            btnProductSave.Text = "Save";
            btnProductSave.UseVisualStyleBackColor = true;
            // 
            // btnProductRemove
            // 
            btnProductRemove.Location = new Point(265, 316);
            btnProductRemove.Name = "btnProductRemove";
            btnProductRemove.Size = new Size(170, 33);
            btnProductRemove.TabIndex = 11;
            btnProductRemove.Text = "Remove product";
            btnProductRemove.UseVisualStyleBackColor = true;
            // 
            // lbNewestRelease
            // 
            lbNewestRelease.AutoSize = true;
            lbNewestRelease.Location = new Point(45, 39);
            lbNewestRelease.Name = "lbNewestRelease";
            lbNewestRelease.Size = new Size(179, 25);
            lbNewestRelease.TabIndex = 14;
            lbNewestRelease.Text = "The newest release: X";
            // 
            // lbLicensesGranted
            // 
            lbLicensesGranted.AutoSize = true;
            lbLicensesGranted.Location = new Point(45, 67);
            lbLicensesGranted.Name = "lbLicensesGranted";
            lbLicensesGranted.Size = new Size(251, 25);
            lbLicensesGranted.TabIndex = 14;
            lbLicensesGranted.Text = "Number of licenses granted: X";
            // 
            // lbActiveClientBaseNumber
            // 
            lbActiveClientBaseNumber.AutoSize = true;
            lbActiveClientBaseNumber.Location = new Point(45, 96);
            lbActiveClientBaseNumber.Name = "lbActiveClientBaseNumber";
            lbActiveClientBaseNumber.Size = new Size(168, 25);
            lbActiveClientBaseNumber.TabIndex = 14;
            lbActiveClientBaseNumber.Text = "Active client base: X";
            // 
            // rtxProductDescription
            // 
            rtxProductDescription.Location = new Point(32, 163);
            rtxProductDescription.Name = "rtxProductDescription";
            rtxProductDescription.ReadOnly = true;
            rtxProductDescription.Size = new Size(535, 147);
            rtxProductDescription.TabIndex = 13;
            rtxProductDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 135);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 5;
            label8.Text = "Description";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbNewestRelease);
            groupBox1.Controls.Add(lbActiveClientBaseNumber);
            groupBox1.Controls.Add(lbLicensesGranted);
            groupBox1.Location = new Point(783, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 150);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stats:";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cbProductList);
            Controls.Add(btnProductAdd);
            Controls.Add(gbProductSelected);
            Name = "ProductView";
            Size = new Size(1407, 1156);
            ((System.ComponentModel.ISupportInitialize)dgvReleaseData).EndInit();
            gbReleaseSelected.ResumeLayout(false);
            gbReleaseSelected.PerformLayout();
            gbProductSelected.ResumeLayout(false);
            gbProductSelected.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReleaseData;
        private Label label1;
        private ComboBox cbProductList;
        private Button btnProductAdd;
        private GroupBox gbReleaseSelected;
        private Button btnReleaseAdd;
        private Label label2;
        private TextBox txtReleaseNumber;
        private Label label3;
        private RichTextBox rtxtReleaseDescription;
        private TextBox txtReleaseInstallerVerificationPasscode;
        private Label label4;
        private Label label5;
        private CheckBox chbProductIsAvailable;
        private TextBox txtProductName;
        private Label label6;
        private GroupBox gbProductSelected;
        private Label lbActiveClientBaseNumber;
        private Label lbLicensesGranted;
        private Label lbNewestRelease;
        private Button btnReleaseRemove;
        private Button btnReleaseSave;
        private Button btnProductRemove;
        private Button btnProductSave;
        private Button btnProductRename;
        private GroupBox groupBox1;
        private Label label8;
        private RichTextBox rtxProductDescription;
    }
}
