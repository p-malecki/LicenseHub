﻿namespace LicenseHubApp.Views.Forms
{
    partial class OrderCreatorView
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
            dgvWorkstationProductData = new DataGridView();
            dtpDateOfOrder = new DateTimePicker();
            dtpDateOfPayment = new DateTimePicker();
            label7 = new Label();
            rtxDescription = new RichTextBox();
            label5 = new Label();
            label14 = new Label();
            btnOrderAdd = new Button();
            label2 = new Label();
            btnOrderCancel = new Button();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txtCompanyContractNumber = new TextBox();
            rdoCompanyName = new RadioButton();
            rdoCompanyNip = new RadioButton();
            cmbSelectedCompany = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label18 = new Label();
            nudLicenseLeaseTermInDays = new NumericUpDown();
            nudProductQuantity = new NumericUpDown();
            cmbRelease = new ComboBox();
            label6 = new Label();
            btnProductAdd = new Button();
            cmbLicenseType = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            cmbProduct = new ComboBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnProductRemove = new Button();
            btnLicenseRegister = new Button();
            groupBox4 = new GroupBox();
            btnLicenseActivate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWorkstationProductData).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLicenseLeaseTermInDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductQuantity).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvWorkstationProductData
            // 
            dgvWorkstationProductData.AllowUserToAddRows = false;
            dgvWorkstationProductData.AllowUserToDeleteRows = false;
            dgvWorkstationProductData.AllowUserToResizeRows = false;
            dgvWorkstationProductData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkstationProductData.Location = new Point(26, 59);
            dgvWorkstationProductData.Name = "dgvWorkstationProductData";
            dgvWorkstationProductData.RowHeadersWidth = 62;
            dgvWorkstationProductData.ShowCellErrors = false;
            dgvWorkstationProductData.ShowCellToolTips = false;
            dgvWorkstationProductData.ShowEditingIcon = false;
            dgvWorkstationProductData.ShowRowErrors = false;
            dgvWorkstationProductData.Size = new Size(526, 585);
            dgvWorkstationProductData.TabIndex = 93;
            // 
            // dtpDateOfOrder
            // 
            dtpDateOfOrder.Location = new Point(847, 44);
            dtpDateOfOrder.Name = "dtpDateOfOrder";
            dtpDateOfOrder.Size = new Size(334, 31);
            dtpDateOfOrder.TabIndex = 92;
            // 
            // dtpDateOfPayment
            // 
            dtpDateOfPayment.Location = new Point(847, 81);
            dtpDateOfPayment.Name = "dtpDateOfPayment";
            dtpDateOfPayment.Size = new Size(334, 31);
            dtpDateOfPayment.TabIndex = 91;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(76, 67);
            label7.Name = "label7";
            label7.Size = new Size(211, 45);
            label7.TabIndex = 90;
            label7.Text = "Order creator";
            // 
            // rtxDescription
            // 
            rtxDescription.BorderStyle = BorderStyle.FixedSingle;
            rtxDescription.Location = new Point(658, 145);
            rtxDescription.Name = "rtxDescription";
            rtxDescription.Size = new Size(523, 127);
            rtxDescription.TabIndex = 82;
            rtxDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 49);
            label5.Name = "label5";
            label5.Size = new Size(326, 25);
            label5.TabIndex = 80;
            label5.Text = "Select company which placed the order:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(638, 117);
            label14.Name = "label14";
            label14.Size = new Size(102, 25);
            label14.TabIndex = 85;
            label14.Text = "Description";
            // 
            // btnOrderAdd
            // 
            btnOrderAdd.Enabled = false;
            btnOrderAdd.Location = new Point(1104, 1030);
            btnOrderAdd.Name = "btnOrderAdd";
            btnOrderAdd.Size = new Size(146, 75);
            btnOrderAdd.TabIndex = 88;
            btnOrderAdd.Text = "Add order";
            btnOrderAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(638, 44);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 83;
            label2.Text = "Date of order:";
            // 
            // btnOrderCancel
            // 
            btnOrderCancel.Location = new Point(1256, 1030);
            btnOrderCancel.Name = "btnOrderCancel";
            btnOrderCancel.Size = new Size(91, 75);
            btnOrderCancel.TabIndex = 89;
            btnOrderCancel.Text = "Cancel";
            btnOrderCancel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(638, 81);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 84;
            label8.Text = "Date of payment:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCompanyContractNumber);
            groupBox1.Controls.Add(rdoCompanyName);
            groupBox1.Controls.Add(rdoCompanyNip);
            groupBox1.Controls.Add(cmbSelectedCompany);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpDateOfOrder);
            groupBox1.Controls.Add(dtpDateOfPayment);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(rtxDescription);
            groupBox1.Location = new Point(89, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1258, 303);
            groupBox1.TabIndex = 94;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // txtCompanyContractNumber
            // 
            txtCompanyContractNumber.Location = new Point(47, 196);
            txtCompanyContractNumber.Name = "txtCompanyContractNumber";
            txtCompanyContractNumber.Size = new Size(322, 31);
            txtCompanyContractNumber.TabIndex = 95;
            // 
            // rdoCompanyName
            // 
            rdoCompanyName.AutoSize = true;
            rdoCompanyName.Location = new Point(47, 84);
            rdoCompanyName.Name = "rdoCompanyName";
            rdoCompanyName.Size = new Size(160, 29);
            rdoCompanyName.TabIndex = 94;
            rdoCompanyName.TabStop = true;
            rdoCompanyName.Text = "company name";
            rdoCompanyName.UseVisualStyleBackColor = true;
            // 
            // rdoCompanyNip
            // 
            rdoCompanyNip.AutoSize = true;
            rdoCompanyNip.Location = new Point(222, 84);
            rdoCompanyNip.Name = "rdoCompanyNip";
            rdoCompanyNip.Size = new Size(62, 29);
            rdoCompanyNip.TabIndex = 94;
            rdoCompanyNip.TabStop = true;
            rdoCompanyNip.Text = "nip";
            rdoCompanyNip.UseVisualStyleBackColor = true;
            // 
            // cmbSelectedCompany
            // 
            cmbSelectedCompany.FormattingEnabled = true;
            cmbSelectedCompany.Location = new Point(47, 119);
            cmbSelectedCompany.Name = "cmbSelectedCompany";
            cmbSelectedCompany.Size = new Size(322, 33);
            cmbSelectedCompany.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 168);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 80;
            label1.Text = "Contract number:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(nudLicenseLeaseTermInDays);
            groupBox2.Controls.Add(nudProductQuantity);
            groupBox2.Controls.Add(cmbRelease);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnProductAdd);
            groupBox2.Controls.Add(cmbLicenseType);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cmbProduct);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(685, 461);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(662, 283);
            groupBox2.TabIndex = 95;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add product to order";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(360, 122);
            label18.Name = "label18";
            label18.Size = new Size(153, 25);
            label18.TabIndex = 82;
            label18.Text = "Lease term (days):";
            // 
            // nudLicenseLeaseTermInDays
            // 
            nudLicenseLeaseTermInDays.Location = new Point(360, 150);
            nudLicenseLeaseTermInDays.Maximum = new decimal(new int[] { 3653, 0, 0, 0 });
            nudLicenseLeaseTermInDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLicenseLeaseTermInDays.Name = "nudLicenseLeaseTermInDays";
            nudLicenseLeaseTermInDays.Size = new Size(249, 31);
            nudLicenseLeaseTermInDays.TabIndex = 81;
            nudLicenseLeaseTermInDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudProductQuantity
            // 
            nudProductQuantity.Location = new Point(43, 225);
            nudProductQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudProductQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudProductQuantity.Name = "nudProductQuantity";
            nudProductQuantity.Size = new Size(249, 31);
            nudProductQuantity.TabIndex = 81;
            nudProductQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbRelease
            // 
            cmbRelease.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRelease.FormattingEnabled = true;
            cmbRelease.Location = new Point(43, 148);
            cmbRelease.Name = "cmbRelease";
            cmbRelease.Size = new Size(249, 33);
            cmbRelease.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 120);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 80;
            label6.Text = "Release:";
            // 
            // btnProductAdd
            // 
            btnProductAdd.Location = new Point(457, 221);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(152, 37);
            btnProductAdd.TabIndex = 88;
            btnProductAdd.Text = "Add";
            btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // cmbLicenseType
            // 
            cmbLicenseType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLicenseType.FormattingEnabled = true;
            cmbLicenseType.Location = new Point(360, 69);
            cmbLicenseType.Name = "cmbLicenseType";
            cmbLicenseType.Size = new Size(249, 33);
            cmbLicenseType.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(360, 41);
            label11.Name = "label11";
            label11.Size = new Size(112, 25);
            label11.TabIndex = 80;
            label11.Text = "License type:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 197);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 80;
            label10.Text = "Quantity:";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(43, 69);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(249, 33);
            cmbProduct.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 41);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 80;
            label4.Text = "Product:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvWorkstationProductData);
            groupBox3.Location = new Point(89, 461);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(578, 663);
            groupBox3.TabIndex = 96;
            groupBox3.TabStop = false;
            groupBox3.Text = "Products included in this order";
            // 
            // btnProductRemove
            // 
            btnProductRemove.Location = new Point(145, 43);
            btnProductRemove.Name = "btnProductRemove";
            btnProductRemove.Size = new Size(368, 43);
            btnProductRemove.TabIndex = 88;
            btnProductRemove.Text = "Remove selected product";
            btnProductRemove.UseVisualStyleBackColor = true;
            // 
            // btnLicenseRegister
            // 
            btnLicenseRegister.Location = new Point(145, 106);
            btnLicenseRegister.Name = "btnLicenseRegister";
            btnLicenseRegister.Size = new Size(368, 44);
            btnLicenseRegister.TabIndex = 88;
            btnLicenseRegister.Text = "Register workstation and license";
            btnLicenseRegister.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLicenseActivate);
            groupBox4.Controls.Add(btnProductRemove);
            groupBox4.Controls.Add(btnLicenseRegister);
            groupBox4.Location = new Point(685, 750);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(662, 242);
            groupBox4.TabIndex = 99;
            groupBox4.TabStop = false;
            groupBox4.Text = "Selected product";
            // 
            // btnLicenseActivate
            // 
            btnLicenseActivate.Location = new Point(145, 170);
            btnLicenseActivate.Name = "btnLicenseActivate";
            btnLicenseActivate.Size = new Size(368, 44);
            btnLicenseActivate.TabIndex = 88;
            btnLicenseActivate.Text = "Activate license";
            btnLicenseActivate.UseVisualStyleBackColor = true;
            // 
            // OrderCreatorView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(btnOrderCancel);
            Controls.Add(btnOrderAdd);
            Name = "OrderCreatorView";
            Size = new Size(1407, 1156);
            ((System.ComponentModel.ISupportInitialize)dgvWorkstationProductData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLicenseLeaseTermInDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductQuantity).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvWorkstationProductData;
        private DateTimePicker dtpDateOfOrder;
        private DateTimePicker dtpDateOfPayment;
        private Label label7;
        private Button btnEdit;
        private RichTextBox rtxDescription;
        private Label label5;
        private Label label14;
        private Button btnSave;
        private Label label2;
        private Button btnOrderAdd;
        private Button btnOrderCancel;
        private Label label8;
        private GroupBox groupBox1;
        private ComboBox cmbSelectedCompany;
        private RadioButton rdoCompanyName;
        private RadioButton rdoCompanyNip;
        private TextBox txtCompanyContractNumber;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cmbRelease;
        private Label label6;
        private ComboBox cmbProduct;
        private Label label4;
        private NumericUpDown nudProductQuantity;
        private Label label10;
        private ComboBox cmbLicenseType;
        private Label label11;
        private Label label18;
        private NumericUpDown nudLicenseLeaseTermInDays;
        private Button btnProductAdd;
        private GroupBox groupBox3;
        private Button btnProductRemove;
        private Button btnLicenseRegister;
        private GroupBox groupBox4;
        private Button btnLicenseActivate;
    }
}
