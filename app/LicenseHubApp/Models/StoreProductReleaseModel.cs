using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LicenseHubApp.Models
{
    [PrimaryKey(nameof(Id))]
    [Microsoft.EntityFrameworkCore.Index(nameof(ReleaseNumber), IsUnique = true)]
    public class StoreProductReleaseModel : ValidatableModel, IModelWithId
    {
        [DisplayName("Release ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
        public int Id { get; set; }

        [Browsable(false)]
        public int StoreProductId { get; set; }

        [ForeignKey("StoreProductId")]
        [Browsable(false)]
        public StoreProductModel StoreProduct { get; set; }


        [DisplayName("ReleaseNumber")]
        [Required(ErrorMessage = "{0} is Required")]
        public string ReleaseNumber { get; set; }

        [DisplayName("Release InstallerVerificationPasscode")]
        public string InstallerVerificationPasscode { get; set; } = string.Empty;


        [DisplayName("Release Description")]
        [Browsable(false)]
        public string Description { get; set; } = string.Empty;


    }
}
