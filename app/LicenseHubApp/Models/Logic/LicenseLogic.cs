using LicenseHubApp.Services;

namespace LicenseHubApp.Models;

public abstract partial class LicenseModel
{
    public abstract bool IsActive();
    public abstract DateTime ExpirationDate();

    public virtual void Register(DateTime registerDate)
    {
        RegisterDate = registerDate;
    }

    public virtual void Activate(DateTime activationDate, ActivationCodeModel activationCode)
    {
        ActivationDate = activationDate;
        ActivationCode = activationCode;
    }

    public virtual void ActivateWithSimpleActivationCode(DateTime activationDate, string activationCode)
    {
        ActivationDate = activationDate;
        ActivationCode = new ActivationCodeModel(activationCode);
    }

    public virtual void ActivateWithGeneratedActivationCode(DateTime activationDate, IActivationCodeGenerator generator)
    {
        ActivationDate = activationDate;
        ActivationCode = new GeneratedActivationCodeModel(generator.Generate(), generator.GetVersion());
    }
}