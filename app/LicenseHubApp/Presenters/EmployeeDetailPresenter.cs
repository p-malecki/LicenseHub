using LicenseHubApp.Models;
using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Utils;
using LicenseHubApp.Services;


namespace LicenseHubApp.Presenters
{
    public class EmployeeDetailPresenter
    {
        private readonly IEmployeeDetailView _view;
        private readonly EmployeeModel _employee;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly BindingSource _workstationBindingSource;
        private readonly EventHandler<GoToDetailViewEventArgs>? _goToWorkstationDetailViewChanged;
        private readonly EventHandler _closeDetailViewClicked;


        public EmployeeDetailPresenter(
            IEmployeeDetailView view,
            EmployeeModel employee,
            IEmployeeRepository employeeRepository,
            EventHandler<GoToDetailViewEventArgs>? goToWorkstationDetailViewChanged,
            EventHandler CloseDetailViewClicked
            )
        {
            _view = view;
            _employee = employee;
            _employeeRepository = employeeRepository;
            _goToWorkstationDetailViewChanged = goToWorkstationDetailViewChanged;
            _closeDetailViewClicked = CloseDetailViewClicked;

            ShowModel();
            _view.SetViewToEditable(false);

            _workstationBindingSource = [];
            _view.SetWorkstationListBindingSource(_workstationBindingSource);
            LoadWorkstationList();

            _view.EditBtnClicked += OnEditBtnClicked;
            _view.SaveBtnClicked += OnSaveBtnClicked;
            _view.EditCancelBtnClicked += OnEditCancelBtnClicked;
            _view.IsActiveToggled += OnToggleIsActiveBtnClicked;
            _view.GoToWorkstationBtnClicked += delegate
            {
                var workstation = GetSelectedWorkstation();
                if (workstation != null)
                {
                    _goToWorkstationDetailViewChanged?.Invoke(this,
                        new GoToDetailViewEventArgs() { Workstation = workstation });
                }
            };
            _view.CloseDetailViewBtnClicked += delegate
            {
                _closeDetailViewClicked.Invoke(this, EventArgs.Empty);
            };
        }

        private void ShowModel()
        {
            _view.EmployeeCompanyName = _employee.Company.Name;
            _view.EmployeeId = _employee.Id;
            _view.EmployeeIsActive = _employee.IsActive;
            _view.EmployeeName = _employee.Name;
            _view.EmployeeProfession = _employee.Profession;
            _view.EmployeePhoneNumbers = _employee.PhoneNumbers;
            _view.EmployeeEmails = _employee.Emails;
            _view.EmployeeWebsites = _employee.Websites;
            _view.EmployeeIPs = _employee.IPs;
            _view.EmployeeDescription = _employee.Description;

            _view.IsSuccessful = true;
        }
        private void LoadWorkstationList()
        {
            var workstationList = _employee.Workstations.ToList();
            if (workstationList.Count > 0)
            {
                _workstationBindingSource.DataSource = workstationList;
                _view.IsGoToWorkstationEnabled = true;
            }
            else
            {
                _workstationBindingSource.DataSource = new List<WorkstationModel>();
                _view.IsGoToWorkstationEnabled = false;
            }
        }

        private void OnEditBtnClicked(object? sender, EventArgs e)
        {
            _view.SetViewToEditable(true);
        }
        private void OnEditCancelBtnClicked(object? sender, EventArgs e)
        {
            _view.SetViewToEditable(false);
        }
        private async void OnSaveBtnClicked(object? sender, EventArgs e)
        {
            try
            {
                var model = new EmployeeModel()
                {
                    Id = _view.EmployeeId,
                    IsActive = _view.EmployeeIsActive,
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
                
                await _employeeRepository.Update(model.Id, model);
                _view.Message = "Employee details have been saved.";
                _view.SetViewToEditable(false);
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                ShowModel();
                _view.SetViewToEditable(false);
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }
        private async void OnToggleIsActiveBtnClicked(object? sender, EventArgs e)
        {
            _employee.IsActive = !_employee.IsActive;
            await _employeeRepository.Update(_employee.Id, _employee);
        }

        private WorkstationModel? GetSelectedWorkstation()
        {
            if (_workstationBindingSource.Count == 0)
                return null;
            return (WorkstationModel)_workstationBindingSource.Current;
        }
    }
}
