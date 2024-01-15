using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class ActivationCodeRepository : BaseRepository, IActivationCodeRepository
    {
        public ActivationCodeRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(ActivationCodeModel model)
        {
            context.ActivationCodes.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
            if (modelToDelete != null)
            {
                context.ActivationCodes.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, ActivationCodeModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);
            if (modelToUpdate != null)
            {
                modelToUpdate.Code = updatedModel.Code;

                await context.SaveChangesAsync();
            }
        }

        public async Task<ActivationCodeModel?> GetModelByIdAsync(int modelId)
        {
            return await context.ActivationCodes.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<ActivationCodeModel>> GetAllAsync()
        {
            return await context.ActivationCodes.ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.ActivationCodes
                .Any(model => model.Id == modelId);
        }

        public async Task AddGeneratedActivationCodeAsync(GeneratedActivationCodeModel model)
        {
            context.ActivationCodes.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteGeneratedActivationCodeAsync(int modelId)
        {
            var modelToDelete = await GetByIdGeneratedActivationCodeModelAsync(modelId);
            if (modelToDelete != null)
            {
                context.ActivationCodes.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditGeneratedActivationCodeAsync(int modelId, GeneratedActivationCodeModel updatedModel)
        {
            var modelToUpdate = await GetByIdGeneratedActivationCodeModelAsync(modelId);
            if (modelToUpdate != null)
            {
                modelToUpdate.Code = updatedModel.Code;
                await context.SaveChangesAsync();
            }
        }

        public async Task<GeneratedActivationCodeModel?> GetByIdGeneratedActivationCodeModelAsync(int modelId)
        {
            return await context.ActivationCodes
                .OfType<GeneratedActivationCodeModel>()
                .FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<GeneratedActivationCodeModel>> GetAllGeneratedActivationCodeAsync()
        {
            return await context.ActivationCodes.OfType<GeneratedActivationCodeModel>().ToListAsync();
        }
    }
}
