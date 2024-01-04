namespace LicenseHubApp.Views.Interfaces;

public interface IMainView
{
    // Properties
    string LoggedInUser { get; set; }

    Control.ControlCollection ClientTabPageCollection { get; }


    // Events
    event EventHandler DashboardBtnClicked;
    event EventHandler ClientsBtnClicked;
    event EventHandler OrdersBtnClicked;
    event EventHandler ProductsBtnClicked;
    event EventHandler LicencesBtnClicked;
    event EventHandler ReportsBtnClicked;
    event EventHandler SettingsBtnClicked;
    event EventHandler LogoutBtnClicked;
}