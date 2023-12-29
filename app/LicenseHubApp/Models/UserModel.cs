using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Security.Cryptography;


namespace LicenseHubApp.Models
{
    public class UserModel: ValidatableModel
    {
        // Fields
        private string _name;

        // Properties - to Validate
        [DisplayName("User ID")]
        [Range(0, int.MaxValue, ErrorMessage = "ID must be non negative")]
        public int Id { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length is >= 3 and <= 50)
                {
                    _name = value;
                }
            }
        }

        [DisplayName("User Password")]
        [Required(ErrorMessage = "Password is Required")]
        [MaxLength(50)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Incorrect Password Format")]
        public string Password { get; set; }

        [DisplayName("User IsAdmin")]
        public bool IsAdmin { get; set; }
    }
}
