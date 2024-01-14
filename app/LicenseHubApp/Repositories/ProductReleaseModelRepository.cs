using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class ProductReleaseModelRepository : BaseRepository, IProductReleaseModelRepository
    {
        public ProductReleaseModelRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(ProductReleaseModel model)
        {
            context.StoreProductReleases.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
            if (modelToDelete != null)
            {
                context.StoreProductReleases.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, ProductReleaseModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);
            if (modelToUpdate != null)
            {
                modelToUpdate.ReleaseNumber = updatedModel.ReleaseNumber;
                modelToUpdate.InstallerVerificationPasscode = updatedModel.InstallerVerificationPasscode;
                modelToUpdate.Description = updatedModel.Description;

                await context.SaveChangesAsync();
            }
        }

        public async Task<ProductReleaseModel?> GetModelByIdAsync(int modelId)
        {
            return await context.StoreProductReleases.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<ProductReleaseModel>> GetAllAsync()
        {
            return await context.StoreProductReleases.ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.StoreProductReleases.Any(model => model.Id == modelId);
        }

    }
}
