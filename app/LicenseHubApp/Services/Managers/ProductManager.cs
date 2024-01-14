using LicenseHubApp.Models.Filters;
using LicenseHubApp.Models;

namespace LicenseHubApp.Services.Managers
{
    public class ProductManager : BaseModelManager<ProductModel>
    {
        private static readonly object LockObject = new();
        private static ProductManager? _instance;
        //private static IStoreProductReleaseModelRepository? ReleaseRepository;

        private ProductManager() { }
        public static ProductManager GetInstance(IProductRepository productRepository)//, IStoreProductReleaseModelRepository releaseRepository)
        {
            if (_instance == null)
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ProductManager();
                        Repository = productRepository;
                        //ReleaseRepository = releaseRepository;
                    }
                }
            }
            return _instance;
        }

        public void AddRelease(int productId, ProductReleaseModel releaseModel)
        {

            ((IProductRepository)Repository).AddReleaseAsync(productId, releaseModel);
        }

        public void ToggleIsAvailable(ProductModel model)
        {
            try
            {
                model.IsAvailable = !model.IsAvailable;
                Save(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

    }
}
