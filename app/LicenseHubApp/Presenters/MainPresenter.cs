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
        private OrderManager _orderManager;
        private ProductManager _productManager;

        private event EventHandler GoToClientViewChanged;
        private event EventHandler GoToOrderViewChanged;
        private event EventHandler<GoToDetailViewEventArgs>? GoToEmployeeDetailViewChanged;
        private event EventHandler<GoToDetailViewEventArgs>? GoToWorkstationDetailViewChanged;
        private event EventHandler<GoToDetailViewEventArgs>? GoToOrderDetailViewChanged;
        private event EventHandler<GoToDetailViewEventArgs>? GoToWorkstationProductDetailViewChanged;


        public MainPresenter(IMainView view, AuthenticationManager authenticator, DataContext dataContext, IUserRepository userRepository)
        {
            _view = view;
            _authenticator = authenticator;
            _dataContext = dataContext;
            _userRepository = userRepository;
            CreateManagers();

            _view.ClientsBtnClicked += OnClientsBtnClicked;
            _view.OrdersBtnClicked += OnOrdersBtnClicked;
            _view.ProductsBtnClicked += OnProductsBtnClicked;
            _view.LogoutBtnClicked += OnLogoutBtnClicked;
            _view.SettingsBtnClicked += OnSettingsBtnClicked;

            GoToClientViewChanged += OnClientsBtnClicked;
            GoToOrderViewChanged += OnOrdersBtnClicked;
            GoToEmployeeDetailViewChanged += OnGoToEmployeeEmployeeDetailViewChanged;
            GoToWorkstationDetailViewChanged += OnGoToWorkstationDetailViewChanged;
            GoToWorkstationProductDetailViewChanged += OnGoToWorkstationProductDetailViewChanged;
            GoToOrderDetailViewChanged += OnGoToOrderDetailViewChanged;

            _view.LoggedInUser = _authenticator.GetCurrentlyLoggedUser()!.Username ?? throw new AuthenticationException("No logged-in user.");
        }

        private void CreateManagers()
        {
            var dataContext = new DataContext();
            ICompanyRepository companyRepository = new CompanyRepository(dataContext);
            IEmployeeRepository employeeRepository = new EmployeeRepository(dataContext);
            IWorkstationRepository workstationProductRepository = new WorkstationRepository(dataContext);
            IOrderRepository orderRepository = new OrderRepository(dataContext);
            IProductRepository productRepository = new ProductRepository(dataContext);
            IProductReleaseModelRepository releaseProductRepository = new ProductReleaseModelRepository(dataContext);

            _userManager = UserManager.GetInstance(_userRepository);
            _companyManager = CompanyManager.GetInstance(companyRepository, new CustomerNameFilterStrategy());
            _employeeManager = EmployeeManager.GetInstance(employeeRepository, new EmployeeNameFilterStrategy());
            _workstationManager = WorkstationManager.GetInstance(workstationProductRepository, new WorkstationComputerNameFilterStrategy());
            _orderManager = OrderManager.GetInstance(orderRepository, new OrderContractNumberFilterStrategy());
            _productManager = ProductManager.GetInstance(productRepository, releaseProductRepository);
        }


        private void OnClientsBtnClicked(object? sender, EventArgs e)
        {
            var clientView = new ClientView();
            _ = new ClientPresenter(clientView, _companyManager, _employeeManager, _workstationManager, GoToEmployeeDetailViewChanged, GoToWorkstationDetailViewChanged);

            _view.ClientTabPageCollection.Clear();
            _view.ClientTabPageCollection.Add(clientView);
            clientView.Dock = DockStyle.Fill;
        }

        private void OnOrdersBtnClicked(object? sender, EventArgs e)
        {
            var orderView = new OrderView();
            _ = new OrderPresenter(orderView, _orderManager, _companyManager);

            _view.OrderTabPageCollection.Add(orderView);
            orderView.Dock = DockStyle.Fill;
        }

        private void OnProductsBtnClicked(object? sender, EventArgs e)
        {
            var productView = new ProductView();
            _ = new ProductPresenter(productView, _productManager);

            _view.ProductTabPageCollection.Add(productView);
            productView.Dock = DockStyle.Fill;
        }

        private void OnLogoutBtnClicked(object? sender, EventArgs e)
        {
            _authenticator.Logout();
            var view = (ILoginView)LoginFormView.GetInstance((MainFormView)_view);
            _ = new LoginPresenter(view, _authenticator, _dataContext, _userRepository);
        }
        private void OnSettingsBtnClicked(object? sender, EventArgs e)
        {
            var userManagementForm = new UserManagementFormView();
            _ = new UserManagementPresenter(userManagementForm, _userManager);
            userManagementForm.TopLevel = true;
            userManagementForm.Show();
        }

        private void OnGoToEmployeeEmployeeDetailViewChanged(object? sender, GoToDetailViewEventArgs e)
        {
            var employee = e.Employee!;
            var employeeDetailView = new EmployeeDetailView();
            _ = new EmployeeDetailPresenter(employeeDetailView, employee, _employeeManager, GoToWorkstationDetailViewChanged, GoToClientViewChanged);

            _view.ClientTabPageCollection.Clear();
            _view.ClientTabPageCollection.Add(employeeDetailView);
            employeeDetailView.Dock = DockStyle.Fill;
        }
        private void OnGoToWorkstationDetailViewChanged(object? sender, GoToDetailViewEventArgs e)
        {
            var workstation = e.Workstation!;
            var workstationDetailView = new WorkstationDetailView();
            _ = new WorkstationDetailPresenter(workstationDetailView, workstation, _workstationManager, GoToEmployeeDetailViewChanged, GoToWorkstationDetailViewChanged, GoToClientViewChanged);

            _view.ClientTabPageCollection.Clear();
            _view.ClientTabPageCollection.Add(workstationDetailView);
            workstationDetailView.Dock = DockStyle.Fill;
        }
        private void OnGoToOrderDetailViewChanged(object? sender, GoToDetailViewEventArgs e)
        {
            var order = e.Order!;
            var orderDetailView = new OrderDetailView();
            _ = new OrderDetailPresenter(orderDetailView, order, _orderManager, GoToWorkstationDetailViewChanged, GoToOrderViewChanged);

            _view.OrderTabPageCollection.Clear();
            _view.OrderTabPageCollection.Add(orderDetailView);
            orderDetailView.Dock = DockStyle.Fill;
        }
        private void OnGoToWorkstationProductDetailViewChanged(object? sender, GoToDetailViewEventArgs e)
        {
            var workstationProduct = e.WorkstationProduct!;
            var workstationProductDetailView = new WorkstationProductDetailView();
            _ = new WorkstationProductDetailPresenter(workstationProductDetailView, workstationProduct, GoToClientViewChanged);

            _view.ClientTabPageCollection.Clear();
            _view.ClientTabPageCollection.Add(workstationProductDetailView);
            workstationProductDetailView.Dock = DockStyle.Fill;
        }
    }
}
