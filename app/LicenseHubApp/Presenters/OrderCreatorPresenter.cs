using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Windows.Forms;
using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using LicenseHubApp.Repositories;
using LicenseHubApp.Services;
using LicenseHubApp.Views.Interfaces;


namespace LicenseHubApp.Presenters
{
    public class OrderCreatorPresenter
    {
        private readonly IOrderCreatorView _view;
        private readonly IOrderRepository _orderRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IProductRepository _productRepository;
        private readonly IWorkstationProductRepository _workstationProductRepository;
        private readonly ILicenseRepository _licenseRepository;
        private List<CompanyModel> _companyList;
        private List<ProductModel> _productList;
        private List<ProductReleaseModel> _productReleaseList;
        private List<WorkstationProductModel> _workstationProductList;
        private readonly BindingSource _workstationProductBindingSource;
        private readonly WorkstationProductBuilder _workstationProductBuilder;
        private readonly OrderBuilder _orderBuilder;
        private readonly EventHandler? _goToOrderViewChanged;

        public OrderCreatorPresenter(
            IOrderCreatorView view,
            IOrderRepository orderRepository,
            ICompanyRepository companyRepository,
            IProductRepository productRepository,
            IWorkstationProductRepository workstationProductRepository,
            ILicenseRepository licenseRepository,
            EventHandler closeCreatorViewClicked
            )
        {
            _view = view;
            _orderRepository = orderRepository;
            _companyRepository = companyRepository;
            _productRepository = productRepository;
            _workstationProductRepository = workstationProductRepository;
            _licenseRepository = licenseRepository;
            _workstationProductBuilder = new WorkstationProductBuilder();
            _orderBuilder = new OrderBuilder();

            _companyList = [];
            _productList = [];
            _productReleaseList = [];
            _workstationProductList = [];
            _workstationProductBindingSource = [];
            LoadCompanies();
            LoadProducts();
            LoadProductReleases();
            _view.SetLicenseTypeListBindingSource(["PerpetualLicense", "SubscriptionLicense"]); // TODO refactor license types
            _view.SetWorkstationProductListBindingSource(_workstationProductBindingSource);

            _view.ProductSelectedChanged += OnProductSelectedChanged;
            _view.ProductAddBtnClicked += OnAddBtnClicked;
            _view.ProductRemoveBtnClicked += OnProductRemoveBtnClicked;
            _view.LicenseRegisterBtnClicked += OnLicenseRegisterBtnClicked;
            _view.LicenseActivateBtnClicked += OnLicenseActivateBtnClicked;
            _view.OrderAddBtnClicked += OnOrderAddBtnClicked;

            _view.OrderIsCompanyNameSelected = true;
            _view.SetProductToSelectable(false);

            _goToOrderViewChanged = closeCreatorViewClicked;
            _view.OrderCancelBtnClicked += delegate
            {
                closeCreatorViewClicked.Invoke(this, EventArgs.Empty);
            };

        }

        private void LoadCompanies()
        {
            _companyList = _companyRepository.GetAll().ToList();
            _view.SetCompanyNameList(_companyList);
        }

        private void LoadProducts()
        {
            _productList = _productRepository.GetAll().ToList();
            _view.SetProductNameList(_productList);
            _view.SetProductAddBtnState(_productList.Count > 0);
        }

        private void LoadProductReleases()
        {
            if (_productList.Count == 0) return;
            var productListIndex = _view.ProductSelected;
            var selectedProduct = _productList[productListIndex];
            _productReleaseList = selectedProduct.Releases.ToList();
            _view.SetProductReleaseNameList(_productReleaseList);
            _view.SetProductAddBtnState(_productReleaseList?.Count > 0);
        }

        private CompanyModel? GetCurrentlySelectedCompany()
        {
            if (_view.OrderIsCompanyNameSelected)
            {
                _companyRepository.SetFilterStrategy(new CustomerNameFilterStrategy());
                var companyName = _view.OrderCompanySelected;
                return _companyRepository.FilterCompany(companyName).FirstOrDefault();
            }
            else
            {
                _companyRepository.SetFilterStrategy(new CustomerNipFilterStrategy());
                var companyNip = _view.OrderCompanySelected;
                return _companyRepository.FilterCompany(companyNip).FirstOrDefault();
            }
        }

        private WorkstationProductModel? GetCurrentlySelectedWorkstationProduct()
        {
            if (_workstationProductBindingSource.Count == 0) return null;

            if (_workstationProductBindingSource.Current is DataRowView drv)
            {
                var id = drv.Row.Table.Rows.IndexOf(drv.Row);
                return _workstationProductList[id];
            }
            return null;
        }

        private void OnProductSelectedChanged(object? sender, EventArgs e)
        {
            LoadProductReleases();
        }

        private void OnAddBtnClicked(object? sender, EventArgs e)
        {
            var releaseListIndex = _view.ProductReleaseSelected;
            var selectedRelease = _productReleaseList[releaseListIndex];
            _workstationProductBuilder.Reset();
            _workstationProductBuilder.AddRelease(selectedRelease);
            
            switch (_view.LicenseTypeSelected)
            {
                case "PerpetualLicense":
                    _workstationProductBuilder.AddPerpetualLicense();
                    break;
                case "SubscriptionLicense":
                    _workstationProductBuilder.AddSubscriptionLicense(_view.LicenseLeaseTermInDays);
                    break;
            }

            _orderBuilder.AddWorkstationProduct(_workstationProductBuilder.GetProduct(), _view.ProductQuantity);

            _workstationProductList = _orderBuilder.GetAllWorkstationProducts();
            var dt = MakeOrderProductDataTable(_workstationProductList);
            _workstationProductBindingSource.DataSource = dt;

            _view.SetProductToSelectable(true);
            _view.SetOrderAddBtnState(true);
        }

        private void OnProductRemoveBtnClicked(object? sender, EventArgs e)
        {
            var selectedWorkstationProduct = GetCurrentlySelectedWorkstationProduct();
            if (selectedWorkstationProduct == null) return;

            _workstationProductList.Remove(selectedWorkstationProduct);
            _orderBuilder.RemoveWorkstationProduct(selectedWorkstationProduct);
            var dt = MakeOrderProductDataTable(_workstationProductList);
            _workstationProductBindingSource.DataSource = dt;

            if (_workstationProductList.Count == 0)
            {
                _view.SetProductToSelectable(false);
                _view.SetOrderAddBtnState(false);
            }
        }

        private void OnLicenseRegisterBtnClicked(object? sender, EventArgs e)
        {
            var selectedWorkstationProduct = GetCurrentlySelectedWorkstationProduct();
            if (selectedWorkstationProduct == null) return;

            //selectedWorkstationProduct.License.Register();
            // TODO Register

            throw new NotImplementedException();
        }
        private void OnLicenseActivateBtnClicked(object? sender, EventArgs e)
        {
            var selectedWorkstationProduct = GetCurrentlySelectedWorkstationProduct();
            if (selectedWorkstationProduct == null) return;

            // selectedWorkstationProduct.License.ActivateWithSimpleActivationCode();
            // TODO ActivateWithSimpleActivationCode or with gen

            throw new NotImplementedException();
        }

        private async void OnOrderAddBtnClicked(object? sender, EventArgs e)
        {
            var company = GetCurrentlySelectedCompany();
            var contractNumber = _view.OrderContractNumber;
            if (company == null || string.IsNullOrWhiteSpace(contractNumber))
            {
                _view.IsSuccessful = false;
                _view.Message = "Set correct order data.";
                return;
            }

            _orderBuilder.SetCompanyData(company);
            _orderBuilder.SetOrderData(contractNumber, _view.DateOfOrder, _view.DateOfPayment, _view.Description);

            try
            {
                var orderModel = _orderBuilder.GetProduct();
                foreach (var workstationProduct in orderModel.WorkstationProducts)
                {
                    if (workstationProduct.License != null)
                    {
                        await _licenseRepository.Create(workstationProduct.License);
                    }
                    await _workstationProductRepository.Create(workstationProduct);
                }

                await _orderRepository.Create(orderModel);
                _view.Message = "Order has been added.";
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }

            _goToOrderViewChanged?.Invoke(this, EventArgs.Empty);
        }

        private static DataTable MakeOrderProductDataTable(List<WorkstationProductModel> workstationProducts)
        {
            var table = new DataTable();

            var column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Product",
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Release",
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "License",
            };
            table.Columns.Add(column);

            foreach (var wp in workstationProducts)
            {
                var row = table.NewRow();
                row["Product"] = wp.ProductRelease?.Product.Name ?? "";
                row["Release"] = wp.ProductRelease?.ReleaseNumber ?? "";
                row["License"] = wp.License switch
                {
                    PerpetualLicenseModel => "Perpetual",
                    SubscriptionLicenseModel => "Subscription",
                    _ => "other"
                };
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
