namespace LicenseHubApp.Models
{
    public interface IUserRepository : IModelRepository<UserModel>
    {
        Task<UserModel?> GetUserByUsernameAsync(string username);
    }
}
