using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Repositories;

public class ProductReleaseRepository(DataContext context) : GenericRepository<ProductReleaseModel>(context), IProductReleaseRepository
{
    public new async Task Update(int id, ProductReleaseModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        modelToUpdate.ReleaseNumber = model.ReleaseNumber;
        modelToUpdate.InstallerVerificationPasscode = model.InstallerVerificationPasscode;
        modelToUpdate.Description = model.Description;

        await context.SaveChangesAsync();
    }
}