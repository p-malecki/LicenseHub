﻿using LicenseHubApp.Models.Filters;
using LicenseHubApp.Models;
using LicenseHubApp.Services.Managers;
using LicenseHubApp.Utils;
using LicenseHubApp.Views.Interfaces;
using System.ComponentModel.Design;


namespace LicenseHubApp.Presenters
{
    public class ProductManagementPresenter
    {
        private readonly IProductManagementView _view;
        private readonly ProductManager _productManager;
        private readonly BindingSource _productBindingSource;
        private readonly BindingSource _releaseBindingSource;

        public ProductManagementPresenter(IProductManagementView view, ProductManager productManager
        )
        {
            _view = view;
            _productManager = productManager;

            _productBindingSource = new BindingSource();
            _releaseBindingSource = new BindingSource();
            view.SetProductListBindingSource(_productBindingSource);
            view.SetReleaseDataBindingSource(_releaseBindingSource);

            _productBindingSource.CurrentChanged += OnProductSelectionChanged;
            _view.ProductAddBtnClicked += OnProductAddBtnClicked;
            _view.ProductIsAvailableToggled += OnProductIsAvailableChbToggled;
            _view.ProductRenameBtnClicked += OnProductRenameBtnClicked;
            _view.ProductSaveBtnClicked += OnProductSaveBtnClicked;
            _view.ProductRemoveBtnClicked += OnProductRemoveBtnClicked;
            _view.ReleaseSelectionChanged += OnReleaseSelectionChanged;
            _view.ReleaseAddBtnClicked += OnReleaseAddBtnClicked;
            _view.ReleaseRemoveBtnClicked += OnReleaseRemoveBtnClicked;
            _view.ReleaseSaveBtnClicked += OnReleaseSaveBtnClicked;

            LoadAllProductList();
        }

        private void LoadAllProductList()
        {
            var tmpIsEdit = _view.IsEdit;

            var results = _productManager.GetAll().ToList();

            if (results.Count > 0)
            {
                var productNames = results.Select(x => x.Name).ToList(); // TODO (?) if not available add x to string

                productNames.Sort();
                _productBindingSource.DataSource = productNames;
            }
            else
            {
                _productBindingSource.DataSource = new List<string>();
                _view.SetProductViewToSelectable(false);
            }

            _view.IsEdit = tmpIsEdit;
        }
        private void LoadAllReleaseList()
        {
            var tmpIsEdit = _view.IsEdit;

            var results = _productManager.GetAllRelease().ToList();
            results = results.Where(m => m.ProductId == _view.ProductId).ToList();

            if (results.Count > 0)
            {
                results.Sort();
                results.Reverse();
                _view.ProductNewestRelease = results[0].ReleaseNumber;
                _releaseBindingSource.DataSource = results;
            }
            else
            {
                _releaseBindingSource.DataSource = new List<ProductReleaseModel>();
                _view.ProductNewestRelease = "-";
                _view.SetReleaseViewToEditable(false);
                _view.SetReleaseViewToSelectable(false);
            }

            _view.IsEdit = tmpIsEdit;
        }

        private ProductModel? GetCurrentlySelectedProduct()
        {
            if (_productBindingSource.Count == 0)
                return null;
            var productName = (string)_productBindingSource.Current;

            var model = _productManager.GetAll().First(m => m.Name == productName);

            return model;
        }
        private ProductReleaseModel? GetCurrentlySelectedRelease()
        {
            if (_releaseBindingSource.Count == 0)
                return null;

            return (ProductReleaseModel)_releaseBindingSource.Current;
        }

        private void ShowProduct(ProductModel model)
        {
            _view.SetProductViewToSelectable(true);
            _view.ProductId = model.Id;
            _view.ProductIsAvailable = model.IsAvailable;
            _view.ProductName = model.Name;

            LoadAllReleaseList(); // loads productNewestRelease stat

            _view.ProductNumberOfLicensesGranted = "0"; // TODO set product LicensesGranted stats
            _view.ProductActiveClientBaseNumber = "0"; // TODO set product ActiveClientBaseNumber stats

            _view.IsSuccessful = true;
        }
        private void ShowCurrentlySelectedProduct()
        {
            var model = GetCurrentlySelectedProduct();
            if (model == null)
            {
                CleanProductViewFields();
                CleanReleaseViewFields();
                _view.SetProductViewToSelectable(false);
                _view.IsSuccessful = true;
                return;
            }

            ShowProduct(model);
        }
        private void ShowRelease(ProductReleaseModel model)
        {
            _view.SetReleaseViewToSelectable(true);
            _view.ReleaseId = model.Id;
            _view.ReleaseNumber = model.ReleaseNumber;
            _view.ReleaseInstallerVerificationPasscode = model.InstallerVerificationPasscode;
            _view.ReleaseDescription = model.Description;

            _view.IsSuccessful = true;
        }
        private void ShowCurrentlySelectedRelease()
        {
            var model = GetCurrentlySelectedRelease();
            if (model == null)
            {
                CleanReleaseViewFields();
                _view.SetReleaseViewToSelectable(false);
                _view.IsSuccessful = true;
                return;
            }

            ShowRelease(model);
        }

        private void CleanProductViewFields()
        {
            _view.ProductId = -1;
            _view.ProductName = "";
            _view.ProductIsAvailable = true;
            _view.ProductNewestRelease = "-";
            _view.ProductNumberOfLicensesGranted = "-";
            _view.ProductActiveClientBaseNumber = "-";
        }

        private void CleanReleaseViewFields()
        {
            _view.ReleaseNumber = "";
            _view.ReleaseInstallerVerificationPasscode = "";
            _view.ReleaseDescription = "";
        }


        private void OnProductSelectionChanged(object? sender, EventArgs e)
        {
            ShowCurrentlySelectedProduct();
        }

        private void OnProductAddBtnClicked(object? sender, EventArgs e)
        {
            CleanProductViewFields();

            _view.ProductIsAvailable = true;
            _view.SetProductViewToEditable(true);
            _view.BtnProductSaveText = "Add";
            _view.IsEdit = false;
        }

        private void OnProductIsAvailableChbToggled(object? sender, EventArgs e)
        {
            try
            {
                var model = GetCurrentlySelectedProduct();
                if (model == null)
                {
                    CleanProductViewFields();
                    CleanReleaseViewFields();
                    _view.SetProductViewToSelectable(false);
                    _view.IsSuccessful = true;
                    return;
                }

                _productManager.ToggleIsAvailable(model);
                LoadAllProductList();
                _view.ProductIsAvailable = model.IsAvailable;
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void OnProductRenameBtnClicked(object? sender, EventArgs e)
        {
            _view.SetProductViewToEditable(true);
            _view.IsEdit = true;
        }

        private void OnProductSaveBtnClicked(object? sender, EventArgs e)
        {
            try
            {
                var model = new ProductModel()
                {
                    Name = _view.ProductName,
                    IsAvailable = _view.ProductIsAvailable,
                };

                if (_view.IsEdit)
                {
                    model.Id = _view.ProductId;
                    _productManager.Save(model);
                    _view.Message = "Product changes have been saved.";
                }
                else
                {
                    model.IsAvailable = true;
                    _productManager.Add(model);
                    _view.Message = "Product has been added.";
                }

                _view.SetProductViewToEditable(false);
                _view.BtnProductSaveText = "Save";
                LoadAllProductList();
                ShowProduct(model);
                var modelIndex = ((List<string>)_productBindingSource.DataSource).IndexOf(_view.ProductName);
                _view.CbProductListSelected = modelIndex;

                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void OnProductRemoveBtnClicked(object? sender, EventArgs e)
        {
            try
            {
                var model = GetCurrentlySelectedProduct();
                if (model == null)
                {
                    CleanProductViewFields();
                    CleanReleaseViewFields();
                    _view.SetProductViewToSelectable(false);
                    _view.IsSuccessful = true;
                    throw new Exception("Product has not been deleted.");
                }

                _productManager.Delete(model);
                _view.Message = "Product has been deleted.";

                _view.IsSuccessful = true;
                LoadAllProductList();
                ShowCurrentlySelectedProduct();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }


        private void OnReleaseSelectionChanged(object? sender, EventArgs e)
        {
            ShowCurrentlySelectedRelease();
        }

        private void OnReleaseAddBtnClicked(object? sender, EventArgs e)
        {
            CleanReleaseViewFields();
            _view.SetReleaseViewToEditable(true);
        }

        private void OnReleaseSaveBtnClicked(object? sender, EventArgs e)
        {
            try
            {
                var model = new ProductReleaseModel()
                {
                    ReleaseNumber = _view.ReleaseNumber,
                    InstallerVerificationPasscode = _view.ReleaseInstallerVerificationPasscode,
                    Description = _view.ReleaseDescription,
                };

                _productManager.AddRelease(_view.ProductId, model);
                _view.Message = "Release has been added.";

                _view.SetReleaseViewToEditable(false);
                LoadAllReleaseList();
                ShowRelease(model);
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void OnReleaseRemoveBtnClicked(object? sender, EventArgs e)
        {
            try
            {
                var model = GetCurrentlySelectedRelease();
                if (model == null)
                {
                    CleanReleaseViewFields();
                    _view.SetReleaseViewToSelectable(false);
                    _view.IsSuccessful = true;
                    throw new Exception("Release has not been deleted.");
                }

                _productManager.RemoveRelease(_view.ProductId, model);
                _view.Message = "Release has been deleted.";

                LoadAllReleaseList();
                ShowCurrentlySelectedRelease();
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }
    }
}
