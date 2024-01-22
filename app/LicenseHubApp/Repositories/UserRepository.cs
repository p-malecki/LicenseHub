using Microsoft.EntityFrameworkCore; // for FirstOrDefaultAsync
using LicenseHubApp.Models;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Repositories;

public class UserRepository(DataContext context) : GenericRepository<UserModel>(context), IUserRepository
{
    public async Task<UserModel?> GetUserByUsername(string username)
    {
        return await Context.Users.FirstOrDefaultAsync(m => m.Username == username);
    }

    public new async Task Update(int id, UserModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        modelToUpdate.Username = model.Username;
        modelToUpdate.Password = model.Password;
        modelToUpdate.IsAdmin = model.IsAdmin;

        await context.SaveChangesAsync();
    }

    public bool IsUsernameUnique(int id, string username)
    {
        return !GetAll().Any(u => u.Username == username && u.Id != id);
    }

    public bool IsAdminChangeValid(bool modelIsAdmin, bool newIsAdmin)
    {
        return newIsAdmin || !modelIsAdmin || GetAll().ToList().Count != 1;
    }

    public new async Task Delete(int id)
    {
        var model = await GetById(id);
        if (model == null)
            return;

        if (model.IsAdmin && GetAll().Count(u => u.IsAdmin) == 1)
        {
            throw new InvalidOperationException($"Unable to delete the last user with administrator privileges.");
        }

        if (!IsIdUnique(model.Id))
        {
            var a = base.Delete(model.Id);
        }
        else
        {
            throw new InvalidOperationException($"{model.GetType()} with ID {model.Id} does not exist.");
        }
    }

}