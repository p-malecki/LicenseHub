
namespace LicenseHubApp.Models.Filters
{
    public class WorkstationUsernameFilterStrategy : IFilterStrategy<WorkstationModel>
    {
        public IEnumerable<WorkstationModel> Filter(IEnumerable<WorkstationModel> models, string filterValue)
        {
            return models.Where(m => m.Username.StartsWith(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
