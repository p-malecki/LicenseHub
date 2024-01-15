using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LicenseHubApp.Models;

public class ActivationCodeModel(string code)
{
    [Key]
    [DisplayName("ActivationCode ID")]
    public int Id { get; set; }

    [DisplayName("Activation code")]
    public string Code { get; set; } = code;


    [Browsable(false)]
    public int LicenseId { get; set; }

    [ForeignKey("LicenseId")]
    [Browsable(false)]
    public LicenseModel License { get; set; }
}