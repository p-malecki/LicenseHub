using LicenseHubApp.Models.Filters;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Models;

public interface IWorkstationRepository : IGenericRepository<WorkstationModel>
{
    void SetFilterStrategy(IFilterStrategy<WorkstationModel> fs);
    IEnumerable<WorkstationModel> FilterWorkstation(string filterValue);
}