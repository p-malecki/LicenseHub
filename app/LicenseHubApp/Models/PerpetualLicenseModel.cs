namespace LicenseHubApp.Models;

public partial class PerpetualLicenseModel : LicenseModel
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
}

