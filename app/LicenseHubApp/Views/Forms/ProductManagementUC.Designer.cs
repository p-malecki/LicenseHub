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
            dgvProductsData = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductsData).BeginInit();
            SuspendLayout();
            // 
            // dgvProductsData
            // 
            dgvProductsData.AllowUserToAddRows = false;
            dgvProductsData.AllowUserToDeleteRows = false;
            dgvProductsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsData.Location = new Point(47, 156);
            dgvProductsData.Name = "dgvProductsData";
            dgvProductsData.ReadOnly = true;
            dgvProductsData.RowHeadersWidth = 62;
            dgvProductsData.Size = new Size(1271, 662);
            dgvProductsData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(47, 108);
            label1.Name = "label1";
            label1.Size = new Size(145, 45);
            label1.TabIndex = 2;
            label1.Text = "Products";
            // 
            // ProductManagementUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dgvProductsData);
            Name = "ProductManagementUC";
            Size = new Size(1407, 1156);
            ((System.ComponentModel.ISupportInitialize)dgvProductsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductsData;
        private Label label1;
    }
}
