using LicenseHubApp.Models;
using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Models.Managers;
using LicenseHubApp.Models.Filters;
using System.Data;


namespace LicenseHubApp.Presenters
{
    public class CompanyManagementPresenter
    {
        private readonly ICompanyManagementView _view;
        private readonly CompanyManager _manager;
        private readonly BindingSource _companyBindingSource;


        public CompanyManagementPresenter(ICompanyManagementView view, CompanyManager manager)
        {
            _view = view;
            _manager = manager;
            _companyBindingSource = new BindingSource();
            view.SetCompanyListBindingSource(_companyBindingSource);

            _view.CloseRightPanelBtnClicked += OnCloseRightPanelBtnClicked;
            _view.CompanySearchBtnClicked += OnCompanySearchBtnClicked;
            _view.CompanyShowDetailsBtnClicked += OnCompanyShowDetailsBtnClicked;
            _view.CompanyAddBtnClicked += OnCompanyAddBtnClicked;
            _view.CompanyEditBtnClicked += OnCompanyEditBtnClicked;
            _view.CompanySaveBtnClicked += OnCompanyEditSaveBtnClicked;
            _view.CompanyEditCancelBtnClicked += OnCompanyEditCancelBtnClicked;
            _view.CompanyToggleIsActiveBtnClicked += OnCompanyToggleIsActiveBtnClicked;


            LoadAllList();
        }

        private void LoadAllList()
        {
            var results = _manager.GetAll();
            if (_view.CompanySearchOnlyActive)
                results = results.Where(c => c.IsActive);
            _companyBindingSource.DataSource = results;
        }
        private CompanyModel GetCurrentlySelectedModel()
        {
            if (_companyBindingSource.Count == 0)
                throw new DataException("Empty BindingSource");
            return (CompanyModel)_companyBindingSource.Current;
        }
        private void ShowCurrentlySelectedModel()
        {
            var model = GetCurrentlySelectedModel();
            _view.CompanyId = model.Id;
            _view.CompanyIsActiveInfo = model.IsActive.ToString();
            _view.CompanyName = model.Name;
            _view.CompanyNip = model.Nip;
            _view.CompanyLocalizations = model.Localizations;
            _view.CompanyWebsites = model.Websites;
            _view.CompanyDescription = model.Description;

            _view.CompanyToggleIsActiveBtnText = (model.IsActive) ? "Deactivate" : "Activate";
            _view.IsSuccessful = true;
        }


        private void OnCompanySearchBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var enteredSearchValue = _view.CompanySearchValue;
                if (string.IsNullOrEmpty(enteredSearchValue))
                {
                    LoadAllList();
                }
                else
                {
                    IFilterStrategy<CompanyModel> strategy = _view.CompanySelectedFilter switch
                    {
                        "Nip" => new CustomerNipFilterStrategy(),
                        _ => new CustomerNameFilterStrategy(),
                    };
                    _manager.SetFilterStrategy(strategy);

                    var results = _manager.FilterCompany(enteredSearchValue);
                    if (_view.CompanySearchOnlyActive)
                        results = results.Where(c => c.IsActive);
                    _companyBindingSource.DataSource = results;
                }
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void OnCompanyShowDetailsBtnClicked(object sender, EventArgs e)
        {
            ShowCurrentlySelectedModel();
            _view.CompanyIsEdit = false;
        }

        private void OnCompanyEditBtnClicked(object sender, EventArgs e)
        {
            ShowCurrentlySelectedModel();
            _view.CompanyIsEdit = true;
        }
        private void OnCompanyAddBtnClicked(object sender, EventArgs e)
        {
            _view.CompanyIsEdit = false;
            CleanViewFields();
            _view.CompanyIsActiveInfo = "true";
        }


        private void OnCloseRightPanelBtnClicked(object sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void OnCompanyEditSaveBtnClicked(object sender, EventArgs e)
        {
            try
            {
                // prep nip
                _view.CompanyNip = _view.CompanyNip.Replace(" ", "").Replace("-", "").Replace("—", "").Replace("_", "").Replace("O", "0").Replace("o", "0");

                var model = new CompanyModel()
                {
                    IsActive = bool.Parse(_view.CompanyIsActiveInfo),
                    Name = _view.CompanyName,
                    Nip = _view.CompanyNip,
                    Localizations = _view.CompanyLocalizations,
                    Websites = _view.CompanyWebsites,
                    Description = _view.CompanyDescription,
                };

                if (_view.CompanyIsEdit)
                {
                    if (CompanyManager.IsNipValid(_view.CompanyNip))
                    {
                        model.Id = _view.CompanyId;
                        _manager.Save(model);
                        _view.Message = "Company details have been saved.";
                    }
                    else
                        throw new InvalidDataException("Incorrect NIP.");
                }
                else
                {
                    model.IsActive = true;
                    _manager.Add(model);
                    _view.Message = "Company has been added.";
                }

                _view.IsSuccessful = true;
                LoadAllList();
                CleanViewFields();

                // show saved results
                ShowCurrentlySelectedModel();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }
        private void OnCompanyEditCancelBtnClicked(object sender, EventArgs e)
        {
            ShowCurrentlySelectedModel(); // reset data
            _view.CompanyIsEdit = false; // turn off editable
        }
        private void OnCompanyToggleIsActiveBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var model = GetCurrentlySelectedModel();
                _manager.ToggleIsActive(model);
                ShowCurrentlySelectedModel();
                LoadAllList();
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }


        private void CleanViewFields()
        {
            _view.CompanyIsActiveInfo = "";
            _view.CompanyName = "";
            _view.CompanyNip = "";
            _view.CompanyLocalizations = "";
            _view.CompanyWebsites = "";
            _view.CompanyDescription = "";
            _view.IsSuccessful = false;
        }

    }
}
