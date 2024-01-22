using LicenseHubApp.Models;
namespace LicenseHubApp.Services;

public interface ILicense
{
    DateTime? RegisterDate { get; set; }
    DateTime? ActivationDate { get; set; }
    ActivationCodeModel? ActivationCode { get; set; }

    //bool IsActive();
    //DateTime ExpirationDate();
}