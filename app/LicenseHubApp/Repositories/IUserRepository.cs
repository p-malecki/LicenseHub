using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Models;

public interface IUserRepository : IGenericRepository<UserModel>
{
    Task<UserModel?> GetUserByUsername(string username);
    bool IsUsernameUnique(int id, string username);
    bool IsAdminChangeValid(bool modelIsAdmin, bool newIsAdmin);
}