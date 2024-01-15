namespace LicenseHubApp.Views.Forms
{
    partial class ProductManagementUC
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
            btnReleaseRemove = new Button();
            btnReleaseSave = new Button();
            btnReleaseAdd = new Button();
            label3 = new Label();
            txtReleaseNumber = new TextBox();
            label5 = new Label();
            txtReleaseInstallerVerificationPasscode = new TextBox();
            label4 = new Label();
            rtxtReleaseDescription = new RichTextBox();
            label2 = new Label();
            chbProductIsAvailable = new CheckBox();
            txtProductName = new TextBox();
            label6 = new Label();
            gbProductSelected = new GroupBox();
            lbActiveClientBaseNumber = new Label();
            btnProductRemove = new Button();
            btnProductRename = new Button();
            btnProductSave = new Button();
            lbLicensesGranted = new Label();
            label7 = new Label();
            lbNewestRelease = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReleaseData).BeginInit();
            gbReleaseSelected.SuspendLayout();
            gbProductSelected.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReleaseData
            // 
            dgvReleaseData.AllowUserToAddRows = false;
            dgvReleaseData.AllowUserToDeleteRows = false;
            dgvReleaseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReleaseData.Location = new Point(45, 43);
            dgvReleaseData.Name = "dgvReleaseData";
            dgvReleaseData.ReadOnly = true;
            dgvReleaseData.RowHeadersWidth = 62;
            dgvReleaseData.Size = new Size(322, 512);
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
            cbProductList.Location = new Point(389, 166);
            cbProductList.Name = "cbProductList";
            cbProductList.Size = new Size(400, 40);
            cbProductList.TabIndex = 4;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Location = new Point(812, 166);
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
            gbReleaseSelected.Location = new Point(35, 204);
            gbReleaseSelected.Name = "gbReleaseSelected";
            gbReleaseSelected.Size = new Size(1195, 619);
            gbReleaseSelected.TabIndex = 12;
            gbReleaseSelected.TabStop = false;
            gbReleaseSelected.Text = "Releases";
            // 
            // btnReleaseRemove
            // 
            btnReleaseRemove.Enabled = false;
            btnReleaseRemove.Location = new Point(211, 561);
            btnReleaseRemove.Name = "btnReleaseRemove";
            btnReleaseRemove.Size = new Size(156, 40);
            btnReleaseRemove.TabIndex = 11;
            btnReleaseRemove.Text = "Remove release";
            btnReleaseRemove.UseVisualStyleBackColor = true;
            // 
            // btnReleaseSave
            // 
            btnReleaseSave.Enabled = false;
            btnReleaseSave.Location = new Point(1012, 448);
            btnReleaseSave.Name = "btnReleaseSave";
            btnReleaseSave.Size = new Size(109, 33);
            btnReleaseSave.TabIndex = 11;
            btnReleaseSave.Text = "Add";
            btnReleaseSave.UseVisualStyleBackColor = true;
            // 
            // btnReleaseAdd
            // 
            btnReleaseAdd.Location = new Point(45, 561);
            btnReleaseAdd.Name = "btnReleaseAdd";
            btnReleaseAdd.Size = new Size(156, 40);
            btnReleaseAdd.TabIndex = 11;
            btnReleaseAdd.Text = "Add new release";
            btnReleaseAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(582, 164);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 5;
            label3.Text = "Release number:";
            // 
            // txtReleaseNumber
            // 
            txtReleaseNumber.Location = new Point(902, 164);
            txtReleaseNumber.Name = "txtReleaseNumber";
            txtReleaseNumber.ReadOnly = true;
            txtReleaseNumber.Size = new Size(219, 31);
            txtReleaseNumber.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(582, 206);
            label5.Name = "label5";
            label5.Size = new Size(233, 25);
            label5.TabIndex = 5;
            label5.Text = "InstallerVerificationPasscode";
            // 
            // txtReleaseInstallerVerificationPasscode
            // 
            txtReleaseInstallerVerificationPasscode.Location = new Point(590, 234);
            txtReleaseInstallerVerificationPasscode.Name = "txtReleaseInstallerVerificationPasscode";
            txtReleaseInstallerVerificationPasscode.ReadOnly = true;
            txtReleaseInstallerVerificationPasscode.Size = new Size(531, 31);
            txtReleaseInstallerVerificationPasscode.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 278);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 5;
            label4.Text = "Description";
            // 
            // rtxtReleaseDescription
            // 
            rtxtReleaseDescription.Location = new Point(590, 306);
            rtxtReleaseDescription.Name = "rtxtReleaseDescription";
            rtxtReleaseDescription.ReadOnly = true;
            rtxtReleaseDescription.Size = new Size(531, 126);
            rtxtReleaseDescription.TabIndex = 13;
            rtxtReleaseDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 138);
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
            gbProductSelected.Controls.Add(label6);
            gbProductSelected.Controls.Add(txtProductName);
            gbProductSelected.Controls.Add(chbProductIsAvailable);
            gbProductSelected.Controls.Add(btnProductRename);
            gbProductSelected.Controls.Add(btnProductSave);
            gbProductSelected.Controls.Add(btnProductRemove);
            gbProductSelected.Controls.Add(label7);
            gbProductSelected.Controls.Add(lbNewestRelease);
            gbProductSelected.Controls.Add(lbLicensesGranted);
            gbProductSelected.Controls.Add(lbActiveClientBaseNumber);
            gbProductSelected.Controls.Add(gbReleaseSelected);
            gbProductSelected.Location = new Point(56, 297);
            gbProductSelected.Name = "gbProductSelected";
            gbProductSelected.Size = new Size(1268, 829);
            gbProductSelected.TabIndex = 14;
            gbProductSelected.TabStop = false;
            gbProductSelected.Text = "Selected product";
            // 
            // lbActiveClientBaseNumber
            // 
            lbActiveClientBaseNumber.AutoSize = true;
            lbActiveClientBaseNumber.Location = new Point(854, 138);
            lbActiveClientBaseNumber.Name = "lbActiveClientBaseNumber";
            lbActiveClientBaseNumber.Size = new Size(168, 25);
            lbActiveClientBaseNumber.TabIndex = 14;
            lbActiveClientBaseNumber.Text = "Active client base: X";
            // 
            // btnProductRemove
            // 
            btnProductRemove.Location = new Point(262, 130);
            btnProductRemove.Name = "btnProductRemove";
            btnProductRemove.Size = new Size(170, 33);
            btnProductRemove.TabIndex = 11;
            btnProductRemove.Text = "Remove product";
            btnProductRemove.UseVisualStyleBackColor = true;
            // 
            // btnProductRename
            // 
            btnProductRename.Location = new Point(32, 130);
            btnProductRename.Name = "btnProductRename";
            btnProductRename.Size = new Size(109, 33);
            btnProductRename.TabIndex = 11;
            btnProductRename.Text = "Rename";
            btnProductRename.UseVisualStyleBackColor = true;
            // 
            // btnProductSave
            // 
            btnProductSave.Location = new Point(147, 130);
            btnProductSave.Name = "btnProductSave";
            btnProductSave.Size = new Size(109, 33);
            btnProductSave.TabIndex = 11;
            btnProductSave.Text = "Save";
            btnProductSave.UseVisualStyleBackColor = true;
            // 
            // lbLicensesGranted
            // 
            lbLicensesGranted.AutoSize = true;
            lbLicensesGranted.Location = new Point(854, 109);
            lbLicensesGranted.Name = "lbLicensesGranted";
            lbLicensesGranted.Size = new Size(251, 25);
            lbLicensesGranted.TabIndex = 14;
            lbLicensesGranted.Text = "Number of licenses granted: X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(814, 47);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 14;
            label7.Text = "Stats:";
            // 
            // lbNewestRelease
            // 
            lbNewestRelease.AutoSize = true;
            lbNewestRelease.Location = new Point(854, 81);
            lbNewestRelease.Name = "lbNewestRelease";
            lbNewestRelease.Size = new Size(179, 25);
            lbNewestRelease.TabIndex = 14;
            lbNewestRelease.Text = "The newest release: X";
            // 
            // ProductManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cbProductList);
            Controls.Add(btnProductAdd);
            Controls.Add(gbProductSelected);
            Name = "ProductManagementUC";
            Size = new Size(1407, 1156);
            ((System.ComponentModel.ISupportInitialize)dgvReleaseData).EndInit();
            gbReleaseSelected.ResumeLayout(false);
            gbReleaseSelected.PerformLayout();
            gbProductSelected.ResumeLayout(false);
            gbProductSelected.PerformLayout();
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
        private Label label7;
        private Label lbNewestRelease;
        private Button btnReleaseRemove;
        private Button btnReleaseSave;
        private Button btnProductRemove;
        private Button btnProductSave;
        private Button btnProductRename;
    }
}
