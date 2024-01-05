using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseHubApp.Models
{
    [PrimaryKey(nameof(Id), nameof(Name), nameof(Nip))]
    [Index(nameof(Id), IsUnique = true)]
    [Index(nameof(Name), IsUnique = true)]
    [Index(nameof(Nip), IsUnique = true)]
    public class CompanyModel : ValidatableModel, IModelWithId
    {
        // Properties - to Validate
        [DisplayName("Company ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
        public int Id { get; set; }

        [DisplayName("Company isActive")]
        public bool IsActive { get; set; } = true;

        [DisplayName("Company Name")]
        [Required(ErrorMessage = "{0} is Required")]
        [StringLength(96, MinimumLength = 3)]
        public string Name { get; set; }

        [DisplayName("Company NIP")]
        [Required(ErrorMessage = "{0} is Required")]
        [RegularExpression(@"^(?:\d{10}|0)$", ErrorMessage = "Incorrect NIP Length")]
        public string Nip { get; set; }

        [DisplayName("Company Localizations")]
        [Browsable(false)]
        public string Localizations { get; set; } = "";

        [DisplayName("Company Websites")]
        [Browsable(false)]
        public string Websites { get; set; } = "";

        [DisplayName("Company Description")]
        [Browsable(false)]
        public string Description { get; set; } = "";
        //public IEmployeeManager EmployeeManager { get; set; }
        //public IWorkstationManager WorkstationManager { get; set; }
        //public IOrderManager OrderManager { get; set; }

    }
}
