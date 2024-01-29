namespace LicenseHubApp.Models;

public partial class PerpetualLicenseModel : LicenseModel
{
    public PerpetualLicenseModel() // required by orm
    {
        RegisterDate = null;
        ActivationDate = null;
        ActivationCode = null;
    }
}

