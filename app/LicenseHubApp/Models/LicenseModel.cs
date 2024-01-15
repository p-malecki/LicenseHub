using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace LicenseHubApp.Models;

public abstract class LicenseModel
{
    [Key]
    [DisplayName("LicenseID")]
    public int Id { get; set; }

    [DisplayName("Register date")]
    public DateTime RegisterDate { get; set; }

    [DisplayName("Activation date")]
    public DateTime ActivationDate { get; set; }

    [DisplayName("Activation code")]
    public ActivationCodeModel? ActivationCode { get; set; }


    public abstract bool IsActive();
    public abstract DateTime ExpirationDate();
}