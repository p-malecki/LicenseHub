using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;


namespace LicenseHubApp.Models
{
    [PrimaryKey(nameof(Id))]
    [Index(nameof(Username), IsUnique = true)]
    public class UserModel : ValidatableModel, IModelWithId
    {
        // Properties - to Validate
        [DisplayName("User ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
        public int Id { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "{0} is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Username { get; set; }

        [DisplayName("User Password")]
        [Browsable(false)]
        [Required(ErrorMessage = "{0} is Required")]
        [MaxLength(50)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Incorrect Password Format")]
        public string Password { get; set; }

        [DisplayName("User IsAdmin")]
        public bool IsAdmin { get; set; }
    }
}
