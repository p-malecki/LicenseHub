using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseHubApp.Models
{
    public abstract class ValidatableModel
    {
        public bool Validate()
        {
            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();
            return Validator.TryValidateObject(this, context, results, true);
        }

        public List<ValidationResult> ValidateWithResults()
        {
            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();
            _ = Validator.TryValidateObject(this, context, results, true);
            return results;
        }
    }
}
