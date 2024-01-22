using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Models;

public interface ILicenseRepository : IGenericRepository<LicenseModel>
{
    void SetLicenseType(string licenseType);
}