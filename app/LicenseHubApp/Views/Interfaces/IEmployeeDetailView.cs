namespace LicenseHubApp.Views.Interfaces;

public interface IEmployeeDetailView
{
    #region Properties
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    int EmployeeId { get; set; }
    string EmployeeCompanyName { get; set; }
    bool EmployeeIsActive { get; set; }
    string EmployeeName { get; set; }
    string EmployeeProfession { get; set; }
    string EmployeePhoneNumbers { get; set; }
    string EmployeeEmails { get; set; }
    string EmployeeWebsites { get; set; }
    string EmployeeIPs { get; set; }
    string EmployeeDescription { get; set; }

    bool IsGoToWorkstationEnabled { get; set; }

    #endregion


    #region Events

    event EventHandler EditBtnClicked;
    event EventHandler SaveBtnClicked;
    event EventHandler EditCancelBtnClicked;
    event EventHandler IsActiveToggled;
    event EventHandler GoToWorkstationBtnClicked;
    event EventHandler CloseDetailViewBtnClicked;

    #endregion


    #region Methods
    void SetWorkstationListBindingSource(BindingSource workstationList);
    void SetViewToEditable(bool editable);

    #endregion

}