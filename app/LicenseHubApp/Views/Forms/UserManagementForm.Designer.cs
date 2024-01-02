namespace LicenseHubApp.Views.Forms
{
    partial class UserManagementForm
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
            label1 = new Label();
            cbIsAdmin = new CheckBox();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            label4 = new Label();
            btnDelete = new Button();
            txtNewPassword = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPageUserList = new TabPage();
            btnAdd = new Button();
            btnEdit = new Button();
            tabPageUserDetails = new TabPage();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageUserList.SuspendLayout();
            tabPageUserDetails.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "user Id";
            // 
            // cbIsAdmin
            // 
            cbIsAdmin.AutoSize = true;
            cbIsAdmin.Location = new Point(98, 124);
            cbIsAdmin.Name = "cbIsAdmin";
            cbIsAdmin.Size = new Size(104, 29);
            cbIsAdmin.TabIndex = 2;
            cbIsAdmin.Text = "IsAdmin";
            cbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(463, 241);
            dataGridView1.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(206, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 98);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 9;
            label4.Text = "password";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(472, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete user";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(273, 124);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(227, 31);
            txtNewPassword.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 27);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(273, 55);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(227, 31);
            txtUsername.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 55);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 45);
            label3.TabIndex = 5;
            label3.Text = "Users";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(644, 334);
            splitContainer1.SplitterDistance = 45;
            splitContainer1.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUserList);
            tabControl1.Controls.Add(tabPageUserDetails);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(644, 285);
            tabControl1.TabIndex = 7;
            // 
            // tabPageUserList
            // 
            tabPageUserList.Controls.Add(btnAdd);
            tabPageUserList.Controls.Add(btnEdit);
            tabPageUserList.Controls.Add(btnDelete);
            tabPageUserList.Controls.Add(dataGridView1);
            tabPageUserList.Location = new Point(4, 34);
            tabPageUserList.Name = "tabPageUserList";
            tabPageUserList.Padding = new Padding(3);
            tabPageUserList.Size = new Size(636, 247);
            tabPageUserList.TabIndex = 0;
            tabPageUserList.Text = "User list";
            tabPageUserList.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(472, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add new user";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(472, 56);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(156, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit selected";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // tabPageUserDetails
            // 
            tabPageUserDetails.Controls.Add(btnCancel);
            tabPageUserDetails.Controls.Add(label4);
            tabPageUserDetails.Controls.Add(txtNewPassword);
            tabPageUserDetails.Controls.Add(cbIsAdmin);
            tabPageUserDetails.Controls.Add(btnSave);
            tabPageUserDetails.Controls.Add(label1);
            tabPageUserDetails.Controls.Add(txtId);
            tabPageUserDetails.Controls.Add(label2);
            tabPageUserDetails.Controls.Add(txtUsername);
            tabPageUserDetails.Location = new Point(4, 34);
            tabPageUserDetails.Name = "tabPageUserDetails";
            tabPageUserDetails.Padding = new Padding(3);
            tabPageUserDetails.Size = new Size(636, 247);
            tabPageUserDetails.TabIndex = 1;
            tabPageUserDetails.Text = "User Details";
            tabPageUserDetails.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(368, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 34);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 334);
            Controls.Add(splitContainer1);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageUserList.ResumeLayout(false);
            tabPageUserDetails.ResumeLayout(false);
            tabPageUserDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CheckBox cbIsAdmin;
        private DataGridView dataGridView1;
        private Label label2;
        private Button btnDelete;
        private TextBox txtUsername;
        private Label label3;
        private SplitContainer splitContainer1;
        private TextBox txtNewPassword;
        private Label label4;
        private Button btnAdd;
        private TextBox txtId;
        private Button btnSave;
        private TabControl tabControl1;
        private TabPage tabPageUserList;
        private TabPage tabPageUserDetails;
        private Button btnEdit;
        private Button btnCancel;
    }
}