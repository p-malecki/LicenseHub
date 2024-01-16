using LicenseHubApp.Models;
namespace LicenseHubApp.Services;

public abstract class PerpetualLicenseCreator : LicenseCreator
{
    public override ILicense CreateLicense(DateTime? registerDate, DateTime? activationDate)
    {
        if (Strategy == null)
            throw new NullReferenceException();

        var newActivationCode = Strategy.GetLicenseActivationCode();
        var license = new PerpetualLicenseModel(registerDate, activationDate, newActivationCode) as ILicense;

        return license!;
    }
}