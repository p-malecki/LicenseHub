
namespace LicenseHubApp.Models.Filters
{
    public class CustomerNipFilterStrategy : IFilterStrategy<CompanyModel>
    {
        public IEnumerable<CompanyModel> Filter(IEnumerable<CompanyModel> models, string filterValue)
        {
            return models.Where(c => c.Nip.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
