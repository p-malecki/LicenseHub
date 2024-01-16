namespace LicenseHubApp.Models;

public class PerpetualLicenseModel : LicenseModel
{
    private PerpetualLicenseModel(DateTime? registerDate, DateTime? activationDate)
    {
        RegisterDate = registerDate;
        ActivationDate = activationDate;
        ActivationCode = null;
    }

    public PerpetualLicenseModel(DateTime? registerDate, DateTime? activationDate, ActivationCodeModel code)
    {
        RegisterDate = registerDate;
        ActivationDate = activationDate;
        ActivationCode = code;
    }


    public override bool IsActive() => true;

    public override DateTime ExpirationDate()
    {
        throw new NotImplementedException();
    }

}

