using LicenseHubApp.Models.Filters;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Models;

public interface IEmployeeRepository : IGenericRepository<EmployeeModel>
{
    void SetFilterStrategy(IFilterStrategy<EmployeeModel> fs);
    IEnumerable<EmployeeModel> FilterEmployee(string filterValue);
}
