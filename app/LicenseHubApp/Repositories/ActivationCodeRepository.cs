using LicenseHubApp.Models;
using LicenseHubApp.Repositories.GenericRepository;
using System.Reflection;
namespace LicenseHubApp.Repositories;

public class ActivationCodeRepository(DataContext context) : GenericRepository<ActivationCodeModel>(context), IActivationCodeRepository
{
    public async Task<IList<GeneratedActivationCodeModel>> GetAllGeneratedActivationCode()
    {
        var destinationList = new List<GeneratedActivationCodeModel>();
        var sourceList = GetAll();

        foreach (var sourceElement in sourceList)
        {
            var destElement = Activator.CreateInstance<GeneratedActivationCodeModel>();
            PropertyInfo[] sourceProperties = typeof(ActivationCodeModel).GetProperties();
            foreach (PropertyInfo sourceProperty in sourceProperties)
            {
                var destProperty = typeof(GeneratedActivationCodeModel).GetProperty(sourceProperty.Name);

                if (destProperty != null && destProperty.PropertyType.IsAssignableFrom(sourceProperty.PropertyType))
                {
                    destProperty.SetValue(destElement, sourceProperty.GetValue(sourceElement));
                }
            }
            destinationList.Add(destElement);
        }
        return destinationList;
    }

    public async Task<GeneratedActivationCodeModel?> GetByIdGeneratedActivationCodeModel(int id)
    {
        var model = await GetById(id);
        return (GeneratedActivationCodeModel)model;
    }

    public async Task CreateGeneratedActivationCode(GeneratedActivationCodeModel model)
    { 
        await Create(model);
    }

    public async Task UpdateGeneratedActivationCode(int id, GeneratedActivationCodeModel model)
    {
        await Update(id, model);
    }

    public async Task DeleteGeneratedActivationCode(int id)
    {
        await Delete(id);
    }
}