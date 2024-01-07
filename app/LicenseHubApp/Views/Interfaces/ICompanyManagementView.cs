namespace LicenseHubApp.Views.Interfaces;

public interface ICompanyManagementView
{
    #region Properties
    bool IsSuccessful { get; set; }
    string Message { get; set; }
    bool CompanyIsEdit { get; set; }

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
    #endregion


    #region Events
    event EventHandler CloseRightPanelBtnClicked;
    event EventHandler CompanySearchBtnClicked;
    event EventHandler CompanyShowDetailsBtnClicked;
    event EventHandler CompanyEditBtnClicked;
    event EventHandler CompanyAddBtnClicked;
    event EventHandler CompanySaveBtnClicked;
    event EventHandler CompanyEditCancelBtnClicked;
    event EventHandler CompanyToggleIsActiveBtnClicked;
    #endregion


    #region Methods
    void SetCompanyListBindingSource(BindingSource companyList);
    #endregion

}