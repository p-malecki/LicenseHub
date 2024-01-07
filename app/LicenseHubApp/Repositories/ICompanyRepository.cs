namespace LicenseHubApp.Models
{
    public interface ICompanyRepository : IModelRepository<CompanyModel>
    {
        Task AddEmployeeAsync(int companyId, EmployeeModel model);
        Task RemoveEmployeeAsync(int companyId, EmployeeModel employeeModel);
    }
}
