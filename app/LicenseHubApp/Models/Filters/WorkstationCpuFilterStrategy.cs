
namespace LicenseHubApp.Models.Filters
{
    public class WorkstationCpuFilterStrategy : IFilterStrategy<WorkstationModel>
    {
        public IEnumerable<WorkstationModel> Filter(IEnumerable<WorkstationModel> models, string filterValue)
        {
            return models.Where(m => m.Cpu.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
