using LicenseHubApp.Models.Filters;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Models;

public interface ICompanyRepository : IGenericRepository<CompanyModel>
{
    Task CreateEmployee(int companyId, EmployeeModel employeeModel);
    Task DeleteEmployee(int companyId, EmployeeModel employeeModel);
    Task CreateWorkstation(int companyId, WorkstationModel workstationModel);
    Task DeleteWorkstation(int companyId, WorkstationModel workstationModel);
    void SetFilterStrategy(IFilterStrategy<CompanyModel> fs);
    IEnumerable<CompanyModel> FilterCompany(string filterValue);
}