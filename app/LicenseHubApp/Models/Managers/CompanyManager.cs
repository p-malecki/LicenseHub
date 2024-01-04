using LicenseHubApp.Models.Filters;

namespace LicenseHubApp.Models.Managers
{
    public class CompanyManager : BaseModelManager<CompanyModel>
    {
        private static readonly object LockObject = new();
        private static CompanyManager? _instance;
        private IFilterStrategy<CompanyModel> _filterStrategy;

        private CompanyManager() { }
        public static CompanyManager GetInstance(ICompanyRepository repository)
        {
            // Double-check locking for thread safety
            if (_instance == null)
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new CompanyManager();
                        Repository = repository;
                    }
                }
            }
            return _instance;
        }

        public IEnumerable<CompanyModel> FilterCompany(string filterValue)
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

        public void SetFilterStrategy(IFilterStrategy<CompanyModel> fs)
        {
            _filterStrategy = fs;
        }

        public void Deactivate(CompanyModel model)
        {
            try
            {
                model.IsActive = false;
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
