using LicenseHubApp.Models;
namespace LicenseHubApp.Services;

public interface ILicenseActivationCodeStrategy
{
    ActivationCodeModel GetLicenseActivationCode();
}