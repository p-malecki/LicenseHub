namespace LicenseHubApp.Views.Interfaces;

public interface IUserManagementView
{
    // Properties
    int Id { get; set; }
    string Username { get; set; }
    string Password { get; set; }
    bool IsAdmin { get; set; }

    bool IsEdit { get; set; }
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    // Events
    event EventHandler AddBtnClicked;
    event EventHandler EditBtnClicked;
    event EventHandler DeleteBtnClicked;
    event EventHandler SaveBtnClicked;
    event EventHandler CancelBtnClicked;


    // Methods
    void SetUserListBindingSource(BindingSource userList);

}