using LicenseHubApp.Models;
namespace LicenseHubApp.Services;

public abstract class LicenseCreator
{
    protected ILicenseActivationCodeStrategy? Strategy;
    
    public abstract ILicense CreateLicense(DateTime? registerDate, DateTime? activationDate);

    public void SetStrategy(ILicenseActivationCodeStrategy strategy)
    {
        Strategy = strategy;
    }
}