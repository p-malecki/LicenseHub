
namespace LicenseHubApp.Models.Filters
{
    public class WorkstationOsBitVersionFilterStrategy : IFilterStrategy<WorkstationModel>
    {
        public IEnumerable<WorkstationModel> Filter(IEnumerable<WorkstationModel> models, string filterValue)
        {
            return models.Where(m => m.OsBitVersion.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
