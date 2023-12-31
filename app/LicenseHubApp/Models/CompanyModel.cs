using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LicenseHubApp.Models
{
    public class CompanyModel : ValidatableModel
    {
        // Properties - to Validate
        [DisplayName("Company ID")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
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
