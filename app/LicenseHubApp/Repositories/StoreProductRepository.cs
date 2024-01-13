using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class StoreProductRepository : BaseRepository, IStoreProductRepository
    {
        public StoreProductRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(StoreProductModel model)
        {
            context.StoreProducts.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
            if (modelToDelete != null)
            {
                context.StoreProducts.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, StoreProductModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);
            if (modelToUpdate != null)
            {
                modelToUpdate.Name = updatedModel.Name;
                modelToUpdate.IsAvailable = updatedModel.IsAvailable;

                await context.SaveChangesAsync();
            }
        }

        public async Task<StoreProductModel?> GetModelByIdAsync(int modelId)
        {
            return await context.StoreProducts.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<StoreProductModel>> GetAllAsync()
        {
            return await context.StoreProducts.ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.StoreProducts.Any(model => model.Id == modelId);
        }

    }
}
