using System.Globalization;
using LicenseHubApp.Models;
using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Services.Managers;
using System.Reflection;


namespace LicenseHubApp.Presenters
{
    public class WorkstationProductDetailPresenter
    {
        private readonly IWorkstationProductDetailView _view;
        private readonly WorkstationProductModel _workstationProduct;
        private readonly BindingSource _employeeBindingSource;
        private readonly EventHandler _closeDetailViewClicked;


        public WorkstationProductDetailPresenter(
            IWorkstationProductDetailView view,
            WorkstationProductModel workstationProduct,
            EventHandler closeDetailViewClicked
        )
        {
            _view = view;
            _workstationProduct = workstationProduct;
            _closeDetailViewClicked = closeDetailViewClicked;

            ShowModel();

            _employeeBindingSource = [];
            _view.SetEmployeeListBindingSource(_employeeBindingSource);
            LoadEmployeeList();

            _view.CloseDetailViewBtnClicked += delegate
            {
                _closeDetailViewClicked.Invoke(this, EventArgs.Empty);
            };
        }

        private void ShowModel()
        {
            var licenseType = _workstationProduct.License.GetType().Name;
            var isActivationCodeGenerated = (_workstationProduct.License.ActivationCode?.GetType().Name ?? "") == "GeneratedActivationCodeModel";
            var leaseInDays = (_workstationProduct.License as SubscriptionLicenseModel)?.LeaseTermInDays ?? 0;


            var endOfLicensePeriodDate = _workstationProduct.License.ActivationDate?.AddDays(leaseInDays) ?? DateTime.Now;


            _view.CompanyName = _workstationProduct.Order?.Company.Name ?? "";
            _view.OrderContractNumber = _workstationProduct.Order?.ContractNumber ?? "";
            _view.OrderDateOfOrder = _workstationProduct.Order?.DateOfOrder.ToString(CultureInfo.InvariantCulture) ?? "";
            _view.NumberOfUsers = _workstationProduct.Workstation?.Employees.Count.ToString();
            _view.ProductName = _workstationProduct.ProductRelease.Product.Name;
            _view.ProductNewestRelease = _workstationProduct.ProductRelease.Product.Releases.ToList().Last().Product.Name;
            _view.ProductDescription = _workstationProduct.ProductRelease.Product.Description;
            _view.ReleaseNumber = _workstationProduct.ProductRelease.ReleaseNumber;
            _view.ReleaseInstallerVerificationPasscode = _workstationProduct.ProductRelease.InstallerVerificationPasscode;
            _view.ReleaseDescription = _workstationProduct.ProductRelease.Description;
            _view.LicenseType = licenseType;
            _view.LicenseRegisterDate = _workstationProduct.License.RegisterDate ?? DateTime.Now; // TODO turn off RegisterDate when not set 
            _view.LicenseLeaseInDays = leaseInDays;
            _view.LicenseActivationCode = _workstationProduct.License.ActivationCode?.Code ?? "";
            _view.LicenseIsActivationCodeGenerated = isActivationCodeGenerated;
            _view.LicenseActivationCodeGenVersion = isActivationCodeGenerated ? (_workstationProduct.License.ActivationCode as GeneratedActivationCodeModel)?.CodeGeneratorVersion ?? "": "";
            _view.LicenseActivationDate = _workstationProduct.License.ActivationDate ?? DateTime.Now;
            _view.LicenseEndOfLicensePeriodDate = endOfLicensePeriodDate;
        }

        private void LoadEmployeeList()
        {
            var employeeList = _workstationProduct.Workstation?.Employees.ToList();
            _employeeBindingSource.DataSource = employeeList is { Count: > 0 } ? employeeList : [];
        }

    }
}
