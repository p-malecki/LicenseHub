namespace LicenseHubApp.Views.Interfaces;

public interface ILoginView
{
    #region Properties
    string Username { get; set; }
    string Password { get; set; }
    string IncorrectLoginMessage { get; set; }

    #endregion


    #region Events
    event EventHandler LoginBtnClicked;

    #endregion
}