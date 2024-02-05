using LicenseHubApp.Models;
namespace LicenseHubApp.Services;

public interface ILicense
{
    DateTime? RegisterDate { get; }
    DateTime? ActivationDate { get; }
    ActivationCodeModel? ActivationCode { get; }
    bool IsActive();
    DateTime ExpirationDate();
    void Register(DateTime registerDate);
    void ActivateWithSimpleActivationCode(DateTime activationDate, string activationCode);
    void ActivateWithGeneratedActivationCode(DateTime activationDate, IActivationCodeGenerator generator);
}