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
}