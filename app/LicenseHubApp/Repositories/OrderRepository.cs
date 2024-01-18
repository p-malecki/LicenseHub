using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(OrderModel model)
        {
            context.Orders.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
            if (modelToDelete != null)
            {
                context.Orders.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, OrderModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);
            if (modelToUpdate != null)
            {
                modelToUpdate.ContractNumber = updatedModel.ContractNumber;
                modelToUpdate.DateOfOrder = updatedModel.DateOfOrder;
                modelToUpdate.DateOfPayment = updatedModel.DateOfPayment;
                modelToUpdate.Description = updatedModel.Description;

                await context.SaveChangesAsync();
            }
        }

        public async Task<OrderModel?> GetModelByIdAsync(int modelId)
        {
            return await context.Orders.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<OrderModel>> GetAllAsync()
        {
            return await context.Orders.ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.Orders.Any(model => model.Id == modelId);
        }
    }
}
