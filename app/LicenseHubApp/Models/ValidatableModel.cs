using System.ComponentModel.DataAnnotations;

namespace LicenseHubApp.Models
{
    public abstract class ValidatableModel
    {
        public bool ThrowIfNotValid()
        {
            var context = new ValidationContext(this);
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(this, context, validationResults, true);

            if (!isValid)
            {
                var errorMsg = "";
                foreach (var validationResult in validationResults)
                {
                    errorMsg += validationResult.ErrorMessage + "\n";
                }

                throw new InvalidOperationException($"Model validation failed.\n{errorMsg}");
            }

            return isValid;
        }
    }
}
