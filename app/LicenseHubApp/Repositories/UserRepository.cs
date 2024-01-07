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

        public async Task AddAsync(UserModel model)
        {
            context.Users.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
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

        public async Task<UserModel?> GetModelByIdAsync(int modelId)
        {
            return await context.Users.FirstOrDefaultAsync(m => m.Id == modelId);
        }
        public async Task<UserModel?> GetUserByUsernameAsync(string username)
        {
            return await context.Users.FirstOrDefaultAsync(m => m.Username == username);
        }

        public async Task<IList<UserModel>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.Users.Any(model => model.Id == modelId);
        }

    }
}
