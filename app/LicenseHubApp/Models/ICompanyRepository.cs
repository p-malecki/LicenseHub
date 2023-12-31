namespace LicenseHubApp.Models
{
    public interface ICompanyRepository
    {
        Task AddAsync(CompanyModel company);
        Task EditAsync(int modelId, CompanyModel updatedModel);
        Task DeleteAsync(int id);
        Task<CompanyModel?> GetCompanyByIdAsync(int id);
        Task<IList<CompanyModel>> GetAllAsync();
        bool IsIdUnique(int id);
    }
}
