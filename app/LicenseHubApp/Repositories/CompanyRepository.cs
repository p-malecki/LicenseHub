using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace LicenseHubApp.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(CompanyModel company)
        {
            context.Companies.Add(company);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var modelToDelete = await GetCompanyByIdAsync(id);
            if (modelToDelete != null)
            {
                context.Companies.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, CompanyModel updatedModel)
        {
            var modelToUpdate = await GetCompanyByIdAsync(modelId);
            if (modelToUpdate != null)
            {
                modelToUpdate.Name = updatedModel.Name;
                modelToUpdate.Nip = updatedModel.Nip;
                modelToUpdate.Localizations = updatedModel.Localizations;
                modelToUpdate.Websites = updatedModel.Websites;
                modelToUpdate.Description = updatedModel.Description;

                await context.SaveChangesAsync();
            }
        }

        public async Task<IList<CompanyModel>> GetAllAsync()
        {
            return await context.Companies.ToListAsync();
        }

        public async Task<CompanyModel?> GetCompanyByIdAsync(int id)
        {
            return await context.Companies.FirstOrDefaultAsync(co => co.Id == id);
        }

        public bool IsIdUnique(int id)
        {
            return !context.Companies.Any(co => co.Id == id);
        }
    }
}
