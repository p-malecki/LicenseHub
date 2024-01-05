﻿using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Models.Managers;
using LicenseHubApp.Views.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using LicenseHubApp.Models;
using LicenseHubApp.Repositories;
using System.Windows.Forms;


namespace LicenseHubApp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView _view;
        private readonly AuthenticationManager _authenticator;
        private readonly DataContext _dataContext;
        private readonly IUserRepository _userRepository;
        private UserManager _userManager;
        private CompanyManager _companyManager;

        public MainPresenter(IMainView view, AuthenticationManager authenticator, DataContext dataContext, IUserRepository userRepository)
        {
            _view = view;
            _authenticator = authenticator;
            _dataContext = dataContext;
            _userRepository = userRepository;
            CreateManagers();

            _view.ClientsBtnClicked += OnClientsBtnClicked;
            _view.LogoutBtnClicked += OnLogoutBtnClicked;
            _view.SettingsBtnClicked += OnSettingsBtnClicked;

            _view.LoggedInUser = _authenticator.GetCurrentlyLoggedUser().Username;
        }

        private void CreateManagers()
        {
            var dataContext = new DataContext();
            ICompanyRepository companyRepository = new CompanyRepository(dataContext);

            _userManager = UserManager.GetInstance(_userRepository);
            _companyManager = CompanyManager.GetInstance(companyRepository);
        }


        private void OnClientsBtnClicked(object sender, EventArgs e)
        {
            var companyManagementView = new CompanyManagementUC();
            new CompanyManagementPresenter(companyManagementView, _companyManager);

            _view.ClientTabPageCollection.Add(companyManagementView);
            companyManagementView.Dock = DockStyle.Fill;
        }

        private void OnLogoutBtnClicked(object sender, EventArgs e)
        {
            _authenticator.Logout();
            var view = (ILoginView)LoginForm.GetInstance((MainForm)_view);
            new LoginPresenter(view, _authenticator, _dataContext, _userRepository);
        }
        private void OnSettingsBtnClicked(object sender, EventArgs e)
        {
            var userManagementForm = new UserManagementForm();
            new UserManagementPresenter(userManagementForm, _userManager);
            userManagementForm.TopLevel = true;
            userManagementForm.Show();
        }
    }
}
