namespace LicenseHubApp.Models
{
    public sealed class UserManager
    {
        private static UserManager _instance;
        private static IUserRepository _repository;
        private IEnumerable<UserModel> _userList;
        private UserManager() { }

        public static UserManager GetInstance(IUserRepository repository)
        {
            if (_instance == null)
            {
                _instance = new UserManager();
                _repository = repository;
            }
            return _instance;
        }

        public void LoadAllUsers()
        {
            _userList = _repository.GetAll().Result.ToList();
        }
        public IEnumerable<UserModel> GetAllUsers()
        {
            return _userList;
        }

        public void AddUser(int id, string name, string password, bool isAdmin)
        {
            try
            {
                var user = new UserModel
                {
                    Id = id,
                    Name = name,
                    Password = password,
                    IsAdmin = isAdmin
                };

                if (!_repository.IsIdUnique(user.Id))
                    throw new InvalidOperationException($"User with ID {user.Id} already exists.");
                SaveUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void SaveUser(UserModel user)
        {
            try
            {
                if (user.Validate())
                {
                    if (!_repository.IsIdUnique(user.Id))
                        _ = _repository.Add(user);
                    else
                        _ = _repository.Edit(user, user.Name, user.Password, user.IsAdmin);
                    LoadAllUsers();
                }
                else
                {
                    throw new InvalidOperationException("Model validation failed.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                throw;
            }
        }
        public void DeleteUser(UserModel user)
        {
            try
            {
                if (!_repository.IsIdUnique(user.Id))
                {
                    var a = _repository.Delete(user);

                }
                else
                {
                    throw new InvalidOperationException($"User with ID {user.Id} does not exist.");
                }
                LoadAllUsers();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                throw;
            }
        }

        public void ChangeUserPassword(UserModel user, string newPassword)
        {
            user.Password = newPassword;
            SaveUser(user);
        }

        public void PromoteUserToAdmin(UserModel user)
        {
            user.IsAdmin = true;
            SaveUser(user);
        }

    }
}
