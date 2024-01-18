using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;


namespace LicenseHubApp.Services.Managers
{
    public class OrderManager : BaseModelManager<OrderModel>
    {
        private static readonly object LockObject = new();
        private static OrderManager? _instance;
        private static IFilterStrategy<OrderModel>? _filterStrategy;

        private OrderManager() { }
        public static OrderManager GetInstance(IOrderRepository repository, IFilterStrategy<OrderModel> fs)
        {
            if (_instance == null)
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new OrderManager();
                        Repository = repository;
                        _filterStrategy = fs;
                    }
                }
            }
            return _instance;
        }

        public IEnumerable<OrderModel> FilterOrder(string filterValue)
        {
            try
            {
                return _filterStrategy.Filter(ModelList, filterValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void SetFilterStrategy(IFilterStrategy<OrderModel> fs)
        {
            _filterStrategy = fs;
        }

    }
}
