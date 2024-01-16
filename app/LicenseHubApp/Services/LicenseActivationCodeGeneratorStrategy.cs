using LicenseHubApp.Models;
namespace LicenseHubApp.Services;

public class LicenseActivationCodeGeneratorStrategy(IActivationCodeGenerator generator) : ILicenseActivationCodeStrategy
{
    public ActivationCodeModel GetLicenseActivationCode()
    {
        return new GeneratedActivationCodeModel(generator.Generate(), generator.GetVersion());
    }
}