namespace LicenseHubApp.Models
{
    public interface IProductRepository : IModelRepository<ProductModel>
    {
        Task AddReleaseAsync(int productId, ProductReleaseModel releaseModel);
        Task RemoveReleaseAsync(int productId, ProductReleaseModel releaseModel);
    }
}
