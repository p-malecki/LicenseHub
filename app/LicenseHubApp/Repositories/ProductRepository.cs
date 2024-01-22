using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Repositories;


public class ProductRepository(DataContext context) : GenericRepository<ProductModel>(context), IProductRepository
{
    public new async Task Update(int id, ProductModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        if (!IsNameUnique(id, model.Name))
            throw new InvalidDataException("Product has not unique name.");

        modelToUpdate.Name = model.Name;
        modelToUpdate.IsAvailable = model.IsAvailable;
        modelToUpdate.Description = model.Description;

        await context.SaveChangesAsync();
    }

    public bool IsNameUnique(int id, string name)
    {
        return !Context.Set<ProductModel>().Any(model => (model.Name == name) && model.Id != id);
    }

    public async Task CreateRelease(int productId, ProductReleaseModel releaseModel)
    {
        try
        {
            releaseModel.ThrowIfNotValid();

            var modelToUpdate = Context.Set<ProductModel>()
                                    .Include(m => m.Releases)
                                    .First(m => m.Id == productId)
                                ?? throw new NullReferenceException("Product model not found.");

            modelToUpdate.Releases.Add(releaseModel);
            await Context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task DeleteRelease(int productId, ProductReleaseModel releaseModel)
    {
        try
        {
            var productModel = await GetById(productId) ?? throw new NullReferenceException("Product model not found.");

            productModel.Releases.Remove(releaseModel);
            await Context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}