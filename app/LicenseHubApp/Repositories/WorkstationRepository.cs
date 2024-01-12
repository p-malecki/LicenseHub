using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class WorkstationRepository : BaseRepository, IWorkstationRepository
    {
        public WorkstationRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(WorkstationModel model)
        {
            context.Workstations.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
            if (modelToDelete != null)
            {
                context.Workstations.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, WorkstationModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);
            if (modelToUpdate != null)
            {
                modelToUpdate.ComputerName = updatedModel.ComputerName;
                modelToUpdate.Username = updatedModel.Username;
                modelToUpdate.HardDisk = updatedModel.HardDisk;
                modelToUpdate.Cpu = updatedModel.Cpu;
                modelToUpdate.BiosVersion = updatedModel.BiosVersion;
                modelToUpdate.Os = updatedModel.Os;
                modelToUpdate.OsBitVersion = updatedModel.OsBitVersion;
                modelToUpdate.HasFault = updatedModel.HasFault;

                await context.SaveChangesAsync();
            }
        }

        public async Task<WorkstationModel?> GetModelByIdAsync(int modelId)
        {
            return await context.Workstations.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<WorkstationModel>> GetAllAsync()
        {
            return await context.Workstations.ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.Workstations.Any(model => model.Id == modelId);
        }

    }
}
