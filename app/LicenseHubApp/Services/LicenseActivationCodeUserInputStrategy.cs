using LicenseHubApp.Models;
namespace LicenseHubApp.Services;

public class LicenseActivationCodeUserInputStrategy(string code) : ILicenseActivationCodeStrategy
{
    public ActivationCodeModel GetLicenseActivationCode()
    {
        return new ActivationCodeModel(code);
    }
}