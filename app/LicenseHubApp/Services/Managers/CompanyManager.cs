using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;

namespace LicenseHubApp.Services.Managers
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

        public void AddWorkstation(int companyId, WorkstationModel workstationModel)
        {
            ((ICompanyRepository)Repository).AddWorkstationAsync(companyId, workstationModel);
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

    }
}
