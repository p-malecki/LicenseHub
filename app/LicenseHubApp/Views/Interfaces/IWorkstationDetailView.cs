namespace LicenseHubApp.Views.Interfaces;


public interface IWorkstationDetailView
{
    #region Properties
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    int WorkstationId { get; set; }
    string WorkstationCompanyName { get; set; }
    bool WorkstationHasFault { get; set; }
    string WorkstationComputerName { get; set; }
    string WorkstationUsername { get; set; }
    string WorkstationHardDisk { get; set; }
    string WorkstationCpu { get; set; }
    string WorkstationBiosVersion { get; set; }
    string WorkstationOs { get; set; }
    string WorkstationOsBitVersion { get; set; }

    bool IsGoToEmployeeEnabled { get; set; }
    bool IsGoToWorkstationProductEnabled { get; set; }

    #endregion


    #region Events

    event EventHandler EditBtnClicked;
    event EventHandler SaveBtnClicked;
    event EventHandler EditCancelBtnClicked;
    event EventHandler HasFaultToggled;
    event EventHandler GoToEmployeeBtnClicked;
    event EventHandler GoToWorkstationProductBtnClicked;
    event EventHandler CloseDetailViewBtnClicked;

    #endregion


    #region Methods
    void SetEmployeeListBindingSource(BindingSource employeeList);
    void SetWorkstationProductListBindingSource(BindingSource workstationProductList);
    void SetViewToEditable(bool editable);

    #endregion

}