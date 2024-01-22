using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Repositories.GenericRepository;
using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
namespace LicenseHubApp.Repositories;

public class OrderRepository(DataContext context) : GenericRepository<OrderModel>(context), IOrderRepository
{
    private IFilterStrategy<OrderModel> _filterStrategy = new OrderContractNumberFilterStrategy();

    public new async Task Update(int id, OrderModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        modelToUpdate.ContractNumber = model.ContractNumber;
        modelToUpdate.DateOfOrder = model.DateOfOrder;
        modelToUpdate.DateOfPayment = model.DateOfPayment;
        modelToUpdate.Description = model.Description;

        await context.SaveChangesAsync();
    }

    public void SetFilterStrategy(IFilterStrategy<OrderModel> fs)
    {
        _filterStrategy = fs;
    }
    public IEnumerable<OrderModel> FilterOrder(string filterValue)
    {
        return _filterStrategy.Filter(GetAll(), filterValue);
    }

}