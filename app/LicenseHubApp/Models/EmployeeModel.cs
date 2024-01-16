using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseHubApp.Models
{
    [PrimaryKey(nameof(Id))]
    public class EmployeeModel : ValidatableModel, IModelWithId
    {
        [DisplayName("Employee ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
        public int Id { get; set; }

        [Browsable(false)]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        [Browsable(false)]
        [Description("The company where the employee works.")]
        public CompanyModel Company { get; set; }


        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "{0} is Required")]
        public string Name { get; set; }

        [DisplayName("Employee isActive")]
        public bool IsActive { get; set; } = true;

        [DisplayName("Employee Profession")]
        public string Profession { get; set; }

        [DisplayName("Employee PhoneNumbers")]
        [Browsable(false)]
        public string PhoneNumbers { get; set; }

        [DisplayName("Employee Emails")]
        [Browsable(false)]
        public string Emails { get; set; }

        [DisplayName("Employee Websites")]
        [Browsable(false)]
        public string Websites { get; set; }

        [DisplayName("Employee IPs")]
        [Browsable(false)]
        public string IPs { get; set; }

        [DisplayName("Employee Description")]
        [Browsable(false)]
        public string Description { get; set; }

        [Browsable(false)]
        [Description("Workstations used by the employee.")]
        public ICollection<WorkstationModel> Workstations { get; set; } = new List<WorkstationModel>();
    }
}
