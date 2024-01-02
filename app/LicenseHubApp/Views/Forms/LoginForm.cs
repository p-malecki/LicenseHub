using LicenseHubApp.Views.Interfaces;

namespace LicenseHubApp.Views.Forms
{
    public partial class LoginForm : Form, ILoginView
    {
        // Constructor
        public LoginForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += delegate
            {
                LoginBtnClicked?.Invoke(this, EventArgs.Empty);
            };
        }

        // Properties
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

        // Events
        public event EventHandler LoginBtnClicked;

    }
}
