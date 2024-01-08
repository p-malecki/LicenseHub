using LicenseHubApp.Models.Filters;


namespace LicenseHubApp.Models.Managers
{
    public class EmployeeManager : BaseModelManager<EmployeeModel>
    {
        private static readonly object LockObject = new();
        private static EmployeeManager? _instance;
        private static IFilterStrategy<EmployeeModel>? _filterStrategy;

        private EmployeeManager() { }
        public static EmployeeManager GetInstance(IEmployeeRepository repository, IFilterStrategy<EmployeeModel> fs)
        {
            // Double-check locking for thread safety
            if (_instance == null)
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new EmployeeManager();
                        Repository = repository;
                        _filterStrategy = fs;
                    }
                }
            }
            return _instance;
        }

        public IEnumerable<EmployeeModel> FilterEmployee(string filterValue)
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

        public void SetFilterStrategy(IFilterStrategy<EmployeeModel> fs)
        {
            _filterStrategy = fs;
        }

        public void ToggleIsActive(EmployeeModel model)
        {
            try
            {
                model.IsActive = !model.IsActive;
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
