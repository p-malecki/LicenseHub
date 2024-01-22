using LicenseHubApp.Models;
using Microsoft.EntityFrameworkCore;
namespace LicenseHubApp.Repositories.GenericRepository;


public class GenericRepository<TModel>(DataContext context) : IGenericRepository<TModel>
    where TModel : ValidatableModel, IModelWithId
{
    protected DataContext Context = context;

    public async Task<IList<TModel>> GetAllAsync()
    {
        return await Context.Set<TModel>().ToListAsync();
    }

    public IEnumerable<TModel> GetAll()
    {
        return GetAllAsync().Result.ToList();
    }

    public async Task<TModel?> GetById(int id)
    {
        return await Context.Set<TModel>().FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task Create(TModel model)
    {
        model.ThrowIfNotValid();

        await Context.Set<TModel>().AddAsync(model);
        await Context.SaveChangesAsync();
    }

    public async Task Update(int id, TModel model)
    {
        // TODO FIX UPDATE
        model.ThrowIfNotValid();
        Context.Set<TModel>().Update(model);
        await Context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var model = await Context.Set<TModel>().FindAsync(id) ?? throw new InvalidOperationException($"Model with ID {id} does not exist.");
        Context.Set<TModel>().Remove(model);
        await Context.SaveChangesAsync();
    }

    public bool IsIdUnique(int id)
    {
        return GetAll().FirstOrDefault(m => m.Id == id) == null;
    }
}