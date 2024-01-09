using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Models.Managers;
using LicenseHubApp.Views.Forms;
using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using LicenseHubApp.Repositories;


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
        private EmployeeManager _employeeManager;

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
            IEmployeeRepository employeeRepository = new EmployeeRepository(dataContext);

            _userManager = UserManager.GetInstance(_userRepository);
            _companyManager = CompanyManager.GetInstance(companyRepository, new CustomerNameFilterStrategy());
            _employeeManager = EmployeeManager.GetInstance(employeeRepository, new EmployeeNameFilterStrategy());
        }


        private void OnClientsBtnClicked(object sender, EventArgs e)
        {
            var companyManagementView = new ClientManagementUC();
            new ClientManagementPresenter(companyManagementView, _companyManager, _employeeManager);

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
