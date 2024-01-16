using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
namespace LicenseHubApp.Services.Managers;


public class LicenseManager : BaseModelManager<LicenseModel>
{
    private static readonly object LockObject = new();
    private static LicenseManager? _instance;
    private static IFilterStrategy<LicenseModel>? _filterStrategy;

    private LicenseManager() { }
    public static LicenseManager GetInstance(ILicenseRepository repository, IFilterStrategy<LicenseModel> fs)
    {
        if (_instance == null)
        {
            lock (LockObject)
            {
                if (_instance == null)
                {
                    _instance = new LicenseManager();
                    Repository = repository;
                    _filterStrategy = fs;
                }
            }
        }
        return _instance;
    }

    public void SetFilterStrategy(IFilterStrategy<LicenseModel> fs)
    {
        _filterStrategy = fs;
    }

    public IEnumerable<LicenseModel> FilterWorkstationProducts(string filterValue)
    {
        try
        {
            return _filterStrategy!.Filter(ModelList, filterValue);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

}
