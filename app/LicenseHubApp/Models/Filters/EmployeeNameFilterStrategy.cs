
namespace LicenseHubApp.Models.Filters
{
    public class EmployeeNameFilterStrategy : IFilterStrategy<EmployeeModel>
    {
        public IEnumerable<EmployeeModel> Filter(IEnumerable<EmployeeModel> models, string filterValue)
        {
            return models.Where(m => m.Name.Contains(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
