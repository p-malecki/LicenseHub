using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Models.Managers;


namespace LicenseHubApp.Presenters
{
    internal class LoginPresenter
    {
        private ILoginView _view;
        private AuthenticationManager _authenticator;

        public LoginPresenter(ILoginView view, AuthenticationManager authenticator)
        {
            _view = view;
            _authenticator = authenticator;

            _view.LoginBtnClicked += OnBtnClicked;
            _view.IncorrectLoginMessage = "";
        }

        private void OnBtnClicked(object sender, EventArgs e)
        {
            var enteredUsername = _view.Username;
            var enteredPassword = _view.Password;

            try
            {
                _authenticator.Login(enteredUsername, enteredPassword);
                _view.IncorrectLoginMessage = "Welcome!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                _view.IncorrectLoginMessage = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            _view.Username = "";
            _view.Password = "";
        }
    }
}
