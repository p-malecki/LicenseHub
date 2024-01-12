using LicenseHubApp.Models.Filters;


namespace LicenseHubApp.Models.Managers
{
    public class WorkstationManager : BaseModelManager<WorkstationModel>
    {
        private static readonly object LockObject = new();
        private static WorkstationManager? _instance;
        private static IFilterStrategy<WorkstationModel>? _filterStrategy;

        private WorkstationManager() { }
        public static WorkstationManager GetInstance(IWorkstationRepository repository, IFilterStrategy<WorkstationModel> fs)
        {
            if (_instance == null)
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new WorkstationManager();
                        Repository = repository;
                        _filterStrategy = fs;
                    }
                }
            }
            return _instance;
        }

        public IEnumerable<WorkstationModel> FilterWorkstation(string filterValue)
        {
            try
            {
                return _filterStrategy.Filter(ModelList, filterValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void SetFilterStrategy(IFilterStrategy<WorkstationModel> fs)
        {
            _filterStrategy = fs;
        }

        public void ToggleHasFault(WorkstationModel model)
        {
            try
            {
                model.HasFault = !model.HasFault;
                Save(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

    }
}
