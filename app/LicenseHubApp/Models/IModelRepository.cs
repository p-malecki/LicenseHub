namespace LicenseHubApp.Models
{
    public interface IModelRepository<TModel>
    {
        Task AddAsync(TModel model);
        Task EditAsync(int modelId, TModel updatedModel);
        Task DeleteAsync(int id);
        Task<TModel?> GetModelByIdAsync(int id);
        Task<IList<TModel>> GetAllAsync();
        bool IsIdUnique(int id);
    }
}
