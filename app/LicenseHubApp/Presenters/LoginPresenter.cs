using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Models.ModelManagers;


namespace LicenseHubApp.Presenters
{
    internal class LoginPresenter
    {
        private ILoginView _loginView;
        private AuthenticationManager _authenticator;


        public LoginPresenter(ILoginView view, AuthenticationManager authenticator)
        {
            _loginView = view;
            _authenticator = authenticator;
            _loginView.LoginButtonClicked += OnLoginButtonClicked;

            _loginView.IncorrectLoginMessage = "";
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var enteredUsername = _loginView.Username;
            var enteredPassword = _loginView.Password;

            try
            {
                _authenticator.Login(enteredUsername, enteredPassword);
                _loginView.IncorrectLoginMessage = "Welcome!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                _loginView.IncorrectLoginMessage = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            _loginView.Username = "";
            _loginView.Password = "";
        }
    }
}
