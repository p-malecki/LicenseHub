using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Models.Managers;
using LicenseHubApp.Views.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace LicenseHubApp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView _view;
        private readonly AuthenticationManager _authenticator;
        private readonly UserManager _userManager;

        public MainPresenter(IMainView view, AuthenticationManager authenticator, UserManager userManager)
        {
            _view = view;
            _authenticator = authenticator;
            _userManager = userManager;

            _view.LogoutBtnClicked += OnLogoutBtnClicked;

            _view.LoggedInUser = _authenticator.GetCurrentlyLoggedUser().Username;
        }

        private void OnLogoutBtnClicked(object sender, EventArgs e)
        {
            _authenticator.Logout();
            var view = (ILoginView)LoginForm.GetInstance((MainForm)_view);
            new LoginPresenter(view, _authenticator, _userManager);
        }
    }
}
