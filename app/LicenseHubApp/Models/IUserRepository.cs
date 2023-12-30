namespace LicenseHubApp.Models
{
    public interface IUserRepository
    {
        Task Add(UserModel user);
        Task Edit(UserModel user, string username, string password, bool isAdmin);
        Task Delete(UserModel user);
        Task<UserModel?> FindUser(string username);
        Task<IEnumerable<UserModel>> GetAll();

        bool IsIdUnique(int id);
    }
}
