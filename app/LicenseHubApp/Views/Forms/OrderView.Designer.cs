namespace LicenseHubApp.Views.Forms
{
    partial class OrderView
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
            btnAdd = new Button();
            btnShowDetails = new Button();
            btnSearch = new Button();
            txtSearchCompanyNip = new TextBox();
            dgvOrderData = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            chbCompanyFilters = new CheckBox();
            cmbSearchCompanyName = new ComboBox();
            chbOrderFilters = new CheckBox();
            txtSearchOrderContractNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderData).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(41, 1034);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 68);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnShowDetails
            // 
            btnShowDetails.Location = new Point(203, 1034);
            btnShowDetails.Name = "btnShowDetails";
            btnShowDetails.Size = new Size(225, 68);
            btnShowDetails.TabIndex = 25;
            btnShowDetails.Text = "Show details ";
            btnShowDetails.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1021, 88);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchCompanyNip
            // 
            txtSearchCompanyNip.Font = new Font("Segoe UI", 9.5F);
            txtSearchCompanyNip.Location = new Point(407, 90);
            txtSearchCompanyNip.Name = "txtSearchCompanyNip";
            txtSearchCompanyNip.Size = new Size(258, 33);
            txtSearchCompanyNip.TabIndex = 19;
            // 
            // dgvOrderData
            // 
            dgvOrderData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderData.Location = new Point(41, 280);
            dgvOrderData.Name = "dgvOrderData";
            dgvOrderData.RowHeadersWidth = 62;
            dgvOrderData.Size = new Size(1164, 748);
            dgvOrderData.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(41, 53);
            label1.Name = "label1";
            label1.Size = new Size(116, 45);
            label1.TabIndex = 17;
            label1.Text = "Orders";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chbCompanyFilters);
            groupBox1.Controls.Add(cmbSearchCompanyName);
            groupBox1.Controls.Add(txtSearchCompanyNip);
            groupBox1.Controls.Add(chbOrderFilters);
            groupBox1.Controls.Add(txtSearchOrderContractNumber);
            groupBox1.Location = new Point(41, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1164, 157);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "filters";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(730, 62);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 27;
            label4.Text = "contract number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 62);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 27;
            label3.Text = "nip";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 62);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 27;
            label2.Text = "company name";
            // 
            // chbCompanyFilters
            // 
            chbCompanyFilters.AutoSize = true;
            chbCompanyFilters.Location = new Point(41, 30);
            chbCompanyFilters.Name = "chbCompanyFilters";
            chbCompanyFilters.Size = new Size(119, 29);
            chbCompanyFilters.TabIndex = 26;
            chbCompanyFilters.Text = "Company:";
            chbCompanyFilters.UseVisualStyleBackColor = true;
            // 
            // cmbSearchCompanyName
            // 
            cmbSearchCompanyName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchCompanyName.FormattingEnabled = true;
            cmbSearchCompanyName.Location = new Point(65, 90);
            cmbSearchCompanyName.Name = "cmbSearchCompanyName";
            cmbSearchCompanyName.Size = new Size(322, 33);
            cmbSearchCompanyName.TabIndex = 20;
            // 
            // chbOrderFilters
            // 
            chbOrderFilters.AutoSize = true;
            chbOrderFilters.Location = new Point(705, 30);
            chbOrderFilters.Name = "chbOrderFilters";
            chbOrderFilters.Size = new Size(88, 29);
            chbOrderFilters.TabIndex = 26;
            chbOrderFilters.Text = "Order:";
            chbOrderFilters.UseVisualStyleBackColor = true;
            // 
            // txtSearchOrderContractNumber
            // 
            txtSearchOrderContractNumber.Font = new Font("Segoe UI", 9.5F);
            txtSearchOrderContractNumber.Location = new Point(730, 90);
            txtSearchOrderContractNumber.Name = "txtSearchOrderContractNumber";
            txtSearchOrderContractNumber.Size = new Size(258, 33);
            txtSearchOrderContractNumber.TabIndex = 19;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgvOrderData);
            Controls.Add(btnAdd);
            Controls.Add(btnShowDetails);
            Name = "OrderView";
            Size = new Size(1407, 1156);
            ((System.ComponentModel.ISupportInitialize)dgvOrderData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Button btnShowDetails;
        private Button btnSearch;
        private TextBox txtSearchCompanyNip;
        private DataGridView dgvOrderData;
        private Label label1;
        private GroupBox groupBox1;
        private CheckBox chbOrderFilters;
        private CheckBox chbCompanyFilters;
        private ComboBox cmbSearchCompanyName;
        private TextBox txtSearchOrderContractNumber;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
