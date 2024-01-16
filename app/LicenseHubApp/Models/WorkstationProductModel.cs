using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace LicenseHubApp.Models;

public class WorkstationProductModel
{
    [Key]
    [DisplayName("WorkstationProduct ID")]
    public int Id { get; set; }

    [DisplayName("Installer verification code")]
    public string InstallerVerificationCode { get; set; }

    [Browsable(false)]
    public LicenseModel License { get; set; }

    [Browsable(false)]
    public int ReleaseID { get; set; }

    [ForeignKey("ReleaseID")]
    [Browsable(false)]
    public ProductReleaseModel ProductRelease { get; set; }

}