using LicenseHubApp.Utils;

namespace LicenseHubApp.Models.Filters
{
    public class EmployeeEmailFilterStrategy : IFilterStrategy<EmployeeModel>
    {
        public IEnumerable<EmployeeModel> Filter(IEnumerable<EmployeeModel> models, string filterValue)
        {
            return models
                .Where(m => ListStoredInStringParser.ParseSingleLineToList(m.Emails)
                    .Any(e => e.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase))
                ).ToList();
        }
    }
}
