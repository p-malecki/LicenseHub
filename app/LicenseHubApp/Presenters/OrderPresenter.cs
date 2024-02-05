using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using LicenseHubApp.Services;
using LicenseHubApp.Views.Interfaces;


namespace LicenseHubApp.Presenters
{
    public class OrderPresenter
    {
        private readonly IOrderView _view;
        private readonly IOrderRepository _orderRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly BindingSource _orderBindingSource;
        private readonly EventHandler? _goToOrderCreatorViewChanged;
        private readonly EventHandler<GoToDetailViewEventArgs>? _goToOrderDetailViewChanged;

        public OrderPresenter(IOrderView view, IOrderRepository orderRepository, ICompanyRepository companyRepository, EventHandler? goToOrderCreatorViewChanged, EventHandler<GoToDetailViewEventArgs>? goToOrderDetailViewChanged)
        {
            _view = view;
            _orderRepository = orderRepository;
            _companyRepository = companyRepository;
            _goToOrderCreatorViewChanged = goToOrderCreatorViewChanged;
            _goToOrderDetailViewChanged = goToOrderDetailViewChanged;

            _orderBindingSource = [];
            view.SetOrderListBindingSource(_orderBindingSource);
            LoadAllOrderList();

            _view.SearchBtnClicked += OnSearchBtnClicked;
            _view.AddBtnClicked += OnAddBtnClicked;
            _view.ShowDetailsBtnClicked += OnShowDetailsBtnClicked;

            _view.AreCompanyFiltersActive = false;
            _view.AreOrderFiltersActive = false;
        }

        private void LoadAllOrderList()
        {
            var results = _orderRepository.GetAll().ToList();

            if (results.Count > 0)
            {
                _orderBindingSource.DataSource = results;
                _view.SetViewToSelectable(true);
            }
            else
            {
                _orderBindingSource.DataSource = new List<OrderModel>();
                _view.SetViewToSelectable(false);
            }
        }

        private OrderModel? GetCurrentlySelectedOrder()
        {
            if (_orderBindingSource.Count == 0)
                return null;
            return (OrderModel)_orderBindingSource.Current;
        }

        private void OnSearchBtnClicked(object? sender, EventArgs e)
        {
            try
            {
                if (!_view.AreCompanyFiltersActive & !_view.AreOrderFiltersActive)
                {
                    LoadAllOrderList();
                    _view.IsSuccessful = true;
                    return;
                }

                var selectedCompanyName = _view.CompanySearchCompanyName;
                var selectedCompanyNip = _view.CompanySearchCompanyNip;
                var selectedOrderContractNumber = _view.OrderSearchOrderContractNumber;

                var companyFilterResults = new List<CompanyModel>();
                var orderFilterResults = new List<OrderModel>();
                var filtersResults = new List<OrderModel>();


                if (_view.AreCompanyFiltersActive)
                {
                    var companyResultsName = new List<CompanyModel>();
                    var companyResultsNip = new List<CompanyModel>();

                    if (selectedCompanyName != "all")
                    {
                        _companyRepository.SetFilterStrategy(new CustomerNameFilterStrategy());
                        companyResultsName = _companyRepository.FilterCompany(selectedCompanyName).ToList();
                    }
                    if (!string.IsNullOrWhiteSpace(selectedCompanyNip))
                    {
                        _companyRepository.SetFilterStrategy(new CustomerNipFilterStrategy());
                        companyResultsNip = _companyRepository.FilterCompany(selectedCompanyNip).ToList();
                    }

                    companyFilterResults = companyResultsName.Intersect(companyResultsNip).ToList();
                }

                if (_view.AreOrderFiltersActive && !string.IsNullOrWhiteSpace(selectedOrderContractNumber))
                {
                    _orderRepository.SetFilterStrategy(new OrderContractNumberFilterStrategy());
                    orderFilterResults = _orderRepository.FilterOrder(selectedOrderContractNumber).ToList();
                }

                var companyOrderResults = companyFilterResults.SelectMany(m => m.Orders).ToList();
                filtersResults = orderFilterResults.Intersect(companyOrderResults).ToList();

                if (filtersResults.Count > 0)
                {
                    _orderBindingSource.DataSource = filtersResults;
                    _view.SetViewToSelectable(true);
                }
                else
                {
                    _orderBindingSource.DataSource = new List<OrderModel>();
                    _view.SetViewToSelectable(false);
                }

                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void OnAddBtnClicked(object? sender, EventArgs e)
        {
            _goToOrderCreatorViewChanged?.Invoke(this, EventArgs.Empty);
        }

        private void OnShowDetailsBtnClicked(object? sender, EventArgs e)
        {
            var order = GetCurrentlySelectedOrder();
            if (order != null)
            {
                _goToOrderCreatorViewChanged?.Invoke(this, new GoToDetailViewEventArgs() { Order = order });
            }
        }

    }
}
