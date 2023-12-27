using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace LicenseHubApp.Models
{
    internal class UserModel
    {
        [Required(ErrorMessage = "Id is Required")]
        public required string Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MaxLength(50)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Incorrect Password Format")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "IsAdmin is Required")]
        public required bool IsAdmin { get; set; }

    }
}
