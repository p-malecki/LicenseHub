
namespace LicenseHubApp.Models.Filters
{
    public class OrderContractNumberFilterStrategy : IFilterStrategy<OrderModel>
    {
        public IEnumerable<OrderModel> Filter(IEnumerable<OrderModel> models, string filterValue)
        {
            return models.Where(m => m.ContractNumber.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
