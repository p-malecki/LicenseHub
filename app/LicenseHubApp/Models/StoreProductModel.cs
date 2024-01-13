using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LicenseHubApp.Models
{
    [PrimaryKey(nameof(Id))]
    [Microsoft.EntityFrameworkCore.Index(nameof(Name), IsUnique = true)]
    public class StoreProductModel : ValidatableModel, IModelWithId
    {
        [DisplayName("StoreProduct ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
        public int Id { get; set; }

        [DisplayName("StoreProduct name")]
        [Required(ErrorMessage = "{0} is Required")]
        public string Name { get; set; }

        [DisplayName("StoreProduct IsAvailable")]
        public bool IsAvailable { get; set; }

        [Browsable(false)]
        public ICollection<StoreProductReleaseModel> Releases { get; set; } = new List<StoreProductReleaseModel>();
    }
}
