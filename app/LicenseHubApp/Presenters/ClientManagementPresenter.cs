using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using LicenseHubApp.Models.Managers;
using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Utils;


namespace LicenseHubApp.Presenters
{
    public class ClientManagementPresenter
    {
        private readonly IClientManagementView _view;
        private readonly CompanyManager _companyManager;
        private readonly EmployeeManager _employeeManager;
        private readonly BindingSource _companyBindingSource;
        private readonly BindingSource _sidePanelBindingSource;


        public ClientManagementPresenter(
            IClientManagementView view,
            CompanyManager companyManager,
            EmployeeManager employeeManager
            )
        {
            _view = view;
            _companyManager = companyManager;
            _employeeManager = employeeManager;

            _companyBindingSource = new BindingSource();
            _sidePanelBindingSource = new BindingSource();
            view.SetCompanyListBindingSource(_companyBindingSource);
            view.SetSidePanelListBindingSource(_sidePanelBindingSource);

            _view.CloseRightPanelBtnClicked += OnCloseRightPanelBtnClicked;

            _view.CompanySearchBtnClicked += OnCompanySearchBtnClicked;
            _view.CompanyShowDetailsBtnClicked += OnCompanyShowDetailsBtnClicked;
            _view.CompanyAddBtnClicked += OnCompanyAddBtnClicked;
            _view.CompanyShowEmployeesBtnClicked += OnCompanyShowEmployeesBtnClicked;
            _view.CompanyEditBtnClicked += OnCompanyEditBtnClicked;
            _view.CompanySaveBtnClicked += OnCompanyEditSaveBtnClicked;
            _view.CompanyEditCancelBtnClicked += OnCompanyEditCancelBtnClicked;
            _view.CompanyToggleIsActiveBtnClicked += OnCompanyToggleIsActiveBtnClicked;

            _view.SidePanelSearchBtnClicked += OnSidePanelSearchBtnClicked;
            _view.SidePanelShowDetailsBtnClicked += OnSidePanelShowDetailsBtnClicked;
            _view.SidePanelAddBtnClicked += OnSidePanelAddBtnClicked;
            _view.SidePanelEditBtnClicked += OnSidePanelEditBtnClicked;
            _view.SidePanelSaveBtnClicked += OnSidePanelEditSaveBtnClicked;
            _view.SidePanelEditCancelBtnClicked += OnSidePanelEditCancelBtnClicked;
            _view.SidePanelToggleIsActiveBtnClicked += OnSidePanelToggleIsActiveBtnClicked;

            LoadAllCompanyList();
            _employeeManager.LoadAll();
        }

        private void OnCloseRightPanelBtnClicked(object sender, EventArgs e)
        {
            _view.SidePanelTarget = "";
            CleanCompanyViewFields();
        }

        #region CompanyManagement

        private void LoadAllCompanyList()
        {
            var results = _companyManager.GetAll().ToList();
            if (_view.CompanySearchOnlyActive)
            {
                results = results.Where(m => m.IsActive).ToList();
            }

            if (results.Count != 0)
            {
                _companyBindingSource.DataSource = results;
                _view.SetCompanyEditBtnToEnabled(true);
            }
            else
            {
                _companyBindingSource.DataSource = new List<CompanyModel>();
                _view.SetCompanyEditBtnToEnabled(false);
            }
        }
        private CompanyModel? GetCurrentlySelectedCompany()
        {
            if (_companyBindingSource.Count == 0)
            {
                return null;
            }
            return (CompanyModel)_companyBindingSource.Current;
        }
        private void ShowCurrentlySelectedCompany()
        {
            var model = GetCurrentlySelectedCompany();
            if (model == null)
            {
                _view.IsSuccessful = true;
                return;
            }
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
                    LoadAllCompanyList();
                }
                else
                {
                    IFilterStrategy<CompanyModel> strategy = _view.CompanySelectedFilter switch
                    {
                        "nip" => new CustomerNipFilterStrategy(),
                        _ => new CustomerNameFilterStrategy(),
                    };
                    _companyManager.SetFilterStrategy(strategy);

                    var results = _companyManager.FilterCompany(enteredSearchValue).ToList();
                    if (_view.CompanySearchOnlyActive)
                        results = results.Where(m => m.IsActive).ToList();

                    if (results.Count != 0)
                    {
                        _companyBindingSource.DataSource = results;
                        _view.SetCompanyEditBtnToEnabled(true);
                    }
                    else
                    {
                        _companyBindingSource.DataSource = new List<CompanyModel>();
                        _view.SetCompanyEditBtnToEnabled(false);
                    }
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
            ShowCurrentlySelectedCompany();
            LoadAllSidePanelModelsList();
            _view.IsEdit = false;
        }

        private void OnCompanyEditBtnClicked(object sender, EventArgs e)
        {
            ShowCurrentlySelectedCompany();
            _view.IsEdit = true;
        }
        private void OnCompanyAddBtnClicked(object sender, EventArgs e)
        {
            _view.IsEdit = false;
            CleanCompanyViewFields();
            _view.CompanyIsActiveInfo = "true";
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

                // validation
                if (DataValidator.IsNipValid(_view.CompanyNip))
                {
                    throw new InvalidDataException("Incorrect NIP.");
                }


                if (_view.IsEdit)
                {
                    model.Id = _view.CompanyId;
                    _companyManager.Save(model);
                    _view.Message = "Company details have been saved.";
                }
                else
                {
                    model.IsActive = true;
                    _companyManager.Add(model);
                    _view.Message = "Company has been added.";
                }

                _view.IsSuccessful = true;
                LoadAllCompanyList();
                CleanCompanyViewFields();

                // show saved results
                ShowCurrentlySelectedCompany();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }
        private void OnCompanyEditCancelBtnClicked(object sender, EventArgs e)
        {
            ShowCurrentlySelectedCompany(); // reset data
            _view.IsEdit = false; // turn off editable
        }
        private void OnCompanyToggleIsActiveBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var model = GetCurrentlySelectedCompany();
                _companyManager.ToggleIsActive(model);
                ShowCurrentlySelectedCompany();
                LoadAllCompanyList();
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CleanCompanyViewFields()
        {
            _view.CompanyIsActiveInfo = "";
            _view.CompanyName = "";
            _view.CompanyNip = "";
            _view.CompanyLocalizations = "";
            _view.CompanyWebsites = "";
            _view.CompanyDescription = "";
            _view.IsSuccessful = false;
        }

        private void OnCompanyShowEmployeesBtnClicked(object sender, EventArgs e)
        {
            _view.SidePanelTarget = "Employee";
            LoadAllSidePanelModelsList();
        }

        #endregion


        #region EmployeeManagement
        private EmployeeModel? GetCurrentlySelectedEmployee()
        {
            if (_sidePanelBindingSource.Count == 0)
            {
                return null;
            }
            return (EmployeeModel)_sidePanelBindingSource.Current;
        }

        private void ShowCurrentlySelectedModel()
        {
            switch (_view.SidePanelTarget)
            {
                case "Employee":
                {
                    var model = GetCurrentlySelectedEmployee();
                    if (model == null)
                    {
                        _view.IsSuccessful = true;
                        return;
                    }
                    _view.EmployeeId = model.Id;
                    _view.EmployeeIsActiveInfo = model.IsActive.ToString();
                    _view.EmployeeName = model.Name;
                    _view.EmployeeProfession = model.Profession;
                    _view.EmployeePhoneNumbers = model.PhoneNumbers;
                    _view.EmployeeEmails = model.Emails;
                    _view.EmployeeWebsites = model.Websites;
                    _view.EmployeeIPs = model.IPs;
                    _view.EmployeeDescription = model.Description;
                    _view.SidePanelToggleIsActiveBtnText = (model.IsActive) ? "Deactivate" : "Activate";
                    break;
                }
                case "Workstation":
                {
                    // TODO show workstation models using GetCurrentlySelectedWorksation
                    break;
                }
            }

            _view.IsSuccessful = true;
        }
        #endregion



        #region SidePanelManagement
        private void LoadAllSidePanelModelsList()
        {
            var companyModel = GetCurrentlySelectedCompany();
            if (companyModel == null)
            {
                _view.IsSuccessful = true;
                return;
            }

            var tmpIsEdit = _view.IsEdit;

            switch (_view.SidePanelTarget)
            {
                case "Employee":
                {
                    var results = companyModel.Employees.ToList();
                    if (_view.SidePanelSearchOnlyActive)
                    {
                        results = results.Where(m => m.IsActive).ToList();
                    }

                    if (results.Count != 0)
                    {
                        _sidePanelBindingSource.DataSource = results;
                        _view.SetSidePanelEditBtnToEnabled(true);
                    }
                    else
                    {
                        _sidePanelBindingSource.DataSource = new List<EmployeeModel>();
                        _view.SetSidePanelEditBtnToEnabled(false);
                    }
                    break;
                }
                case "Workstation":
                {
                    // TODO load workstation models
                    break;
                }
            }

            _view.IsEdit = tmpIsEdit;
        }

        private void OnSidePanelSearchBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var enteredSearchValue = _view.SidePanelSearchValue;
                if (string.IsNullOrEmpty(enteredSearchValue))
                {
                    LoadAllSidePanelModelsList();
                    return;
                }

                var tmpIsEdit = _view.IsEdit;

                switch (_view.SidePanelTarget)
                {
                    case "Employee":
                    {
                        IFilterStrategy<EmployeeModel> strategy = _view.SidePanelSelectedFilter switch
                        {
                            "profession" => new EmployeeProfessionFilterStrategy(),
                            "phone number" => new EmployeePhoneNumberFilterStrategy(),
                            "email" => new EmployeeEmailFilterStrategy(),
                            "ip" => new EmployeeIPsFilterStrategy(),
                            _ => new EmployeeNameFilterStrategy()
                        };
                        _employeeManager.SetFilterStrategy(strategy);

                        var results = _employeeManager.FilterEmployee(enteredSearchValue).ToList();
                        results = results.Where(m => m.CompanyId == _view.CompanyId).ToList();

                        if (_view.SidePanelSearchOnlyActive)
                            results = results.Where(m => m.IsActive).ToList();

                        if (results.Count != 0)
                        {
                            _sidePanelBindingSource.DataSource = results;
                            _view.SetSidePanelEditBtnToEnabled(true);
                        }
                        else
                        {
                            _sidePanelBindingSource.DataSource = new List<EmployeeModel>();
                            _view.SetSidePanelEditBtnToEnabled(false);
                        }
                        break;
                    }
                    case "Workstation":
                    {
                        // TODO select workstation filter and search
                        break;
                    }
                }
                _view.IsEdit = tmpIsEdit;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void OnSidePanelShowDetailsBtnClicked(object sender, EventArgs e)
        {
            ShowCurrentlySelectedModel();
            _view.IsEdit = false;
        }

        private void OnSidePanelEditBtnClicked(object sender, EventArgs e)
        {
            ShowCurrentlySelectedModel();
            _view.IsEdit = true;
        }
        private void OnSidePanelAddBtnClicked(object sender, EventArgs e)
        {
            _view.IsEdit = false;
            CleanSidePanelViewFields();
            _view.EmployeeIsActiveInfo = "true";
        }


        private void OnSidePanelEditSaveBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var companyId = GetCurrentlySelectedCompany()?.Id ?? -1;

                switch (_view.SidePanelTarget)
                {
                    case "Employee":
                    {
                        var model = new EmployeeModel()
                        {
                            IsActive = bool.Parse(_view.EmployeeIsActiveInfo),
                            Name = _view.EmployeeName,
                            Profession = _view.EmployeeProfession,
                            PhoneNumbers = _view.EmployeePhoneNumbers,
                            Emails = _view.EmployeeEmails,
                            Websites = _view.EmployeeWebsites,
                            IPs = _view.EmployeeIPs,
                            Description = _view.EmployeeDescription,
                        };

                        // validation
                        if (!string.IsNullOrWhiteSpace(_view.EmployeePhoneNumbers) && !DataValidator.ArePhoneNumbersValid(_view.EmployeePhoneNumbers))
                        {
                            throw new InvalidDataException("Incorrect phone number(s).");
                        }
                        if (!string.IsNullOrWhiteSpace(_view.EmployeeEmails) && !DataValidator.AreEmailsValid(_view.EmployeeEmails))
                        {
                            throw new InvalidDataException("Incorrect email(s).");
                        }

                        if (_view.IsEdit)
                        {
                            model.Id = _view.EmployeeId;
                            _employeeManager.Save(model);
                            _view.Message = "Employee details have been saved.";
                        }
                        else
                        {
                            model.IsActive = true;
                            _companyManager.AddEmployee(companyId, model);
                            _employeeManager.LoadAll();
                            _view.Message = "Employee has been added.";
                        }
                        break;
                    }
                    case "Workstation":
                    {
                        // TODO save workstation
                        break;
                    }
                }

                _view.IsSuccessful = true;
                LoadAllSidePanelModelsList();
                CleanSidePanelViewFields();

                // show saved results
                ShowCurrentlySelectedModel();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }
        private void OnSidePanelEditCancelBtnClicked(object sender, EventArgs e)
        {
            ShowCurrentlySelectedModel(); // reset data
            _view.IsEdit = false; // turn off editable
        }
        private void OnSidePanelToggleIsActiveBtnClicked(object sender, EventArgs e)
        {
            try
            {
                switch (_view.SidePanelTarget)
                {
                    case "Employee":
                    {
                        var model = GetCurrentlySelectedEmployee();
                        _employeeManager.ToggleIsActive(model);
                        break;
                    }
                    case "Workstation":
                        // TODO GetCurrentlySelectedWorkstation toggleBtn
                        break;
                }

                ShowCurrentlySelectedModel();
                LoadAllSidePanelModelsList();
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CleanSidePanelViewFields()
        {
            switch (_view.SidePanelTarget)
            {
                case "Employee":
                {
                    _view.EmployeeIsActiveInfo = "";
                    _view.EmployeeName = "";
                    _view.EmployeeProfession = "";
                    _view.EmployeePhoneNumbers = "";
                    _view.EmployeeEmails = "";
                    _view.EmployeeWebsites = "";
                    _view.EmployeeIPs = "";
                    _view.EmployeeDescription = "";
                    break;
                }
            }
            _view.IsSuccessful = false;
        }

        #endregion
    }
}
