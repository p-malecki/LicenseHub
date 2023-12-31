namespace LicenseHubApp.Models
{
    public interface IUserRepository
    {
        Task AddAsync(UserModel user);
        Task EditAsync(int modelId, UserModel updatedModel);
        Task DeleteAsync(int id);
        Task<UserModel?> GetUserByIdAsync(int id);
        Task<UserModel?> GetUserByUsernameAsync(string username);
        Task<IList<UserModel>> GetAllAsync();
        bool IsIdUnique(int id);
    }
}
