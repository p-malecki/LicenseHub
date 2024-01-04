
namespace LicenseHubApp.Models.Filters
{
    public class CustomerNameFilterStrategy : IFilterStrategy<CompanyModel>
    {
        public IEnumerable<CompanyModel> Filter(IEnumerable<CompanyModel> models, string filterValue)
        {
            return models.Where(c => c.Name.Contains(filterValue)).ToList();
        }
    }
}
