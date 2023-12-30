using LicenseHubApp.Views.Interfaces;

namespace LicenseHubApp.Views.Forms
{
    public partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += delegate
            {
                LoginButtonClicked?.Invoke(this, EventArgs.Empty);
            };
        }

        public string Username
        {
            get => txtUsername.Text;
            set => txtUsername.Text = value;
        }
        public string Password
        {
            get => txtPassword.Text;
            set => txtPassword.Text = value;
        }
        public string IncorrectLoginMessage
        { 
            get => lbIncorrectLoginMessage.Text; 
            set => lbIncorrectLoginMessage.Text = value;
        }

        public event EventHandler LoginButtonClicked;

        //public void ShowMessage(string message)
        //{
        //    MessageBox.Show(message);
        //}
    }
}
