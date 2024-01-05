using LicenseHubApp.Views.Interfaces;

namespace LicenseHubApp.Views.Forms
{
    public partial class LoginForm : Form, ILoginView
    {
        private static LoginForm? _instance;

        #region Constructor
        private LoginForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        public static LoginForm GetInstance(Form? parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new LoginForm();
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }

            if (parentContainer != null)
                parentContainer.Hide();

            _instance.Show();
            return _instance;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += delegate
            {
                LoginBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            txtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    LoginBtnClicked?.Invoke(this, EventArgs.Empty);
            };
        }
        #endregion


        #region Properties
        public string Username
        {
            get => txtUsername.Text;
            set => txtUsername.Text = value.Trim();
        }
        public string Password
        {
            get => txtPassword.Text;
            set => txtPassword.Text = value.Trim();
        }
        public string IncorrectLoginMessage
        {
            get => lbIncorrectLoginMessage.Text;
            set => lbIncorrectLoginMessage.Text = value;
        }
        #endregion



        #region Events
        public event EventHandler LoginBtnClicked;

        #endregion

    }
}
