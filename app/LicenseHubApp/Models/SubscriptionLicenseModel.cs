using System.ComponentModel;
namespace LicenseHubApp.Models;

public partial class SubscriptionLicenseModel : LicenseModel
{
    [DisplayName("Lease term in days")]
    public int LeaseTermInDays { get; set; }

    private SubscriptionLicenseModel(DateTime? registerDate, DateTime? activationDate)
    {
        LeaseTermInDays = -1;
        RegisterDate = registerDate;
        ActivationDate = activationDate;
        ActivationCode = null;
    }
    private SubscriptionLicenseModel(int leaseTermInDays, DateTime? registerDate, DateTime? activationDate)
    {
        LeaseTermInDays = leaseTermInDays;
        RegisterDate = registerDate;
        ActivationDate = activationDate;
        ActivationCode = null;
    }
    public SubscriptionLicenseModel(int leaseTermInDays, DateTime? registerDate, DateTime? activationDate, ActivationCodeModel code)
    {
        LeaseTermInDays = leaseTermInDays;
        RegisterDate = registerDate;
        ActivationDate = activationDate;
        ActivationCode = code;
    }
}