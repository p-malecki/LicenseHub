namespace LicenseHubApp.Models;

public partial class SubscriptionLicenseModel : LicenseModel
{
    public override bool IsActive()
    {
        return DateTime.Now < ExpirationDate();
    }

    public override DateTime ExpirationDate()
    {
        if (!ActivationDate.HasValue)
            throw new InvalidOperationException("ActivationDate cannot be null.");
        
        return ActivationDate.Value.AddDays(LeaseTermInDays);
    }
}