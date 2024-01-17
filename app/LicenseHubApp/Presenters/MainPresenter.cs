using System.Security.Authentication;
using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Views.Forms;
using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using LicenseHubApp.Repositories;
using LicenseHubApp.Services.Managers;


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
        private WorkstationManager _workstationManager;
        private ProductManager _productManager;

        private event EventHandler GoToEmployeeDetailViewChanged;
        private event EventHandler GoToWorkstationDetailViewChanged;


        public MainPresenter(IMainView view, AuthenticationManager authenticator, DataContext dataContext, IUserRepository userRepository)
        {
            _view = view;
            _authenticator = authenticator;
            _dataContext = dataContext;
            _userRepository = userRepository;
            CreateManagers();

            _view.ClientsBtnClicked += OnClientsBtnClicked;
            _view.ProductsBtnClicked += OnProductsBtnClicked;
            _view.LogoutBtnClicked += OnLogoutBtnClicked;
            _view.SettingsBtnClicked += OnSettingsBtnClicked;
            GoToEmployeeDetailViewChanged += OnGoToEmployeeEmployeeDetailViewChanged;
            GoToWorkstationDetailViewChanged += OnGoToWorkstationDetailViewChanged;


            _view.LoggedInUser = _authenticator.GetCurrentlyLoggedUser()!.Username ?? throw new AuthenticationException("No logged-in user.");
        }

        private void CreateManagers()
        {
            var dataContext = new DataContext();
            ICompanyRepository companyRepository = new CompanyRepository(dataContext);
            IEmployeeRepository employeeRepository = new EmployeeRepository(dataContext);
            IWorkstationRepository workstationRepository = new WorkstationRepository(dataContext);
            IProductRepository productRepository = new ProductRepository(dataContext);
            IProductReleaseModelRepository releaseProductRepository = new ProductReleaseModelRepository(dataContext);

            _userManager = UserManager.GetInstance(_userRepository);
            _companyManager = CompanyManager.GetInstance(companyRepository, new CustomerNameFilterStrategy());
            _employeeManager = EmployeeManager.GetInstance(employeeRepository, new EmployeeNameFilterStrategy());
            _workstationManager = WorkstationManager.GetInstance(workstationRepository, new WorkstationComputerNameFilterStrategy());
            _productManager = ProductManager.GetInstance(productRepository, releaseProductRepository);
        }


        private void OnClientsBtnClicked(object? sender, EventArgs e)
        {
            var companyManagementView = new ClientManagementUC();
            _ = new ClientManagementPresenter(companyManagementView, _companyManager, _employeeManager, _workstationManager, GoToEmployeeDetailViewChanged, GoToWorkstationDetailViewChanged);

            _view.ClientTabPageCollection.Add(companyManagementView);
            companyManagementView.Dock = DockStyle.Fill;
        }

        private void OnProductsBtnClicked(object? sender, EventArgs e)
        {
            var productManagementView = new ProductManagementUC();
            _ = new ProductManagementPresenter(productManagementView, _productManager);

            _view.ProductTabPageCollection.Add(productManagementView);
            productManagementView.Dock = DockStyle.Fill;
        }

        private void OnLogoutBtnClicked(object? sender, EventArgs e)
        {
            _authenticator.Logout();
            var view = (ILoginView)LoginForm.GetInstance((MainForm)_view);
            _ = new LoginPresenter(view, _authenticator, _dataContext, _userRepository);
        }
        private void OnSettingsBtnClicked(object? sender, EventArgs e)
        {
            var userManagementForm = new UserManagementForm();
            _ = new UserManagementPresenter(userManagementForm, _userManager);
            userManagementForm.TopLevel = true;
            userManagementForm.Show();
        }

        private void OnGoToEmployeeEmployeeDetailViewChanged(object? sender, EventArgs e)
        {
            // TODO launch Employee detail view
            _view.ClientTabPageCollection.Clear();
        }
        private void OnGoToWorkstationDetailViewChanged(object? sender, EventArgs e)
        {
            // TODO launch Workstation detail view
            _view.ClientTabPageCollection.Clear();
        }   
    }
}
