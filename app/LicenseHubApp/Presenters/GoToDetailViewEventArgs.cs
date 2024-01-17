using LicenseHubApp.Models;
namespace LicenseHubApp.Presenters;

public class GoToDetailViewEventArgs : EventArgs
{
    public EmployeeModel? Employee { get; set; } = null;
    public WorkstationModel? Workstation { get; set; } = null;
}
