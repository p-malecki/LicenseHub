namespace LicenseHubApp.Views.Interfaces;

public interface ICompanyManagementView
{
    #region Properties
    bool IsSuccessful { get; set; }
    string Message { get; set; }
    bool IsEdit { get; set; }

    string CompanySearchValue { get; set; }
    string CompanySelectedFilter { get; set; }
    bool CompanySearchOnlyActive { get; set; }

    int CompanyId { get; set; }
    string CompanyIsActiveInfo { get; set; }
    string CompanyName { get; set; }
    string CompanyNip { get; set; }
    string CompanyLocalizations { get; set; }
    string CompanyWebsites { get; set; }
    string CompanyDescription { get; set; }
    string CompanyToggleIsActiveBtnText { get; set; }

    string SidePanelTarget { get; set; }
    string SidePanelSearchValue { get; set; }
    string SidePanelSelectedFilter { get; set; }
    bool SidePanelSearchOnlyActive { get; set; }
    string SidePanelToggleIsActiveBtnText { get; set; }


    int EmployeeId { get; set; }
    string EmployeeIsActiveInfo { get; set; }
    string EmployeeName { get; set; }
    string EmployeeProfession { get; set; }
    string EmployeePhoneNumbers { get; set; }
    string EmployeeEmails { get; set; }
    string EmployeeWebsites { get; set; }
    string EmployeeIPs { get; set; }
    string EmployeeDescription { get; set; }


    #endregion


    #region Events
    event EventHandler CloseRightPanelBtnClicked;
    event EventHandler CompanySearchBtnClicked;
    event EventHandler CompanyShowDetailsBtnClicked;
    event EventHandler CompanyAddBtnClicked;
    event EventHandler CompanyEditBtnClicked;
    event EventHandler CompanyShowEmployeesBtnClicked;
    event EventHandler CompanySaveBtnClicked;
    event EventHandler CompanyEditCancelBtnClicked;
    event EventHandler CompanyToggleIsActiveBtnClicked;

    event EventHandler SidePanelSearchBtnClicked;
    event EventHandler SidePanelShowDetailsBtnClicked;
    event EventHandler SidePanelAddBtnClicked;
    event EventHandler SidePanelEditBtnClicked;
    event EventHandler SidePanelSaveBtnClicked;
    event EventHandler SidePanelEditCancelBtnClicked;
    event EventHandler SidePanelToggleIsActiveBtnClicked;
    #endregion


    #region Methods
    void SetCompanyListBindingSource(BindingSource companyList);
    void SetSidePanelListBindingSource(BindingSource modelList);

    void SetCompanyEditBtnToEnabled(bool enabled);
    void SetSidePanelEditBtnToEnabled(bool enabled);

    #endregion

}