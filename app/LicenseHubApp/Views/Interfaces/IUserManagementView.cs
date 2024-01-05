namespace LicenseHubApp.Views.Interfaces;

public interface IUserManagementView
{

    #region Properties
    int Id { get; set; }
    string Username { get; set; }
    string Password { get; set; }
    bool IsAdmin { get; set; }

    bool IsEdit { get; set; }
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    #endregion


    #region Events

    event EventHandler AddBtnClicked;
    event EventHandler EditBtnClicked;
    event EventHandler DeleteBtnClicked;
    event EventHandler SaveBtnClicked;
    event EventHandler CancelBtnClicked;

    #endregion


    #region Methods
    void SetUserListBindingSource(BindingSource userList);
    #endregion

}