namespace LicenseHubApp.Views.Forms
{
    partial class LoginForm
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
            btnLogin = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            lbIncorrectLoginMessage = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(137, 311);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 43);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(45, 51);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(45, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(332, 31);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(45, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(332, 31);
            txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 159);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // lbIncorrectLoginMessage
            // 
            lbIncorrectLoginMessage.AutoSize = true;
            lbIncorrectLoginMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbIncorrectLoginMessage.ForeColor = Color.DarkRed;
            lbIncorrectLoginMessage.Location = new Point(45, 243);
            lbIncorrectLoginMessage.Name = "lbIncorrectLoginMessage";
            lbIncorrectLoginMessage.Size = new Size(209, 25);
            lbIncorrectLoginMessage.TabIndex = 1;
            lbIncorrectLoginMessage.Text = "incorrectLoginMessage";
            lbIncorrectLoginMessage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 411);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(lbIncorrectLoginMessage);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label lbIncorrectLoginMessage;
    }
}