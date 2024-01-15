using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LicenseHubApp.Models
{
    [PrimaryKey(nameof(Id))]
    [Microsoft.EntityFrameworkCore.Index(nameof(ReleaseNumber), IsUnique = true)]
    public class ProductReleaseModel : ValidatableModel, IModelWithId, IComparable<ProductReleaseModel>
    {
        [DisplayName("Release ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        [Browsable(false)]
        public ProductModel Product { get; set; }


        [DisplayName("ReleaseNumber")]
        [Required(ErrorMessage = "{0} is Required")]
        public string ReleaseNumber { get; set; }

        [DisplayName("Release InstallerVerificationPasscode")]
        [Browsable(false)]
        public string InstallerVerificationPasscode { get; set; } = string.Empty;


        [DisplayName("Release Description")]
        [Browsable(false)]
        public string Description { get; set; } = string.Empty;


        public int CompareTo(ProductReleaseModel? other)
        {
            return string.Compare(ReleaseNumber, other?.ReleaseNumber,  StringComparison.OrdinalIgnoreCase);
        }
    }
}
