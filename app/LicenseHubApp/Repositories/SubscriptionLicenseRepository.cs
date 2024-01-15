using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class SubscriptionLicenseRepository : BaseRepository, ISubscriptionLicenseRepository
    {
        public SubscriptionLicenseRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(SubscriptionLicenseModel model)
        {
            try
            {
                context.Licenses.Add(model);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
            if (modelToDelete != null)
            {
                context.Licenses.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, SubscriptionLicenseModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);

            if (modelToUpdate != null)
            {
                modelToUpdate.RegisterDate = updatedModel.RegisterDate;
                modelToUpdate.ActivationDate = updatedModel.ActivationDate;
                modelToUpdate.LeaseTermInDays = updatedModel.LeaseTermInDays;

                await context.SaveChangesAsync();
            }
        }

        public async Task<SubscriptionLicenseModel?> GetModelByIdAsync(int modelId)
        {
            return await context.Licenses.OfType<SubscriptionLicenseModel>().FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<SubscriptionLicenseModel>> GetAllAsync()
        {
            return await context.Licenses.OfType<SubscriptionLicenseModel>().ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.Licenses.Any(model => model.Id == modelId);
        }

    }
}
