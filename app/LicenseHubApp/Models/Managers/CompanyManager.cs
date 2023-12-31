namespace LicenseHubApp.Models.Managers
{
    public sealed class CompanyManager
    {
        private static readonly object LockObject = new();
        private static CompanyManager _instance;
        private static ICompanyRepository _repository;
        private IEnumerable<CompanyModel> _companyList;

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
                        _repository = repository;
                    }
                }
            }
            return _instance;
        }

        public void LoadAllCompanys()
        {
            _companyList = _repository.GetAllAsync().Result.ToList();
        }
        public IEnumerable<CompanyModel> GetAllCompanies()
        {
            return _companyList;
        }

        public void AddCompany(int id, string name, string nip, List<string> localizations, List<string> websites, string description)
        {
            try
            {
                var company = new CompanyModel
                {
                    Id = id,
                    Name = name,
                    Nip = nip,
                    Localizations = localizations,
                    Websites = websites,
                    Description = description
                };

                if (!_repository.IsIdUnique(company.Id))
                {
                    Type objtype = company.GetType();
                    throw new InvalidOperationException($"{objtype.Name} with ID {company.Id} already exists.");
                }
                SaveCompany(company);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void SaveCompany(CompanyModel company)
        {
            try
            {
                if (company.Validate())
                {
                    if (!_repository.IsIdUnique(company.Id))
                        _ = _repository.AddAsync(company);
                    else
                        _ = _repository.EditAsync(company.Id, company);
                    LoadAllCompanys();
                }
                else
                {
                    Type objtype = company.GetType();
                    throw new InvalidOperationException($"{objtype.Name} validation failed.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                throw;
            }
        }
        public void DeleteCompany(CompanyModel company)
        {
            try
            {
                if (!_repository.IsIdUnique(company.Id))
                {
                    var a = _repository.DeleteAsync(company.Id);

                }
                else
                {
                    Type objtype = company.GetType();
                    throw new InvalidOperationException($"{objtype.Name} with ID {company.Id} does not exist.");
                }
                LoadAllCompanys();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                throw;
            }
        }
    }
}
