namespace LicenseHubApp.Models
{
    public interface ICompanyRepository : IModelRepository<CompanyModel>
    {
        Task AddEmployeeAsync(int companyId, EmployeeModel employeeModel);
        Task RemoveEmployeeAsync(int companyId, EmployeeModel employeeModel);
        Task AddWorkstationAsync(int companyId, WorkstationModel workstationModel);
        Task RemoveWorkstationAsync(int companyId, WorkstationModel workstationModel);
    }
}
