using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LicenseHubApp.Models
{
    internal class UserModel
    {
        [Required(ErrorMessage = "Id is Required")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MaxLength(50)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Incorrect Password Format")]
        public string _Password { get; set; }

        [Required(ErrorMessage = "IsAdmin is Required")]
        public string _IsAdmin { get; set; }

    }
}
