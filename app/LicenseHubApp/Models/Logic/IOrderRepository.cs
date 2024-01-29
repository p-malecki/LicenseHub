using LicenseHubApp.Models.Filters;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Models;

public interface IOrderRepository : IGenericRepository<OrderModel>
{
    void SetFilterStrategy(IFilterStrategy<OrderModel> fs);
    IEnumerable<OrderModel> FilterOrder(string filterValue);
}