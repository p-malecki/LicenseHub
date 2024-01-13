using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Utils;
using LicenseHubApp.Services.Managers;


namespace LicenseHubApp.Presenters
{
    public class ClientManagementPresenter
    {
        private readonly IClientManagementView _view;
        private readonly CompanyManager _companyManager;
        private readonly EmployeeManager _employeeManager;
        private readonly WorkstationManager _workstationManager;
        private readonly BindingSource _companyBindingSource;
        private readonly BindingSource _sidePanelBindingSource;


        public ClientManagementPresenter(
            IClientManagementView view,
            CompanyManager companyManager,
            EmployeeManager employeeManager,
            WorkstationManager workstationManager
            )
        {
            _view = view;
            _companyManager = companyManager;
            _employeeManager = employeeManager;
            _workstationManager = workstationManager;

            _companyBindingSource = new BindingSource();
            _sidePanelBindingSource = new BindingSource();
            view.SetCompanyListBindingSource(_companyBindingSource);
            view.SetSidePanelListBindingSource(_sidePanelBindingSource);

            _view.CloseRightPanelBtnClicked += OnCloseRightPanelBtnClicked;

            _view.CompanySearchBtnClicked += OnCompanySearchBtnClicked;
            _view.CompanyShowDetailsBtnClicked += OnCompanyShowDetailsBtnClicked;
            _view.CompanyAddBtnClicked += OnCompanyAddBtnClicked;
            _view.CompanyShowEmployeesBtnClicked += OnCompanyShowEmployeesBtnClicked;
            _view.CompanyShowWorkstationsBtnClicked += OnCompanyShowWorkstationsBtnClicked;
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
            _workstationManager.LoadAll();
        }

        private void OnCloseRightPanelBtnClicked(object sender, EventArgs e)
        {
            _view.SidePanelTarget = "";
            CleanCompanyViewFields();
        }

        #region CompanyManagement

        private void LoadAllCompanyList()
        {
            var tmpIsEdit = _view.IsEdit;

            var results = _companyManager.GetAll().ToList();
            if (_view.CompanySearchOnlyActive)
            {
                results = results.Where(m => m.IsActive).ToList();
            }

            if (results.Count != 0)
            {
                _companyBindingSource.DataSource = results;
                _view.SetSpecifiedCompanyBtnsToEnabled(true);
            }
            else
            {
                _companyBindingSource.DataSource = new List<CompanyModel>();
                _view.SetSpecifiedCompanyBtnsToEnabled(false);
            }

            _view.IsEdit = tmpIsEdit;
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
                CleanCompanyViewFields();
                _view.SetPanelToEditable(false);
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
                var tmpIsEdit = _view.IsEdit;


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
                        _view.SetSpecifiedCompanyBtnsToEnabled(true);
                    }
                    else
                    {
                        _companyBindingSource.DataSource = new List<CompanyModel>();
                        _view.SetSpecifiedCompanyBtnsToEnabled(false);
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
            CleanCompanyViewFields();
            _view.SetPanelToEditable(false);
            _view.IsEdit = false;
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
                if (!DataValidator.IsNipValid(_view.CompanyNip))
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
                if (model == null)
                {
                    CleanCompanyViewFields();
                    _view.SetPanelToEditable(false);
                    _view.IsEdit = false;
                    _view.IsSuccessful = true;
                    return;
                }
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
            _view.CompanyId = -1;
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

        private void OnCompanyShowWorkstationsBtnClicked(object sender, EventArgs e)
        {
            _view.SidePanelTarget = "Workstation";
            LoadAllSidePanelModelsList();
        }

        #endregion


        private EmployeeModel? GetCurrentlySelectedEmployee()
        {
            if (_sidePanelBindingSource.Count == 0)
            {
                return null;
            }
            return (EmployeeModel)_sidePanelBindingSource.Current;
        }
        private WorkstationModel? GetCurrentlySelectedWorkstation()
        {
            if (_sidePanelBindingSource.Count == 0)
            {
                return null;
            }
            return (WorkstationModel)_sidePanelBindingSource.Current;
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
                        CleanSidePanelViewFields();
                        _view.SetPanelToEditable(false);
                        _view.IsEdit = false;
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
                    var model = GetCurrentlySelectedWorkstation();
                    if (model == null)
                    {
                        CleanSidePanelViewFields();
                        _view.SetPanelToEditable(false);
                        _view.IsEdit = false;
                        _view.IsSuccessful = true;
                        return;
                    }
                    _view.WorkstationId = model.Id;
                    _view.WorkstationHasFaultInfo = model.HasFault.ToString();
                    _view.WorkstationComputerName = model.ComputerName;
                    _view.WorkstationUsername = model.Username;
                    _view.WorkstationHardDisk = model.HardDisk;
                    _view.WorkstationCpu = model.Cpu;
                    _view.WorkstationBiosVersion = model.BiosVersion;
                    _view.WorkstationOs = model.Os;
                    _view.WorkstationOsBitVersion = model.OsBitVersion;

                    _view.SidePanelToggleIsActiveBtnText = (model.HasFault) ? "Change to working" : "Change to faulty";
                    break;
                }
            }

            _view.IsSuccessful = true;
        }



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
                        _view.SetSpecifiedSidePanelBtnsToEnabled(true);
                    }
                    else
                    {
                        _sidePanelBindingSource.DataSource = new List<EmployeeModel>();
                        _view.SetSpecifiedSidePanelBtnsToEnabled(false);
                    }
                    break;
                }
                case "Workstation":
                {
                    var results = companyModel.Workstations.ToList();
                    if (_view.SidePanelSearchOnlyActive)
                    {
                        results = results.Where(m => !m.HasFault).ToList();
                    }

                    if (results.Count != 0)
                    {
                        _sidePanelBindingSource.DataSource = results;
                        _view.SetSpecifiedSidePanelBtnsToEnabled(true);
                    }
                    else
                    {
                        _sidePanelBindingSource.DataSource = new List<WorkstationModel>();
                        _view.SetSpecifiedSidePanelBtnsToEnabled(false);
                    }
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
                            _view.SetSpecifiedSidePanelBtnsToEnabled(true);
                        }
                        else
                        {
                            _sidePanelBindingSource.DataSource = new List<EmployeeModel>();
                            _view.SetSpecifiedSidePanelBtnsToEnabled(false);
                        }
                        break;
                    }
                    case "Workstation":
                    {
                        IFilterStrategy<WorkstationModel> strategy = _view.SidePanelSelectedFilter switch
                        {
                            "username" => new WorkstationUsernameFilterStrategy(),
                            "hard disk" => new WorkstationHardDiskFilterStrategy(),
                            "cpu" => new WorkstationCpuFilterStrategy(),
                            "bios version" => new WorkstationBiosVersionFilterStrategy(),
                            "os" => new WorkstationOsFilterStrategy(),
                            "os bit version" => new WorkstationOsBitVersionFilterStrategy(),
                            _ => new WorkstationComputerNameFilterStrategy(),
                        };
                        _workstationManager.SetFilterStrategy(strategy);

                        var results = _workstationManager.FilterWorkstation(enteredSearchValue).ToList();
                        results = results.Where(m => m.CompanyId == _view.CompanyId).ToList();

                        if (_view.SidePanelSearchOnlyActive)
                            results = results.Where(m => !m.HasFault).ToList();

                        if (results.Count != 0)
                        {
                            _sidePanelBindingSource.DataSource = results;
                            _view.SetSpecifiedSidePanelBtnsToEnabled(true);
                        }
                        else
                        {
                            _sidePanelBindingSource.DataSource = new List<WorkstationModel>();
                            _view.SetSpecifiedSidePanelBtnsToEnabled(false);
                        }
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
            CleanSidePanelViewFields();
            _view.SetPanelToEditable(false);
            _view.IsEdit = false;
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
                        var model = new WorkstationModel()
                        {
                            Id = _view.WorkstationId,
                            HasFault = bool.Parse(_view.WorkstationHasFaultInfo),
                            ComputerName = _view.WorkstationComputerName,
                            Username = _view.WorkstationUsername,
                            HardDisk = _view.WorkstationHardDisk,
                            Cpu = _view.WorkstationCpu,
                            BiosVersion = _view.WorkstationBiosVersion,
                            Os = _view.WorkstationOs,
                            OsBitVersion = _view.WorkstationOsBitVersion,
                        };

                        if (_view.IsEdit)
                        {
                            model.Id = _view.WorkstationId;
                            _workstationManager.Save(model);
                            _view.Message = "Workstation details have been saved.";
                        }
                        else
                        {
                            model.HasFault = false;
                            _companyManager.AddWorkstation(companyId, model);
                            _workstationManager.LoadAll();
                            _view.Message = "Workstation has been added.";
                        }
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

                        var employeeModel = GetCurrentlySelectedEmployee();
                        if (employeeModel == null)
                        {
                            CleanSidePanelViewFields();
                            _view.SetPanelToEditable(false);
                            _view.IsEdit = false;
                            _view.IsSuccessful = true;
                            return;
                        }
                        _employeeManager.ToggleIsActive(employeeModel);
                        break;
                    }
                    case "Workstation":
                        var workstationModel = GetCurrentlySelectedWorkstation();
                        if (workstationModel == null)
                        {
                            CleanSidePanelViewFields();
                            _view.SetPanelToEditable(false);
                            _view.IsEdit = false;
                            _view.IsSuccessful = true;
                            return;
                        }
                        _workstationManager.ToggleHasFault(workstationModel);
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
                    _view.EmployeeId = -1;
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
                case "Workstation":
                {
                    _view.WorkstationId = -1;
                    _view.WorkstationHasFaultInfo = "False";
                    _view.WorkstationComputerName = "";
                    _view.WorkstationUsername = "";
                    _view.WorkstationHardDisk = "";
                    _view.WorkstationCpu = "";
                    _view.WorkstationBiosVersion = "";
                    _view.WorkstationOs = "";
                    _view.WorkstationOsBitVersion = "";
                    break;
                }
            }
            _view.IsSuccessful = false;
        }

        #endregion
    }
}
