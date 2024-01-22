using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Repositories;

public class WorkstationRepository(DataContext context) : GenericRepository<WorkstationModel>(context), IWorkstationRepository
{
    private IFilterStrategy<WorkstationModel> _filterStrategy = new WorkstationComputerNameFilterStrategy();

    public new async Task Update(int id, WorkstationModel model)
    {
        model.ThrowIfNotValid();

        var modelToUpdate = await GetById(id) ?? throw new NullReferenceException("Model not found.");

        modelToUpdate.ComputerName = model.ComputerName;
        modelToUpdate.Username = model.Username;
        modelToUpdate.HardDisk = model.HardDisk;
        modelToUpdate.Cpu = model.Cpu;
        modelToUpdate.BiosVersion = model.BiosVersion;
        modelToUpdate.Os = model.Os;
        modelToUpdate.OsBitVersion = model.OsBitVersion;
        modelToUpdate.HasFault = model.HasFault;

        await context.SaveChangesAsync();
    }

    public void SetFilterStrategy(IFilterStrategy<WorkstationModel> fs)
    {
        _filterStrategy = fs;
    }

    public IEnumerable<WorkstationModel> FilterWorkstation(string filterValue)
    {
        return _filterStrategy.Filter(GetAll(), filterValue);
    }

}