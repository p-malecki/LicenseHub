using LicenseHubApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;

namespace LicenseHubApp.Repositories
{
    internal class UserRepository : IUserRepository
    {
        async Task IUserRepository.Add(UserModel user)
        {
            using var context = new DataContext();
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }

        async Task IUserRepository.Delete(UserModel user)
        {
            using var context = new DataContext();
            context.Users.Remove(user);
            await context.SaveChangesAsync();
        }

        async Task IUserRepository.Edit(UserModel user, string? name=null, string? password=null, bool? isAdmin=null)
        {
            using var context = new DataContext();
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

        IEnumerable<UserModel> IUserRepository.GetAll()
        {
            using var context = new DataContext();
            var users = context.Users;
            return users.ToList();
        }

    }
}
