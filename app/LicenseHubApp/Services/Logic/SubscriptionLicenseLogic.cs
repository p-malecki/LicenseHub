namespace LicenseHubApp.Models;

public partial class SubscriptionLicenseModel : LicenseModel
{
    public override bool IsActive()
    {
        throw new NotImplementedException();
    }

    public override DateTime ExpirationDate()
    {
        throw new NotImplementedException();
    }
}