using LicenseHubApp.Models;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Repositories;

public class SubscriptionLicenseRepository(DataContext context) : GenericRepository<SubscriptionLicenseModel>(context), ISubscriptionLicenseRepository
{
    public new async Task Update(int id, SubscriptionLicenseModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        modelToUpdate.RegisterDate = model.RegisterDate;
        modelToUpdate.ActivationDate = model.ActivationDate;
        modelToUpdate.LeaseTermInDays = model.LeaseTermInDays;

        await context.SaveChangesAsync();
    }
}