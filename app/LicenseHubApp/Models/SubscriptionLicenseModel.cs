using System.ComponentModel;
namespace LicenseHubApp.Models;

public partial class SubscriptionLicenseModel : LicenseModel
{
    [DisplayName("Lease term in days")]
    public int LeaseTermInDays { get; set; }

    private SubscriptionLicenseModel() // required by orm
    {
        LeaseTermInDays = -1;
        RegisterDate = null;
        ActivationDate = null;
        ActivationCode = null;
    }
    public SubscriptionLicenseModel(int leaseTermInDays)
    {
        LeaseTermInDays = -1;
        RegisterDate = null;
        ActivationDate = null;
        LeaseTermInDays = leaseTermInDays;
    }
}