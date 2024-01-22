using LicenseHubApp.Repositories.GenericRepository;
using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using Microsoft.EntityFrameworkCore;
namespace LicenseHubApp.Repositories;

public class EmployeeRepository(DataContext context) : GenericRepository<EmployeeModel>(context), IEmployeeRepository
{
    private IFilterStrategy<EmployeeModel> _filterStrategy = new EmployeeNameFilterStrategy();


    public new async Task Update(int id, EmployeeModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        modelToUpdate.Name = model.Name;
        modelToUpdate.IsActive = model.IsActive;
        modelToUpdate.Profession = model.Profession;
        modelToUpdate.PhoneNumbers = model.PhoneNumbers;
        modelToUpdate.Emails = model.Emails;
        modelToUpdate.Websites = model.Websites;
        modelToUpdate.IPs = model.IPs;
        modelToUpdate.Description = model.Description;

        await context.SaveChangesAsync();
    }

    public void SetFilterStrategy(IFilterStrategy<EmployeeModel> fs)
    {
        _filterStrategy = fs;
    }

    public IEnumerable<EmployeeModel> FilterEmployee(string filterValue)
    {
        return _filterStrategy.Filter(GetAll(), filterValue);
    }
}