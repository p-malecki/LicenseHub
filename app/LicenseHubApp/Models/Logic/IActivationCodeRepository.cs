using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Models;

public interface IActivationCodeRepository : IGenericRepository<ActivationCodeModel>
{
    Task<IList<GeneratedActivationCodeModel>> GetAllGeneratedActivationCode();
    Task<GeneratedActivationCodeModel?> GetByIdGeneratedActivationCodeModel(int id);
    Task CreateGeneratedActivationCode(GeneratedActivationCodeModel model);
    Task UpdateGeneratedActivationCode(int id, GeneratedActivationCodeModel model);
    Task DeleteGeneratedActivationCode(int id);
}