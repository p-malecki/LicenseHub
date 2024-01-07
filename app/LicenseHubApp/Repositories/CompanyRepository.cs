using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using System.ComponentModel.Design;

namespace LicenseHubApp.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(CompanyModel model)
        {
            context.Companies.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task AddEmployeeAsync(int companyId, EmployeeModel employeeModel)
        {
            try
            {
                var modelToUpdate = await GetModelByIdAsync(companyId) ?? throw new NullReferenceException("Company model not found.");

                modelToUpdate.Employees.Add(employeeModel);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task RemoveEmployeeAsync(int companyId, EmployeeModel employeeModel)
        {
            try
            {
                var companyModel = await GetModelByIdAsync(companyId) ?? throw new NullReferenceException("Company model not found.");

                companyModel.Employees.Remove(employeeModel);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task DeleteAsync(int modelId)
        {
            try
            {
                var modelToDelete = await GetModelByIdAsync(modelId) ?? throw new NullReferenceException("Company model not found.");

                context.Companies.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task EditAsync(int modelId, CompanyModel updatedModel)
        {
            try
            {
                var modelToUpdate = await GetModelByIdAsync(modelId) ?? throw new NullReferenceException("Company model not found.");

                modelToUpdate.IsActive = updatedModel.IsActive;
                modelToUpdate.Name = updatedModel.Name;
                modelToUpdate.Nip = updatedModel.Nip;
                modelToUpdate.Localizations = updatedModel.Localizations;
                modelToUpdate.Websites = updatedModel.Websites;
                modelToUpdate.Description = updatedModel.Description;

                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<IList<CompanyModel>> GetAllAsync()
        {
            return await context.Companies.ToListAsync();
        }

        public async Task<CompanyModel?> GetModelByIdAsync(int modelId)
        {
            return await context.Companies.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.Companies.Any(m => m.Id == modelId);
        }
    }
}
