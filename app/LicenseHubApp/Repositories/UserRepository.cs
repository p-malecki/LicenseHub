using LicenseHubApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseHubApp.Repositories
{
    internal class UserRepository : IUserRepository
    {
        void IUserRepository.Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserModel> IUserRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserModel> IUserRepository.GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
