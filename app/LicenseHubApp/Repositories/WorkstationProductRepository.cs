using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class WorkstationProductRepository : BaseRepository, IWorkstationProductRepository
    {
        public WorkstationProductRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(WorkstationProductModel model)
        {
            context.WorkstationProducts.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
            if (modelToDelete != null)
            {
                context.WorkstationProducts.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, WorkstationProductModel updatedModel)
        {
            //var modelToUpdate = await GetModelByIdAsync(modelId);
            //if (modelToUpdate != null)
            //{
            //    await context.SaveChangesAsync();
            //}
            // TODO (REF) edit WorkstationProductModel
        }

        public async Task<WorkstationProductModel?> GetModelByIdAsync(int modelId)
        {
            return await context.WorkstationProducts.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<WorkstationProductModel>> GetAllAsync()
        {
            return await context.WorkstationProducts.ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.WorkstationProducts.Any(model => model.Id == modelId);
        }

    }
}
