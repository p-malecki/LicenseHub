using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Models.Managers;
using LicenseHubApp.Views.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using LicenseHubApp.Models;
using LicenseHubApp.Repositories;


namespace LicenseHubApp.Presenters
{
    internal class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly AuthenticationManager _authenticator;
        private readonly DataContext _dataContext;

        public LoginPresenter(ILoginView view, AuthenticationManager authenticator, DataContext dataContext)
        {
            _view = view;
            _authenticator = authenticator;
            _dataContext = dataContext;

            _view.LoginBtnClicked += OnBtnClicked;
            _view.IncorrectLoginMessage = "";

            // DEBUG skip logging
            _authenticator.Login("admin","1");
            ShowMainView();
        }

        private void OnBtnClicked(object sender, EventArgs e)
        {
            var enteredUsername = _view.Username;
            var enteredPassword = _view.Password;

            try
            {
                _authenticator.Login(enteredUsername, enteredPassword);
                CleanViewFields();
                ShowMainView();
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
        private void ShowMainView()
        {
            var view = (IMainView)MainForm.GetInstance((LoginForm)_view);
            new MainPresenter(view, _authenticator, _dataContext);
        }
    }
}
