namespace LicenseHubApp.Models;

public interface IActivationCodeRepository : IModelRepository<ActivationCodeModel>
{
    Task AddGeneratedActivationCodeAsync(GeneratedActivationCodeModel model);
    Task DeleteGeneratedActivationCodeAsync(int modelId);
    Task EditGeneratedActivationCodeAsync(int modelId, GeneratedActivationCodeModel updatedModel);
    Task<GeneratedActivationCodeModel?> GetByIdGeneratedActivationCodeModelAsync(int modelId);
    Task<IList<GeneratedActivationCodeModel>> GetAllGeneratedActivationCodeAsync();

}