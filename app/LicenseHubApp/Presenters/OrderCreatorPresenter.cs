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
        private readonly BindingSource _workstationProductBindingSource;
        private readonly WorkstationProductBuilder _workstationProductBuilder;
        private readonly OrderBuilder _orderBuilder;

        public OrderCreatorPresenter(IOrderCreatorView view, IOrderRepository orderRepository, ICompanyRepository companyRepository, IProductRepository productRepository, EventHandler closeCreatorViewClicked)
        {
            _view = view;
            _orderRepository = orderRepository;
            _companyRepository = companyRepository;
            _productRepository = productRepository;
            _workstationProductBuilder = new WorkstationProductBuilder();
            _orderBuilder = new OrderBuilder();

            LoadCompanies();
            LoadProducts();
            LoadProductReleases();
            _view.SetLicenseTypeListBindingSource(["PerpetualLicense", "SubscriptionLicense"]); // TODO refactor license types
            _workstationProductBindingSource = [];
            _view.SetWorkstationProductListBindingSource(_workstationProductBindingSource);

            _view.ProductAddBtnClicked += OnProductAddBtnClicked;
            _view.ProductRemoveBtnClicked += OnProductRemoveBtnClicked;
            _view.LicenseRegisterBtnClicked += OnLicenseRegisterBtnClicked;
            _view.LicenseActivateBtnClicked += OnLicenseActivateBtnClicked;
            _view.OrderAddBtnClicked += OnOrderAddBtnClicked;

            _view.OrderIsCompanyNameSelected = true;
            _view.SetProductToSelectable(false);

            _view.OrderCancelBtnClicked += delegate
            {
                closeCreatorViewClicked.Invoke(this, EventArgs.Empty);
            };
        }

        private void LoadCompanies()
        {
            var models = _companyRepository.GetAll();
            var names = models.Select(m => m.Name).ToList();
            _view.SetCompanyListBindingSource(new BindingSource() { DataSource = names });
        }

        private void LoadProducts()
        {
            var models = _productRepository.GetAll();
            var names = models.Select(m => m.Name).ToList();
            _view.SetProductListBindingSource(new BindingSource() { DataSource = names });
        }

        private void LoadProductReleases()
        {
            var productId = _view.ProductSelected;
            var selectedProduct = _productRepository.GetById(productId).Result;

            if (selectedProduct == null) return;
            var names = selectedProduct.Releases.Select(m => m.ReleaseNumber).ToList();
            _view.SetProductReleaseListBindingSource(new BindingSource() { DataSource = names });
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
            if (_workstationProductBindingSource.Count == 0)
            {
                _view.SetProductToSelectable(false);
                return null;
            }

            _view.SetProductToSelectable(true);
            return (WorkstationProductModel)_workstationProductBindingSource.Current;
        }


        private void OnProductAddBtnClicked(object? sender, EventArgs e)
        {
            var productId = _view.ProductSelected;
            var releaseId = _view.ProductReleaseSelected;
            var selectedRelease = _productRepository.GetById(productId).Result?.Releases.ToList()[releaseId];

            if (selectedRelease == null) return;
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

            _orderBuilder.AddWorkstationProduct(_workstationProductBuilder.GetProduct());
            _workstationProductBindingSource.DataSource = _orderBuilder.GetAllWorkstationProducts();
        }

        private void OnProductRemoveBtnClicked(object? sender, EventArgs e)
        {
            var selectedWorkstationProduct = GetCurrentlySelectedWorkstationProduct();
            if (selectedWorkstationProduct == null) return;

            _orderBuilder.RemoveWorkstationProduct(selectedWorkstationProduct);
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

        private void OnOrderAddBtnClicked(object? sender, EventArgs e)
        {
            var company = GetCurrentlySelectedCompany();
            var contractNumber = _view.OrderContractNumber;
            if (company == null || string.IsNullOrWhiteSpace(contractNumber)) return;

            _orderBuilder.SetCompanyData(company);
            _orderBuilder.SetOrderData(contractNumber, _view.DateOfOrder, _view.DateOfPayment, _view.Description);
            // TODO add date validation in order creation

            var newOrder = _orderBuilder.GetProduct();
            _orderRepository.Create(newOrder);
        }

    }
}
