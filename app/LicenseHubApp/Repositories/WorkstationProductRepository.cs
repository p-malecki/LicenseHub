using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using LicenseHubApp.Repositories.GenericRepository;
namespace LicenseHubApp.Repositories;

public class WorkstationProductRepository(DataContext context) : GenericRepository<WorkstationProductModel>(context), IWorkstationProductRepository
{
  
}