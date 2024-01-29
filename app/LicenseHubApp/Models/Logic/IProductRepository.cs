using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Models;

public interface IProductRepository : IGenericRepository<ProductModel>
{
    bool IsNameUnique(int id, string name);
    Task CreateRelease(int productId, ProductReleaseModel releaseModel);
    Task DeleteRelease(int productId, ProductReleaseModel releaseModel);
}