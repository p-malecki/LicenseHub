using System.ComponentModel;
namespace LicenseHubApp.Models;

public class SubscriptionLicenseModel : LicenseModel
{
    [DisplayName("Lease term in days")]
    public int LeaseTermInDays { get; set; }
    
    private SubscriptionLicenseModel(int leaseTermInDays, DateTime registerDate, DateTime activationDate)
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


    public override bool IsActive()
    {
        throw new NotImplementedException();
    }

    public override DateTime ExpirationDate()
    {
        throw new NotImplementedException();
    }

}