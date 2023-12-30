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

        public async Task Add(UserModel user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }

        public async Task Delete(UserModel user)
        {
            context.Users.Remove(user);
            await context.SaveChangesAsync();
        }

        public async Task Edit(UserModel user, string username, string password, bool isAdmin)
        {
            var userToUpdate = await context.Users.FindAsync(user);
            if (userToUpdate != null)
            {
                userToUpdate.Username = username;
                userToUpdate.Password = password;
                userToUpdate.IsAdmin = isAdmin;

                await context.SaveChangesAsync();
            }
        }

        public async Task<UserModel?> FindUser(string username)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<IEnumerable<UserModel>> GetAll()
        {
            return await context.Users.ToListAsync();
        }

        public bool IsIdUnique(int id)
        {
            return !context.Users.Any(user => user.Id == id);
        }

    }
}
