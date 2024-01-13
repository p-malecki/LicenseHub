
namespace LicenseHubApp.Models.Filters
{
    public class WorkstationHardDiskFilterStrategy : IFilterStrategy<WorkstationModel>
    {
        public IEnumerable<WorkstationModel> Filter(IEnumerable<WorkstationModel> models, string filterValue)
        {
            return models.Where(m => m.HardDisk.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
