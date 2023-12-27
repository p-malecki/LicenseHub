using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseHubApp.Models
{
    internal sealed class UserManager
    {
        private UserManager _instance;
        private IEnumerable<UserModel> _users;
        private static UserManager() { }

        public static UserManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserManager();
            }
            return _instance;
        }

        private bool IsPasswordValid(string password)
        {
            throw new NotImplementedException();
        }
        public void CreateUser()
        {
            throw new NotImplementedException();
        }
        public void DeleteUser(UserModel user)
        {
            throw new NotImplementedException();
        }
        public void PromoteUserToAdmin(UserModel user)
        {
            throw new NotImplementedException();
        }

    }
}
