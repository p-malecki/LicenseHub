
namespace LicenseHubApp.Models.Filters
{
    public class CustomerNipFilterStrategy : IFilterStrategy<CompanyModel>
    {
        public IEnumerable<CompanyModel> Filter(IEnumerable<CompanyModel> models, string filterValue)
        {
            return models.Where(m => m.Nip.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
