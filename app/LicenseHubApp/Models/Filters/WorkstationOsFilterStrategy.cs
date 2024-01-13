
namespace LicenseHubApp.Models.Filters
{
    public class WorkstationOsFilterStrategy : IFilterStrategy<WorkstationModel>
    {
        public IEnumerable<WorkstationModel> Filter(IEnumerable<WorkstationModel> models, string filterValue)
        {
            return models.Where(m => m.Os.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
