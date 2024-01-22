using LicenseHubApp.Models;
namespace LicenseHubApp.Repositories.GenericRepository;

public interface IGenericRepository<TModel> where TModel : ValidatableModel, IModelWithId
{
    IEnumerable<TModel> GetAll();
    Task<TModel?> GetById(int id);
    Task Create(TModel model);
    Task Update(int id, TModel model);
    Task Delete(int id);
    bool IsIdUnique(int id);
}