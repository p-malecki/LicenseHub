using LicenseHubApp.Services;

namespace LicenseHubApp.Models;

public partial class LicenseModel
{
    public bool IsPerpetual()
    {
        return LeaseTermInDays <= 0;
    }

    public bool IsActive()
    {
        if (IsPerpetual())
            return true;
        return DateTime.Now < ExpirationDate();
    }

    public DateTime ExpirationDate()
    {
        if (IsPerpetual())
            return DateTime.MaxValue;

        if (!ActivationDate.HasValue)
            throw new InvalidOperationException("ActivationDate cannot be null.");

        return ActivationDate.Value.AddDays(LeaseTermInDays);
    }

    public void Register(DateTime registerDate)
    {
        RegisterDate = registerDate;
    }

    public void Activate(DateTime activationDate, ActivationCodeModel activationCode)
    {
        ActivationDate = activationDate;
        ActivationCode = activationCode;
    }

    public void ActivateWithSimpleActivationCode(DateTime activationDate, string activationCode)
    {
        ActivationDate = activationDate;
        ActivationCode = new ActivationCodeModel(activationCode);
    }

    public void ActivateWithGeneratedActivationCode(DateTime activationDate, IActivationCodeGenerator generator)
    {
        ActivationDate = activationDate;
        ActivationCode = new GeneratedActivationCodeModel(generator.Generate(), generator.GetVersion());
    }
}