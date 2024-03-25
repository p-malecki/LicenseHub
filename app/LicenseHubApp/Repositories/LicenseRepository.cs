using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using LicenseHubApp.Repositories.GenericRepository;
using System.Linq;
using System.ComponentModel;
namespace LicenseHubApp.Repositories;


public class LicenseRepository(DataContext context) : GenericRepository<LicenseModel>(context), ILicenseRepository
{

    public new async Task Update(int id, LicenseModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        modelToUpdate.RegisterDate = model.RegisterDate;
        modelToUpdate.ActivationDate = model.ActivationDate;
        modelToUpdate.LeaseTermInDays = model.LeaseTermInDays;

        await context.SaveChangesAsync();
    }
}
