using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class PerpetualLicenseRepository : BaseRepository, IPerpetualLicenseRepository
    {
        public PerpetualLicenseRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(PerpetualLicenseModel model)
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

        public async Task EditAsync(int modelId, PerpetualLicenseModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);

            if (modelToUpdate != null)
            {
                modelToUpdate.RegisterDate = updatedModel.RegisterDate;
                modelToUpdate.ActivationDate = updatedModel.ActivationDate;

                await context.SaveChangesAsync();
            }
        }

        public async Task<PerpetualLicenseModel?> GetModelByIdAsync(int modelId)
        {
            return await context.Licenses.OfType<PerpetualLicenseModel>().FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<PerpetualLicenseModel>> GetAllAsync()
        {
            return await context.Licenses.OfType<PerpetualLicenseModel>().ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            // TODO (?) check whether .OfType<PerpetualLicenseModel>() can be removed
            //return !context.Licenses.Any(model => model.Id == modelId);
            return !context.Licenses.OfType<PerpetualLicenseModel>().Any(model => model.Id == modelId);
        }

    }
}
