using LicenseHubApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseHubApp.Models
{
    public interface IUserRepository
    {
        Task Add(UserModel user);
        Task Edit(UserModel user, string? name = null, string? password = null, bool? isAdmin = null);
        Task Delete(UserModel user);
        Task<IEnumerable<UserModel>> GetAll();
        bool IsIdUnique(int id);
    }
}
