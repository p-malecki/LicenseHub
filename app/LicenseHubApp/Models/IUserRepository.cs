namespace LicenseHubApp.Models
{
    public interface IUserRepository
    {
        Task Add(UserModel user);
        Task Edit(UserModel user, string name, string password, bool isAdmin);
        Task Delete(UserModel user);
        Task<IEnumerable<UserModel>> GetAll();
        bool IsIdUnique(int id);
    }
}
