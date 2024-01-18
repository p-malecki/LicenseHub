using LicenseHubApp.Models;
namespace LicenseHubApp.Services.Managers;


public class LicenseManager : BaseModelManager<LicenseModel>
{
    private static readonly object LockObject = new();
    private static LicenseManager? _instance;

    private LicenseManager() { }
    public static LicenseManager GetInstance(ILicenseRepository repository)
    {
        if (_instance == null)
        {
            lock (LockObject)
            {
                if (_instance == null)
                {
                    _instance = new LicenseManager();
                    Repository = repository;
                }
            }
        }
        return _instance;
    }
    
}
