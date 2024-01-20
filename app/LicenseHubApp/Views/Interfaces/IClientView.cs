namespace LicenseHubApp.Views.Interfaces;

public interface IClientView
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


    int WorkstationId { get; set; }
    string WorkstationHasFaultInfo { get; set; }
    string WorkstationComputerName { get; set; }
    string WorkstationUsername { get; set; }
    string WorkstationHardDisk { get; set; }
    string WorkstationCpu { get; set; }
    string WorkstationBiosVersion { get; set; }
    string WorkstationOs { get; set; }
    string WorkstationOsBitVersion { get; set; }


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
    event EventHandler CompanyShowWorkstationsBtnClicked;

    event EventHandler SidePanelSearchBtnClicked;
    event EventHandler SidePanelShowSelectedBtnClicked;
    event EventHandler SidePanelAddBtnClicked;
    event EventHandler SidePanelEditBtnClicked;
    event EventHandler SidePanelSaveBtnClicked;
    event EventHandler SidePanelEditCancelBtnClicked;
    event EventHandler SidePanelToggleIsActiveBtnClicked;
    event EventHandler SidePanelGoToDetailsBtnClicked;

    #endregion


    #region Methods
    void SetCompanyListBindingSource(BindingSource companyList);
    void SetSidePanelListBindingSource(BindingSource modelList);

    void SetCompanyViewToSelectable(bool enabled);
    void SetSidePanelViewToSelectable(bool enabled);
    void SetPanelToEditable(bool editable);

    #endregion

}