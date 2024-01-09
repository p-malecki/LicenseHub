using LicenseHubApp.Utils;

namespace LicenseHubApp.Models.Filters
{
    public class EmployeeIPsFilterStrategy : IFilterStrategy<EmployeeModel>
    {
        public IEnumerable<EmployeeModel> Filter(IEnumerable<EmployeeModel> models, string filterValue)
        {
            return models
                .Where(m => ListStoredInStringParser.ParseSingleLineToList(m.IPs)
                    .Any(e => e.Contains(filterValue, StringComparison.CurrentCultureIgnoreCase))
                ).ToList();
        }
    }
}
