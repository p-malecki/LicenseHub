using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
namespace LicenseHubApp.Services.Managers;

public class WorkstationProductManager : BaseModelManager<WorkstationProductModel>
{
    private static readonly object LockObject = new();
    private static WorkstationProductManager? _instance;
    private static IFilterStrategy<WorkstationProductModel>? _filterStrategy;

    private WorkstationProductManager() { }
    public static WorkstationProductManager GetInstance(IWorkstationProductRepository repository, IFilterStrategy<WorkstationProductModel> fs)
    {
        if (_instance == null)
        {
            lock (LockObject)
            {
                if (_instance == null)
                {
                    _instance = new WorkstationProductManager();
                    Repository = repository;
                    _filterStrategy = fs;
                }
            }
        }
        return _instance;
    }

    public void SetFilterStrategy(IFilterStrategy<WorkstationProductModel> fs)
    {
        _filterStrategy = fs;
    }

    public IEnumerable<WorkstationProductModel> FilterWorkstationProducts(string filterValue)
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
