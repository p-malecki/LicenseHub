using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace LicenseHubApp.Models;

public class WorkstationProductModel : ValidatableModel, IModelWithId
{
    [Key]
    [DisplayName("WorkstationProduct ID")]
    public int Id { get; set; }

    [DisplayName("Installer verification code")]
    public string InstallerVerificationCode { get; set; }

    [Browsable(false)]
    public LicenseModel License { get; set; }

    [Browsable(false)]
    public int ReleaseId { get; set; }

    [ForeignKey("ReleaseId")]
    [Browsable(false)]
    public ProductReleaseModel ProductRelease { get; set; }

    [Browsable(false)]
    public int WorkstationId { get; set; }

    [ForeignKey("WorkstationId")]
    [Browsable(false)]
    public WorkstationModel Workstation { get; set; }
}