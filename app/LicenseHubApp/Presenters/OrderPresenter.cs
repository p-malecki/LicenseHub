using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using LicenseHubApp.Services.Managers;
using LicenseHubApp.Views.Interfaces;


namespace LicenseHubApp.Presenters
{
    public class OrderPresenter
    {
        private readonly IOrderView _view;
        private readonly OrderManager _orderManager;
        private readonly CompanyManager _companyManager;
        private readonly BindingSource _orderBindingSource;

        public OrderPresenter(IOrderView view, OrderManager orderManager, CompanyManager companyManager)
        {
            _view = view;
            _orderManager = orderManager;
            _companyManager = companyManager;

            _orderBindingSource = [];
            view.SetOrderListBindingSource(_orderBindingSource);
            LoadAllOrderList();

            _view.SearchBtnClicked += OnSearchBtnClicked;
            _view.AddBtnClicked += OnAddBtnClicked;
            _view.ShowDetailsBtnClicked += OnShowDetailsBtnClicked;
            _view.EditBtnClicked += OnEditBtnClicked;

            _view.AreCompanyFiltersActive = false;
            _view.AreOrderFiltersActive = false;
        }

        private void LoadAllOrderList()
        {
            var results = _orderManager.GetAll().ToList();

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
                        _companyManager.SetFilterStrategy(new CustomerNameFilterStrategy());
                        companyResultsName = _companyManager.FilterCompany(selectedCompanyName).ToList();
                    }
                    if (!string.IsNullOrWhiteSpace(selectedCompanyNip))
                    {
                        _companyManager.SetFilterStrategy(new CustomerNipFilterStrategy());
                        companyResultsNip = _companyManager.FilterCompany(selectedCompanyNip).ToList();
                    }

                    companyFilterResults = companyResultsName.Intersect(companyResultsNip).ToList();
                }

                if (_view.AreOrderFiltersActive && !string.IsNullOrWhiteSpace(selectedOrderContractNumber))
                {
                    _orderManager.SetFilterStrategy(new OrderContractNumberFilterStrategy());
                    orderFilterResults = _orderManager.FilterOrder(selectedOrderContractNumber).ToList();
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
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void OnAddBtnClicked(object? sender, EventArgs e)
        {
            // TODO add order
        }

        private void OnShowDetailsBtnClicked(object? sender, EventArgs e)
        {
            var model = GetCurrentlySelectedOrder();
            // TODO add order

        }

        private void OnEditBtnClicked(object? sender, EventArgs e)
        {
            var model = GetCurrentlySelectedOrder();
            // TODO add order

        }

    }
}
