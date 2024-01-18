using LicenseHubApp.Models;
namespace LicenseHubApp.Services.Managers;

public class WorkstationProductManager : BaseModelManager<WorkstationProductModel>
{
    private static readonly object LockObject = new();
    private static WorkstationProductManager? _instance;

    private WorkstationProductManager() { }
    public static WorkstationProductManager GetInstance(IWorkstationProductRepository repository)
    {
        if (_instance == null)
        {
            lock (LockObject)
            {
                if (_instance == null)
                {
                    _instance = new WorkstationProductManager();
                    Repository = repository;
                }
            }
        }
        return _instance;
    }

}
