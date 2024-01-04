using System.Data;

namespace LicenseHubApp.Models.Managers
{
    public class UserManager : BaseModelManager<UserModel>
    {
        private static readonly object LockObject = new();
        private static UserManager _instance;

        private UserManager() { }
        public static UserManager GetInstance(IUserRepository repository)
        {
            // Double-check locking for thread safety
            if (_instance == null)
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new UserManager();
                        Repository = repository;
                    }
                }
            }
            return _instance;
        }

        public void ValidateUsername(UserModel model, string newUsername)
        {
            var isUsernameUnique = !ModelList.Any(u => (u.Username == newUsername) && (u.Id != model.Id));
            if (!isUsernameUnique)
            {
                throw new InvalidOperationException($"User with Username {newUsername} already exists.");
            }
        }

        public void ValidateAdminChange(UserModel model, bool newIsAdmin)
        {
            if (!newIsAdmin && model.IsAdmin && ModelList.Count(u => u.IsAdmin) == 1)
            {
                throw new InvalidOperationException($"Unable to remove the last admin privileges.");
            }
        }

        public new void Delete(UserModel model)
        {
            try
            {
                if (model.IsAdmin && GetAll().Count(u => u.IsAdmin) == 1)
                {
                    throw new InvalidOperationException($"Unable to delete the last user with administrator privileges.");

                }

                if (!Repository.IsIdUnique(model.Id))
                {
                    var a = Repository.DeleteAsync(model.Id);
                }
                else
                {
                    Type objtype = model.GetType();
                    throw new InvalidOperationException($"{objtype.Name} with ID {model.Id} does not exist.");
                }
                LoadAll();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                throw;
            }
        }

    }
}
