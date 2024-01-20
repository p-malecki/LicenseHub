namespace LicenseHubApp.Views.Forms
{
    partial class OrderDetailView
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
            btnEdit = new Button();
            rtxDescription = new RichTextBox();
            lblCompanyName = new Label();
            label1 = new Label();
            label14 = new Label();
            btnSave = new Button();
            btnEditCancel = new Button();
            label8 = new Label();
            label7 = new Label();
            dtpDateOfPayment = new DateTimePicker();
            label2 = new Label();
            dtpDateOfOrder = new DateTimePicker();
            label3 = new Label();
            dgvWorkstationProductData = new DataGridView();
            label4 = new Label();
            lblCompanyNip = new Label();
            label5 = new Label();
            btnGoToWorkstationProduct = new Button();
            btnCloseDetailView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWorkstationProductData).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(147, 557);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 48);
            btnEdit.TabIndex = 69;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // rtxDescription
            // 
            rtxDescription.BorderStyle = BorderStyle.FixedSingle;
            rtxDescription.Location = new Point(167, 437);
            rtxDescription.Name = "rtxDescription";
            rtxDescription.ReadOnly = true;
            rtxDescription.Size = new Size(523, 101);
            rtxDescription.TabIndex = 63;
            rtxDescription.Text = "";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(321, 214);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(135, 25);
            lblCompanyName.TabIndex = 56;
            lblCompanyName.Text = "company name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 214);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 57;
            label1.Text = "company name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(147, 409);
            label14.Name = "label14";
            label14.Size = new Size(102, 25);
            label14.TabIndex = 68;
            label14.Text = "Description";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(447, 557);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 48);
            btnSave.TabIndex = 70;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEditCancel
            // 
            btnEditCancel.Location = new Point(599, 557);
            btnEditCancel.Name = "btnEditCancel";
            btnEditCancel.Size = new Size(91, 48);
            btnEditCancel.TabIndex = 71;
            btnEditCancel.Text = "Cancel";
            btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(147, 373);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 67;
            label8.Text = "Date of payment:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(57, 99);
            label7.Name = "label7";
            label7.Size = new Size(204, 45);
            label7.TabIndex = 73;
            label7.Text = "Order details";
            // 
            // dtpDateOfPayment
            // 
            dtpDateOfPayment.Location = new Point(356, 373);
            dtpDateOfPayment.Name = "dtpDateOfPayment";
            dtpDateOfPayment.Size = new Size(334, 31);
            dtpDateOfPayment.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 336);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 67;
            label2.Text = "Date of order:";
            // 
            // dtpDateOfOrder
            // 
            dtpDateOfOrder.Location = new Point(356, 336);
            dtpDateOfOrder.Name = "dtpDateOfOrder";
            dtpDateOfOrder.Size = new Size(334, 31);
            dtpDateOfOrder.TabIndex = 74;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 669);
            label3.Name = "label3";
            label3.Size = new Size(258, 25);
            label3.TabIndex = 57;
            label3.Text = "Products included in this order:";
            // 
            // dgvWorkstationProductData
            // 
            dgvWorkstationProductData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkstationProductData.Location = new Point(148, 708);
            dgvWorkstationProductData.Name = "dgvWorkstationProductData";
            dgvWorkstationProductData.RowHeadersWidth = 62;
            dgvWorkstationProductData.Size = new Size(1164, 360);
            dgvWorkstationProductData.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 255);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 57;
            label4.Text = "company nip:";
            // 
            // lblCompanyNip
            // 
            lblCompanyNip.AutoSize = true;
            lblCompanyNip.Location = new Point(321, 255);
            lblCompanyNip.Name = "lblCompanyNip";
            lblCompanyNip.Size = new Size(116, 25);
            lblCompanyNip.TabIndex = 56;
            lblCompanyNip.Text = "company nip";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 177);
            label5.Name = "label5";
            label5.Size = new Size(308, 25);
            label5.TabIndex = 57;
            label5.Text = "The company which placed the order:";
            // 
            // btnGoToWorkstationProduct
            // 
            btnGoToWorkstationProduct.Location = new Point(1166, 1074);
            btnGoToWorkstationProduct.Name = "btnGoToWorkstationProduct";
            btnGoToWorkstationProduct.Size = new Size(146, 48);
            btnGoToWorkstationProduct.TabIndex = 70;
            btnGoToWorkstationProduct.Text = "Go to product";
            btnGoToWorkstationProduct.UseVisualStyleBackColor = true;
            // 
            // btnCloseDetailView
            // 
            btnCloseDetailView.Location = new Point(1279, 0);
            btnCloseDetailView.Name = "btnCloseDetailView";
            btnCloseDetailView.Size = new Size(56, 34);
            btnCloseDetailView.TabIndex = 76;
            btnCloseDetailView.Text = "X";
            btnCloseDetailView.UseVisualStyleBackColor = true;
            // 
            // OrderDetailView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCloseDetailView);
            Controls.Add(dgvWorkstationProductData);
            Controls.Add(dtpDateOfOrder);
            Controls.Add(dtpDateOfPayment);
            Controls.Add(label7);
            Controls.Add(btnEdit);
            Controls.Add(rtxDescription);
            Controls.Add(lblCompanyNip);
            Controls.Add(lblCompanyName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(btnGoToWorkstationProduct);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(btnEditCancel);
            Controls.Add(label8);
            Name = "OrderDetailView";
            Size = new Size(1407, 1156);
            ((System.ComponentModel.ISupportInitialize)dgvWorkstationProductData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbEmployeeIsActive;
        private Button btnEdit;
        private RichTextBox rtxDescription;
        private Label lblCompanyName;
        private Label label1;
        private Label label14;
        private Button btnSave;
        private Button btnEditCancel;
        private Label label8;
        private Label label7;
        private DateTimePicker dtpDateOfPayment;
        private Label label2;
        private DateTimePicker dtpDateOfOrder;
        private Label label3;
        private DataGridView dgvWorkstationProductData;
        private Label label4;
        private Label lblCompanyNip;
        private Label label5;
        private Button btnGoToWorkstationProduct;
        private Button btnCloseDetailView;
    }
}
