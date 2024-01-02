namespace LicenseHubApp.Views.Interfaces;

public interface ILoginView
{
    // Properties
    string Username { get; set; }
    string Password { get; set; }
    string IncorrectLoginMessage { get; set; }

    // Events
    event EventHandler LoginBtnClicked;
}