using LicenseHubApp.Models;
namespace LicenseHubApp.Services;

public abstract class SubscriptionLicenseCreator : LicenseCreator
{
    public override ILicense CreateLicense(DateTime? registerDate, DateTime? activationDate)
    {
        if (Strategy == null)
            throw new NullReferenceException();

        var newActivationCode = Strategy.GetLicenseActivationCode();
        // TODO set leaseTermInDays properly
        var license = new SubscriptionLicenseModel(1, registerDate, activationDate, newActivationCode) as ILicense;

        return license!;
    }
}