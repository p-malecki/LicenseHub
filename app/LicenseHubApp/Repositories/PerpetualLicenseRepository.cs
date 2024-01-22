using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Repositories.GenericRepository;
using LicenseHubApp.Models;
namespace LicenseHubApp.Repositories;

public class PerpetualLicenseRepository(DataContext context) : GenericRepository<PerpetualLicenseModel>(context), IPerpetualLicenseRepository
{
    public new async Task Update(int id, PerpetualLicenseModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        modelToUpdate.RegisterDate = model.RegisterDate;
        modelToUpdate.ActivationDate = model.ActivationDate;

        await context.SaveChangesAsync();
    }
}
