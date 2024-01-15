using LicenseHubApp.Models;

namespace LicenseHubApp.Services.Managers
{
    public class ProductManager : BaseModelManager<ProductModel>
    {
        private static readonly object LockObject = new();
        private static ProductManager? _instance;
        private static IProductReleaseModelRepository _releaseRepository;
        private static IEnumerable<ProductReleaseModel> _releaseModelList;

        
        private ProductManager() { }
        public static ProductManager GetInstance(IProductRepository productRepository, IProductReleaseModelRepository releaseRepository)
        {
            if (_instance == null)
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ProductManager();
                        Repository = productRepository;
                        _releaseRepository = releaseRepository;
                        _releaseModelList = new List<ProductReleaseModel>();
                    }
                }
            }
            return _instance;
        }


        public void LoadAllRelease()
        {
            _releaseModelList = _releaseRepository.GetAllAsync().Result.ToList();
        }

        public IEnumerable<ProductReleaseModel> GetAllRelease()
        {
            LoadAllRelease();
            return _releaseModelList;
        }


        public void AddRelease(int productId, ProductReleaseModel releaseModel)
        {

            ((IProductRepository)Repository).AddReleaseAsync(productId, releaseModel);
        }

        public void RemoveRelease(int productId, ProductReleaseModel releaseModel)
        {

            ((IProductRepository)Repository).RemoveReleaseAsync(productId, releaseModel);
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
