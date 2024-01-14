namespace LicenseHubApp.Models
{
    public interface IProductRepository : IModelRepository<ProductModel>
    {
        bool IsNameUnique(int modelId, string modelName);

        Task AddReleaseAsync(int productId, ProductReleaseModel releaseModel);
        Task RemoveReleaseAsync(int productId, ProductReleaseModel releaseModel);
    }
}
