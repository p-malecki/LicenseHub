using LicenseHubApp.Models.Filters;
using LicenseHubApp.Models;
using LicenseHubApp.Services.Managers;
using LicenseHubApp.Utils;
using LicenseHubApp.Views.Interfaces;


namespace LicenseHubApp.Presenters
{
    public class ProductManagementPresenter
    {
        private readonly IProductManagementView _view;
        private readonly ProductManager _productManager;
        private readonly BindingSource _productBindingSource;

        public ProductManagementPresenter(IProductManagementView view, ProductManager productManager
        )
        {
            _view = view;
            _productManager = productManager;

            _productBindingSource = new BindingSource();
            view.SetBindingSource(_productBindingSource);

            //_view.CloseRightPanelBtnClicked += OnCloseRightPanelBtnClicked;

            //LoadAllCompanyList();
        }
    }
}
