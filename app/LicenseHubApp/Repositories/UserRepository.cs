using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;

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

        public async Task Edit(UserModel user, string? name=null, string? password=null, bool? isAdmin=null)
        {
            var userToUpdate = await context.Users.FindAsync(user);
            if (userToUpdate != null)
            {
                if (name != null)
                    userToUpdate.Name = name;
                if (password != null)
                    userToUpdate.Password = password;
                if (isAdmin != null)
                    userToUpdate.IsAdmin = isAdmin.Value;

                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<UserModel>> GetAll()
        {
            var users = await context.Users.ToListAsync();
            return users;
        }

        public bool IsIdUnique(int id)
        {
            return !context.Users.Any(user => user.Id == id);
        }

    }
}
