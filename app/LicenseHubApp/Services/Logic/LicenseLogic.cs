namespace LicenseHubApp.Models;

public abstract partial class LicenseModel
{
    public abstract bool IsActive();
    public abstract DateTime ExpirationDate();
}