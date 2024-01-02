using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseHubApp.Models
{
    [PrimaryKey(nameof(CompanyModel.Name), nameof(CompanyModel.Nip))]
    [Index(nameof(CompanyModel.Name), IsUnique = true)]
    [Index(nameof(CompanyModel.Nip), IsUnique = true)]
    public class CompanyModel : ValidatableModel, IModelWithId
    {
        // Properties - to Validate
        [DisplayName("Company ID")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Company Name")]
        [Required(ErrorMessage = "{0} is Required")]
        [StringLength(96, MinimumLength = 3)]
        public string Name { get; set; }

        [DisplayName("Company NIP")]
        [Required(ErrorMessage = "{0} is Required")]
        [RegularExpression(@"^(?:\d{10}|0)$", ErrorMessage = "Incorrect NIP Length")]
        public string Nip { get; set; }

        [DisplayName("Company Localizations")]
        public List<string> Localizations { get; set; } = new();

        [DisplayName("Company Websites")]
        public List<string> Websites { get; set; } = new();

        [DisplayName("Company Description")] public string Description { get; set; } = "";
        //public IEmployeeManager EmployeeManager { get; set; }
        //public IWorkstationManager WorkstationManager { get; set; }
        //public IOrderManager OrderManager { get; set; }

    }
}
