namespace LicenseHubApp.Models
{
    public interface IModelRepository<TModel>
    {
        Task AddAsync(TModel model);
        Task EditAsync(int modelId, TModel updatedModel);
        Task DeleteAsync(int modelId);
        Task<TModel?> GetModelByIdAsync(int modelId);
        Task<IList<TModel>> GetAllAsync();
        bool IsIdUnique(int modelId);
    }
}
