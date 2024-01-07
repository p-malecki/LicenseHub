using LicenseHubApp.Models.Filters;

namespace LicenseHubApp.Models.Managers
{
    public class CompanyManager : BaseModelManager<CompanyModel>
    {
        private static readonly object LockObject = new();
        private static CompanyManager? _instance;
        private static IFilterStrategy<CompanyModel>? _filterStrategy;

        private CompanyManager() { }
        public static CompanyManager GetInstance(ICompanyRepository repository, IFilterStrategy<CompanyModel> fs)
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
                        _filterStrategy = fs;
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

        public void AddEmployee(int companyId, EmployeeModel employeeModel)
        {
            ((ICompanyRepository)Repository).AddEmployeeAsync(companyId, employeeModel);
        }

        public void ToggleIsActive(CompanyModel model)
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

        public static bool IsNipValid(string nip)
        {
            if (nip == "0")
                return true;

            if (nip.Length != 10 || nip.Any(chr => !Char.IsDigit(chr)))
                return false;

            int[] weights = { 6, 5, 7, 2, 3, 4, 5, 6, 7, 0 };
            var sum = nip.Zip(weights, (digit, weight) => (digit - '0') * weight).Sum();

            return (sum % 11) == (nip[9] - '0');
        }

    }
}
