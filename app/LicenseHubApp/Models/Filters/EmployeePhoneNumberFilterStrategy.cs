using LicenseHubApp.Utils;

namespace LicenseHubApp.Models.Filters
{
    public class EmployeePhoneNumberFilterStrategy : IFilterStrategy<EmployeeModel>
    {
        public IEnumerable<EmployeeModel> Filter(IEnumerable<EmployeeModel> models, string filterValue)
        {
            return models
                .Where(m => ListStoredInStringParser.ParseSingleLineToList(m.PhoneNumbers)
                    .Any(p => p.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase))
                ).ToList();
        }
    }
}
