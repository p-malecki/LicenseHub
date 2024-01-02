using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(UserModel user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var modelToDelete = await GetModelByIdAsync(id);
            if (modelToDelete != null)
            {
                context.Users.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, UserModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);
            if (modelToUpdate != null)
            {
                modelToUpdate.Username = updatedModel.Username;
                modelToUpdate.Password = updatedModel.Password;
                modelToUpdate.IsAdmin = updatedModel.IsAdmin;

                await context.SaveChangesAsync();
            }
        }

        public async Task<UserModel?> GetModelByIdAsync(int id)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<UserModel?> GetUserByUsernameAsync(string username)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<IList<UserModel>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }

        public bool IsIdUnique(int id)
        {
            return !context.Users.Any(user => user.Id == id);
        }

    }
}
