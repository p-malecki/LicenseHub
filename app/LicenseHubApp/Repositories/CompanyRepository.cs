using LicenseHubApp.Repositories.GenericRepository;
using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using Microsoft.EntityFrameworkCore;

namespace LicenseHubApp.Repositories;

public class CompanyRepository(DataContext context) : GenericRepository<CompanyModel>(context), ICompanyRepository
{
    private IFilterStrategy<CompanyModel> _filterStrategy = new CustomerNameFilterStrategy();


    public new async Task<IList<CompanyModel>> GetAllAsync()
    {
        foreach(var companyModel in Context.Set<CompanyModel>())
        {
            await context.Entry(companyModel)
                .Collection(m => m.Employees)
                .LoadAsync();
        }

        return await context.Companies.ToListAsync();
    }

    public new IEnumerable<CompanyModel> GetAll()
    {
        return GetAllAsync().Result.ToList();
    }

    public new async Task<CompanyModel?> GetById(int id)
    {
        var companyModel = context.Set<CompanyModel>().FirstOrDefaultAsync(m => m.Id == id).Result;

        await context.Entry(companyModel)
            .Collection(m => m.Employees)
            .LoadAsync();

        return companyModel;
    }
    
    public new async Task Update(int id, CompanyModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        modelToUpdate.IsActive = model.IsActive;
        modelToUpdate.Name = model.Name;
        modelToUpdate.Nip = model.Nip;
        modelToUpdate.Localizations = model.Localizations;
        modelToUpdate.Websites = model.Websites;
        modelToUpdate.Description = model.Description;

        await context.SaveChangesAsync();
    }


    public async Task CreateEmployee(int companyId, EmployeeModel employeeModel)
    {
        try
        {
            employeeModel.ThrowIfNotValid();

            var modelToUpdate = Context.Set<CompanyModel>()
                                    .Include(m => m.Employees)
                                    .First(m => m.Id == companyId)
                                ?? throw new NullReferenceException("Company model not found.");

            modelToUpdate.Employees.Add(employeeModel);
            await Context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task DeleteEmployee(int companyId, EmployeeModel employeeModel)
    {
        try
        {
            var companyModel = await GetById(companyId) ?? throw new NullReferenceException("Company model not found.");

            companyModel.Employees.Remove(employeeModel);
            await Context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task CreateWorkstation(int companyId, WorkstationModel workstationModel)
    {
        try
        {
            workstationModel.ThrowIfNotValid();

            var modelToUpdate = Context.Set<CompanyModel>()
                                    .Include(m => m.Workstations)
                                    .First(m => m.Id == companyId)
                                ?? throw new NullReferenceException("Company model not found.");

            modelToUpdate.Workstations.Add(workstationModel);
            await Context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task DeleteWorkstation(int companyId, WorkstationModel workstationModel)
    {
        try
        {
            var companyModel = await GetById(companyId) ?? throw new NullReferenceException("Company model not found.");

            companyModel.Workstations.Remove(workstationModel);
            await Context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void SetFilterStrategy(IFilterStrategy<CompanyModel> fs)
    {
        _filterStrategy = fs;
    }

    public IEnumerable<CompanyModel> FilterCompany(string filterValue)
    {
        return _filterStrategy.Filter(GetAll(), filterValue);
    }

}