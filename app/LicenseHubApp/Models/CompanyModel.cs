using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LicenseHubApp.Models;


[Microsoft.EntityFrameworkCore.Index(nameof(Name), IsUnique = true)]
[Microsoft.EntityFrameworkCore.Index(nameof(Nip), IsUnique = true)]
public class CompanyModel : ValidatableModel, IModelWithId
{
    [Key]
    [DisplayName("Company ID")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Browsable(false)]
    [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
    public int Id { get; set; }

    [DisplayName("Is active")]
    public bool IsActive { get; set; } = true;

    [DisplayName("Company Name")]
    [Required(ErrorMessage = "{0} is Required")]
    [StringLength(96, MinimumLength = 3)]
    public string Name { get; set; }

    [DisplayName("NIP")]
    [Required(ErrorMessage = "{0} is Required")]
    [RegularExpression(@"^(?:\d{10}|0)$", ErrorMessage = "Incorrect NIP Length")]
    public string Nip { get; set; }

    [Browsable(false)]
    public string Localizations { get; set; } = "";

    [Browsable(false)]
    public string Websites { get; set; } = "";

    [Browsable(false)]
    public string Description { get; set; } = "";


    [Browsable(false)]
    [Description("Employees who work for the company.")]
    public ICollection<EmployeeModel> Employees { get; set; } = new List<EmployeeModel>();

    [Browsable(false)]
    [Description("Workstations owned by the company.")]
    public ICollection<WorkstationModel> Workstations { get; set; } = new List<WorkstationModel>();

    [Browsable(false)]
    [Description("Orders placed by the company.")]
    public ICollection<OrderModel> Orders { get; set; } = new List<OrderModel>();

}