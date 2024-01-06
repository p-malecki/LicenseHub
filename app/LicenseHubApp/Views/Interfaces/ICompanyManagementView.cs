namespace LicenseHubApp.Views.Interfaces;

public interface ICompanyManagementView
{
    #region Properties
    bool IsSuccessful { get; set; }
    string Message { get; set; }
    bool IsEdit { get; set; }

    string SearchValue { get; set; }
    string SelectedFilter { get; set; }
    bool SearchOnlyActiveCompanies { get; set; }

    int CompanyId { get; set; }
    string CompanyIsActiveInfo { get; set; }
    string CompanyName { get; set; }
    string CompanyNip { get; set; }
    string CompanyLocalizations { get; set; }
    string CompanyWebsites { get; set; }
    string CompanyDescription { get; set; }
    string ToggleIsActiveBtnText { get; set; }
    #endregion


    #region Events
    event EventHandler SearchBtnClicked;
    event EventHandler ShowDetailsBtnClicked;
    event EventHandler EditBtnClicked;
    event EventHandler AddBtnClicked;
    event EventHandler CloseRightPanelBtnClicked;
    event EventHandler SaveBtnClicked;
    event EventHandler EditCancelBtnClicked;
    event EventHandler ToggleIsActiveBtnClicked;
    #endregion


    #region Methods
    void SetUserListBindingSource(BindingSource userList);
    #endregion

}