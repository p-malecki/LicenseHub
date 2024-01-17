﻿using LicenseHubApp.Models;
using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Utils;
using LicenseHubApp.Services.Managers;


namespace LicenseHubApp.Presenters
{
    public class WorkstationDetailPresenter
    {
        private readonly IWorkstationDetailView _view;
        private readonly WorkstationModel _workstation;
        private readonly WorkstationManager _workstationManager;
        private readonly BindingSource _employeeBindingSource;
        private readonly BindingSource _workstationProductBindingSource;
        private readonly EventHandler<GoToDetailViewEventArgs>? _goToEmployeeDetailViewChanged;
        private readonly EventHandler _closeDetailViewClicked;


        public WorkstationDetailPresenter(
            IWorkstationDetailView view,
            WorkstationModel workstation,
            WorkstationManager workstationManager,
            EventHandler<GoToDetailViewEventArgs>? goToEmployeeDetailViewChanged,
            //EventHandler<GoToDetailViewEventArgs>? goToWorkstationProductDetailViewChanged, // TODO WP detail view
            EventHandler closeDetailViewClicked
        )
        {
            _view = view;
            _workstation = workstation;
            _workstationManager = workstationManager;
            _goToEmployeeDetailViewChanged = goToEmployeeDetailViewChanged;
            _closeDetailViewClicked = closeDetailViewClicked;

            ShowModel();
            _view.SetViewToEditable(false);

            _employeeBindingSource = [];
            _workstationProductBindingSource = [];
            _view.SetEmployeeListBindingSource(_employeeBindingSource);
            _view.SetWorkstationProductListBindingSource(_workstationProductBindingSource);
            LoadEmployeeList();
            LoadWorkstationProductList();

            _view.EditBtnClicked += OnEditBtnClicked;
            _view.SaveBtnClicked += OnSaveBtnClicked;
            _view.EditCancelBtnClicked += OnEditCancelBtnClicked;
            _view.HasFaultToggled += OnToggleHasFaultBtnClicked;
            _view.GoToEmployeeBtnClicked += delegate
            {
                var employee = GetSelectedEmployee();
                if (employee != null)
                {
                    _goToEmployeeDetailViewChanged?.Invoke(this,
                        new GoToDetailViewEventArgs() { Employee = employee });
                }
            };
            _view.GoToWorkstationProductBtnClicked += delegate
            {
                var workstationProduct = GetSelectedWorkstationProduct();
                if (workstationProduct != null)
                {
                    // TODO WP detail view
                    //_goToEmployeeDetailViewChanged?.Invoke(this,
                    //    new GoToDetailViewEventArgs() { WorkstationProduct = workstationProduct });
                    MessageBox.Show(@"workstation product detail view");
                }
            };
            _view.CloseDetailViewBtnClicked += delegate
            {
                _closeDetailViewClicked.Invoke(this, EventArgs.Empty);
            };
        }

        private void ShowModel()
        {
            _view.WorkstationCompanyName = _workstation.Company.Name;
            _view.WorkstationId = _workstation.Id;
            _view.WorkstationHasFault = _workstation.HasFault;
            _view.WorkstationComputerName = _workstation.ComputerName;
            _view.WorkstationUsername = _workstation.Username;
            _view.WorkstationHardDisk = _workstation.HardDisk;
            _view.WorkstationCpu = _workstation.Cpu;
            _view.WorkstationBiosVersion = _workstation.BiosVersion;
            _view.WorkstationOs = _workstation.Os;
            _view.WorkstationOsBitVersion = _workstation.OsBitVersion;

            _view.IsSuccessful = true;
        }
        private void LoadEmployeeList()
        {
            var employeeList = _workstation.Employees.ToList();
            if (employeeList.Count > 0)
            {
                _employeeBindingSource.DataSource = employeeList;
                _view.IsGoToEmployeeEnabled = true;
            }
            else
            {
                _employeeBindingSource.DataSource = new List<EmployeeModel>();
                _view.IsGoToEmployeeEnabled = false;
            }
        }
        private void LoadWorkstationProductList()
        {
            var workstationsList = _workstation.WorkstationProducts.ToList();
            if (workstationsList.Count > 0)
            {
                _workstationProductBindingSource.DataSource = workstationsList;
                _view.IsGoToWorkstationProductEnabled = true;
            }
            else
            {
                _workstationProductBindingSource.DataSource = new List<WorkstationProductModel>();
                _view.IsGoToWorkstationProductEnabled = false;
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
        private void OnSaveBtnClicked(object? sender, EventArgs e)
        {
            try
            {
                var model = new WorkstationModel
                {
                    Id = _view.WorkstationId,
                    HasFault = _view.WorkstationHasFault,
                    ComputerName = _view.WorkstationComputerName,
                    Username = _view.WorkstationUsername,
                    HardDisk = _view.WorkstationHardDisk,
                    Cpu = _view.WorkstationCpu,
                    BiosVersion = _view.WorkstationBiosVersion,
                    Os = _view.WorkstationOs,
                    OsBitVersion = _view.WorkstationOsBitVersion,
                };

                _workstationManager.Save(model);
                _view.Message = "Workstation details have been saved.";
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
        private void OnToggleHasFaultBtnClicked(object? sender, EventArgs e)
        {
            _workstationManager.ToggleHasFault(_workstation);
        }
        
        private EmployeeModel? GetSelectedEmployee()
        {
            if (_employeeBindingSource.Count == 0)
                return null;
            return (EmployeeModel)_employeeBindingSource.Current;
        }
        private WorkstationProductModel? GetSelectedWorkstationProduct()
        {
            if (_workstationProductBindingSource.Count == 0)
                return null;
            return (WorkstationProductModel)_workstationProductBindingSource.Current;
        }
    }
}