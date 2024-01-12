using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;

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
            foreach (var companyModel in context.Companies)
            {
                await context.Entry(companyModel)
                    .Collection(m => m.Employees)
                    .LoadAsync();
            }

            return await context.Companies.ToListAsync();
        }

        public async Task<CompanyModel?> GetModelByIdAsync(int modelId)
        {
            var companyModel = context.Companies.FirstOrDefaultAsync(m => m.Id == modelId).Result;

            await context.Entry(companyModel)
                .Collection(m => m.Employees)
                .LoadAsync();

            return companyModel;
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.Companies.Any(m => m.Id == modelId);
        }

        public async Task AddEmployeeAsync(int companyId, EmployeeModel employeeModel)
        {
            try
            {
                if (!employeeModel.Validate())
                {
                    throw new InvalidOperationException("Model validation failed.");
                }


                var modelToUpdate = context.Companies
                                        .Include(m => m.Employees)
                                        .First(m => m.Id == companyId)
                                    ?? throw new NullReferenceException("Company model not found.");

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

        public async Task AddWorkstationAsync(int companyId, WorkstationModel workstationModel)
        {
            try
            {
                if (!workstationModel.Validate())
                {
                    throw new InvalidOperationException("Model validation failed.");
                }


                var modelToUpdate = context.Companies
                                        .Include(m => m.Workstations)
                                        .First(m => m.Id == companyId)
                                    ?? throw new NullReferenceException("Company model not found.");

                modelToUpdate.Workstations.Add(workstationModel);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task RemoveWorkstationAsync(int companyId, WorkstationModel workstationModel)
        {
            try
            {
                var companyModel = await GetModelByIdAsync(companyId) ?? throw new NullReferenceException("Company model not found.");

                companyModel.Workstations.Remove(workstationModel);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
