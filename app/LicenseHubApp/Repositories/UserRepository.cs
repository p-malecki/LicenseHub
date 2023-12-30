using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;
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

        public async Task Edit(UserModel user, string name, string password, bool isAdmin)
        {
            var userToUpdate = await context.Users.FindAsync(user);
            if (userToUpdate != null)
            {
                userToUpdate.Name = name;
                userToUpdate.Password = password;
                userToUpdate.IsAdmin = isAdmin;

                await context.SaveChangesAsync();
            }
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
