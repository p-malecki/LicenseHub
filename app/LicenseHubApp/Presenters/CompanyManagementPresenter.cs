using LicenseHubApp.Models;
using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Models.Managers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using LicenseHubApp.Models.Filters;
using System.Buffers;
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
            view.SetUserListBindingSource(_companyBindingSource);

            _view.SearchBtnClicked += OnSearchBtnClicked;
            _view.ShowDetailsBtnClicked += OnShowDetailsBtnClicked;
            _view.EditBtnClicked += OnEditBtnClicked;
            _view.AddBtnClicked += OnAddBtnClicked;
            _view.DeactivateBtnClicked += OnDeactivateBtnClicked;

            LoadAllList();
        }

        private void LoadAllList()
        {
            var results = _manager.GetAll();
            if (_view.SearchOnlyActiveCompanies)
                results = results.Where(c => c.IsActive);
            _companyBindingSource.DataSource = results;
        }
        private CompanyModel GetCurrentlySelectedModel()
        {
            if (_companyBindingSource.Count == 0)
                throw new DataException("Empty BindingSource");
            return (CompanyModel)_companyBindingSource.Current;
        }


        private void OnSearchBtnClicked(object sender, EventArgs e)
        {
            var enteredSearchValue = _view.SearchValue;
            if (string.IsNullOrEmpty(enteredSearchValue))
            {
                LoadAllList();
            }
            else
            {
                IFilterStrategy<CompanyModel> strategy = _view.SelectedFilter switch
                {
                    "Nip" => new CustomerNipFilterStrategy(),
                    _ => new CustomerNameFilterStrategy(),
                };
                _manager.SetFilterStrategy(strategy);

                var results = _manager.FilterCompany(enteredSearchValue);
                if (_view.SearchOnlyActiveCompanies)
                    results = results.Where(c => c.IsActive);
                _companyBindingSource.DataSource = results;
            }
        }

        private void OnShowDetailsBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var model = GetCurrentlySelectedModel();
                _view.CompanyIsActiveInfo = model.IsActive.ToString();
                _view.CompanyName = model.Name;
                _view.CompanyNip = model.Nip;
                _view.CompanyLocalizations = model.Localizations;
                _view.CompanyWebsites = model.Websites;
                _view.CompanyDescription = model.Description;
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.Message = ex.Message;
                _view.IsSuccessful = false;
                throw;
            }
        }

        private void OnEditBtnClicked(object sender, EventArgs e)
        {
        }
        private void OnAddBtnClicked(object sender, EventArgs e)
        {
        }

        private void OnDeactivateBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var model = GetCurrentlySelectedModel();
                _manager.Deactivate(model);
            }
            catch (Exception ex)
            {
                _view.Message = ex.Message;
                _view.IsSuccessful = false;
                throw;
            }
        }


    }
}
