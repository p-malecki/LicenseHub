using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LicenseHubApp.Models;


[Microsoft.EntityFrameworkCore.Index(nameof(Name), IsUnique = true)]
public class ProductModel : ValidatableModel, IModelWithId
{
    [Key]
    [DisplayName("Product ID")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
    public int Id { get; set; }

    [DisplayName("Product name")]
    [Required(ErrorMessage = "{0} is Required")]
    public string Name { get; set; }

    [DisplayName("Is available")]
    public bool IsAvailable { get; set; }

    [Browsable(false)]
    [Description("Product releases.")]
    public ICollection<ProductReleaseModel> Releases { get; set; } = new List<ProductReleaseModel>();
}

