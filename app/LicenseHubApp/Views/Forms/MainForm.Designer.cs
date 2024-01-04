﻿namespace LicenseHubApp.Views.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label1 = new Label();
            btnDashboard = new Button();
            topBarPanel = new Panel();
            lbLoggedInUser = new Label();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSettings = new Button();
            btnLogout = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnReports = new Button();
            btnLicences = new Button();
            btnProducts = new Button();
            btnClients = new Button();
            btnOrders = new Button();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageDashboard = new TabPage();
            tabPageClients = new TabPage();
            companyManagementuc1 = new CompanyManagementUC();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            panel2.SuspendLayout();
            topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageClients.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 150);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 64);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "logo";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Gainsboro;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(368, 57);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // topBarPanel
            // 
            topBarPanel.BackColor = SystemColors.Window;
            topBarPanel.Controls.Add(lbLoggedInUser);
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(0, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(1408, 72);
            topBarPanel.TabIndex = 2;
            // 
            // lbLoggedInUser
            // 
            lbLoggedInUser.AutoSize = true;
            lbLoggedInUser.Location = new Point(1268, 22);
            lbLoggedInUser.Name = "lbLoggedInUser";
            lbLoggedInUser.Size = new Size(107, 25);
            lbLoggedInUser.TabIndex = 0;
            lbLoggedInUser.Text = "logged user";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Panel2.Controls.Add(topBarPanel);
            splitContainer1.Size = new Size(1786, 1266);
            splitContainer1.SplitterDistance = 374;
            splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnSettings, 0, 0);
            tableLayoutPanel2.Controls.Add(btnLogout, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 1116);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(374, 150);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Gainsboro;
            btnSettings.Dock = DockStyle.Top;
            btnSettings.Location = new Point(3, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(368, 34);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Gainsboro;
            btnLogout.Dock = DockStyle.Top;
            btnLogout.Location = new Point(3, 68);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(368, 34);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnReports, 0, 5);
            tableLayoutPanel1.Controls.Add(btnDashboard, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLicences, 0, 4);
            tableLayoutPanel1.Controls.Add(btnProducts, 0, 3);
            tableLayoutPanel1.Controls.Add(btnClients, 0, 1);
            tableLayoutPanel1.Controls.Add(btnOrders, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 353);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.38168F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.61832F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.Size = new Size(374, 379);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Gainsboro;
            btnReports.Dock = DockStyle.Top;
            btnReports.Location = new Point(3, 319);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(368, 56);
            btnReports.TabIndex = 8;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnLicences
            // 
            btnLicences.BackColor = Color.Gainsboro;
            btnLicences.Dock = DockStyle.Top;
            btnLicences.Location = new Point(3, 256);
            btnLicences.Name = "btnLicences";
            btnLicences.Size = new Size(368, 56);
            btnLicences.TabIndex = 7;
            btnLicences.Text = "Licences";
            btnLicences.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.Gainsboro;
            btnProducts.Dock = DockStyle.Top;
            btnProducts.Location = new Point(3, 197);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(368, 53);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.Gainsboro;
            btnClients.Dock = DockStyle.Top;
            btnClients.Location = new Point(3, 69);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(368, 57);
            btnClients.TabIndex = 2;
            btnClients.Text = "Clients";
            btnClients.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Gainsboro;
            btnOrders.Dock = DockStyle.Top;
            btnOrders.Location = new Point(3, 134);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(368, 57);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 203);
            panel1.TabIndex = 9;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageDashboard);
            tabControl1.Controls.Add(tabPageClients);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 72);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1408, 1194);
            tabControl1.TabIndex = 3;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.BackColor = SystemColors.Window;
            tabPageDashboard.Location = new Point(4, 34);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(3);
            tabPageDashboard.Size = new Size(1400, 1156);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "tabPageDashboard";
            // 
            // tabPageClients
            // 
            tabPageClients.Controls.Add(companyManagementuc1);
            tabPageClients.Location = new Point(4, 34);
            tabPageClients.Name = "tabPageClients";
            tabPageClients.Padding = new Padding(3);
            tabPageClients.Size = new Size(1400, 1156);
            tabPageClients.TabIndex = 1;
            tabPageClients.Text = "tabPageClients";
            tabPageClients.UseVisualStyleBackColor = true;
            // 
            // companyManagementuc1
            // 
            companyManagementuc1.Dock = DockStyle.Fill;
            companyManagementuc1.Location = new Point(3, 3);
            companyManagementuc1.Name = "companyManagementuc1";
            companyManagementuc1.Size = new Size(1394, 1150);
            companyManagementuc1.TabIndex = 1;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1786, 1266);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageClients.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnDashboard;
        private Panel topBarPanel;
        private SplitContainer splitContainer1;
        private Button btnProducts;
        private Button btnClients;
        private Button btnOrders;
        private Label lbLoggedInUser;
        private Label label1;
        private Button btnLogout;
        private Button btnSettings;
        private Button btnLicences;
        private Button btnReports;
        private TabControl tabControl1;
        private TabPage tabPageDashboard;
        private TabPage tabPageClients;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private CompanyManagementUC companyManagementuc1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}