using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LicenseHubApp.Models
{
    [Index(nameof(UserModel.Username), IsUnique = true)]
    public class UserModel : ValidatableModel, IModelWithId
    {
        // Properties - to Validate
        [DisplayName("User ID")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be non negative")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "{0} is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Username { get; set; }

        [DisplayName("User Password")]
        [Required(ErrorMessage = "{0} is Required")]
        [MaxLength(50)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Incorrect Password Format")]
        [System.ComponentModel.Browsable(false)]
        public string Password { get; set; }

        [DisplayName("User IsAdmin")]
        public bool IsAdmin { get; set; }
    }
}
