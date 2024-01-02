namespace LicenseHubApp.Models.Managers
{
    public class CompanyManager : BaseModelManager<CompanyModel>
    {
        private static readonly object LockObject = new();
        private static CompanyManager _instance;

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
    }
}
