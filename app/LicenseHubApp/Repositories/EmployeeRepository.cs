using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(EmployeeModel model)
        {
            context.Employees.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
            if (modelToDelete != null)
            {
                context.Employees.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, EmployeeModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);
            if (modelToUpdate != null)
            {
                modelToUpdate.Name = updatedModel.Name;
                modelToUpdate.IsActive = updatedModel.IsActive;
                modelToUpdate.Profession = updatedModel.Profession;
                modelToUpdate.PhoneNumbers = updatedModel.PhoneNumbers;
                modelToUpdate.Emails = updatedModel.Emails;
                modelToUpdate.Websites = updatedModel.Websites;
                modelToUpdate.IPs = updatedModel.IPs;
                modelToUpdate.Description = updatedModel.Description;

                await context.SaveChangesAsync();
            }
        }

        public async Task<EmployeeModel?> GetModelByIdAsync(int modelId)
        {
            return await context.Employees.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<EmployeeModel>> GetAllAsync()
        {
            return await context.Employees.ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.Employees.Any(model => model.Id == modelId);
        }

    }
}
