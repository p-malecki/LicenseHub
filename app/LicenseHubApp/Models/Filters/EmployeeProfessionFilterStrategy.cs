
namespace LicenseHubApp.Models.Filters
{
    public class EmployeeProfessionFilterStrategy : IFilterStrategy<EmployeeModel>
    {
        public IEnumerable<EmployeeModel> Filter(IEnumerable<EmployeeModel> models, string filterValue)
        {
            return models.Where(m => m.Profession.Contains(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
