using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LicenseHubApp.Models
{
    [PrimaryKey(nameof(Id))]
    public class WorkstationModel : ValidatableModel, IModelWithId
    {
        [DisplayName("Workstation ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
        public int Id { get; set; }

        [Browsable(false)]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        [Browsable(false)]
        public CompanyModel Company { get; set; }


        [DisplayName("Workstation ComputerName")]
        [Required(ErrorMessage = "{0} is Required")]
        public string ComputerName { get; set; }

        [DisplayName("Workstation Username")]
        public string Username { get; set; }

        [DisplayName("Workstation HardDisk")]
        public string HardDisk { get; set; }

        [DisplayName("Workstation Cpu")]
        public string Cpu { get; set; }

        [DisplayName("Workstation BiosVersion")]
        public string BiosVersion { get; set; }

        [DisplayName("Workstation Os")]
        public string Os { get; set; }

        [DisplayName("Workstation OsBitVersion")]
        public string OsBitVersion { get; set; }

        [DisplayName("Workstation HasFault")]
        [Required(ErrorMessage = "{0} is Required")]
        public bool HasFault { get; set; }

        public List<WorkstationProductModel> WorkstationProducts { get; set; }
    }
}
