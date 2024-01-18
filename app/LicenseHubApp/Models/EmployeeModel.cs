using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseHubApp.Models;


public class EmployeeModel : ValidatableModel, IModelWithId
{
    [Key]
    [DisplayName("Employee ID")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Browsable(false)]
    [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
    public int Id { get; set; }

    [DisplayName("Name")]
    [Required(ErrorMessage = "{0} is Required")]
    public string Name { get; set; }

    [DisplayName("Is active")]
    public bool IsActive { get; set; } = true;

    [DisplayName("Profession")]
    public string Profession { get; set; }

    [Browsable(false)]
    public string PhoneNumbers { get; set; }

    [Browsable(false)]
    public string Emails { get; set; }

    [Browsable(false)]
    public string Websites { get; set; }

    [Browsable(false)]
    public string IPs { get; set; }

    [Browsable(false)]
    public string Description { get; set; }

    [Browsable(false)]
    public int CompanyId { get; set; }

    [ForeignKey("CompanyId")]
    [Browsable(false)]
    [Description("The company where the employee works.")]
    public CompanyModel Company { get; set; }

    [Browsable(false)]
    [Description("Workstations used by the employee.")]
    public ICollection<WorkstationModel> Workstations { get; set; } = new List<WorkstationModel>();
}