using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
namespace LicenseHubApp.Repositories;


public class LicenseRepository : BaseRepository, ILicenseRepository, IPerpetualLicenseRepository, ISubscriptionLicenseRepository
{
    private string? _licenseType;

    public void SetLicenseType(string licenseType)
    {
        _licenseType = licenseType switch
        {
            "PerpetualLicense" or "SubscriptionLicense" => licenseType,
            _ => throw new ArgumentException("Incorrect license type.")
        };
    }


    public async Task AddAsync(LicenseModel model)
    {
        switch (_licenseType)
        {
            case null:
                throw new Exception("LicenseType is not set.");
            case "PerpetualLicense":
                await((IModelRepository<PerpetualLicenseModel>)this).AddAsync((PerpetualLicenseModel)model);
                break;
            case "SubscriptionLicense":
                await((IModelRepository<SubscriptionLicenseModel>)this).AddAsync((SubscriptionLicenseModel)model);
                break;
        }
    }

    public async Task AddAsync(PerpetualLicenseModel model)
    {
        try
        {
            context.Licenses.Add(model);
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public async Task AddAsync(SubscriptionLicenseModel model)
    {
        try
        {
            context.Licenses.Add(model);
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }


    public async Task EditAsync(int modelId, LicenseModel updatedModel)
    {
        switch (_licenseType)
        {
            case null:
                throw new Exception("LicenseType is not set.");
            case "PerpetualLicense":
                await((IModelRepository<PerpetualLicenseModel>)this).EditAsync(modelId, (PerpetualLicenseModel)updatedModel);
                break;
            case "SubscriptionLicense":
                await((IModelRepository<SubscriptionLicenseModel>)this).EditAsync(modelId, (SubscriptionLicenseModel)updatedModel);
                break;
        }
    }
    public async Task EditAsync(int modelId, PerpetualLicenseModel updatedModel)
    {
        var modelToUpdate = await ((IModelRepository<PerpetualLicenseModel>)this).GetModelByIdAsync(modelId);

        if (modelToUpdate != null)
        {
            modelToUpdate.RegisterDate = updatedModel.RegisterDate;
            modelToUpdate.ActivationDate = updatedModel.ActivationDate;

            await context.SaveChangesAsync();
        }
    }

    public async Task EditAsync(int modelId, SubscriptionLicenseModel updatedModel)
    {
        var modelToUpdate = await ((IModelRepository<SubscriptionLicenseModel>)this).GetModelByIdAsync(modelId);

        if (modelToUpdate != null)
        {
            modelToUpdate.RegisterDate = updatedModel.RegisterDate;
            modelToUpdate.ActivationDate = updatedModel.ActivationDate;
            modelToUpdate.LeaseTermInDays = updatedModel.LeaseTermInDays;

            await context.SaveChangesAsync();
        }
    }


    public async Task DeleteAsync(int modelId)
    {
        switch (_licenseType)
        {
            case null:
                throw new Exception("LicenseType is not set.");
            case "PerpetualLicense":
                await ((IModelRepository<PerpetualLicenseModel>)this).DeleteAsync(modelId);
                break;
            case "SubscriptionLicense":
                await ((IModelRepository<SubscriptionLicenseModel>)this).DeleteAsync(modelId);
                break;
        }
    }

    async Task IModelRepository<PerpetualLicenseModel>.DeleteAsync(int modelId)
    {
        var modelToDelete = await ((IModelRepository<PerpetualLicenseModel>)this).GetModelByIdAsync(modelId);
        if (modelToDelete != null)
        {
            context.Licenses.Remove(modelToDelete);
            await context.SaveChangesAsync();
        }
    }

    async Task IModelRepository<SubscriptionLicenseModel>.DeleteAsync(int modelId)
    {
        var modelToDelete = await ((IModelRepository<SubscriptionLicenseModel>)this).GetModelByIdAsync(modelId);
        if (modelToDelete != null)
        {
            context.Licenses.Remove(modelToDelete);
            await context.SaveChangesAsync();
        }
    }


    public async Task<IList<LicenseModel>> GetAllAsync()
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                return (IList<LicenseModel>)await ((IModelRepository<PerpetualLicenseModel>)this).GetAllAsync();
            case "SubscriptionLicense":
                return (IList<LicenseModel>)await ((IModelRepository<SubscriptionLicenseModel>)this).GetAllAsync();
            default:
                throw new Exception("LicenseType is not set.");
        }
    }

    async Task<IList<PerpetualLicenseModel>> IModelRepository<PerpetualLicenseModel>.GetAllAsync()
    {
        return await context.Licenses.OfType<PerpetualLicenseModel>().ToListAsync();
    }

    async Task<IList<SubscriptionLicenseModel>> IModelRepository<SubscriptionLicenseModel>.GetAllAsync()
    {
        return await context.Licenses.OfType<SubscriptionLicenseModel>().ToListAsync();
    }


    public async Task<LicenseModel?> GetModelByIdAsync(int modelId)
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                return await ((IModelRepository<PerpetualLicenseModel>)this).GetModelByIdAsync(modelId);
            case "SubscriptionLicense":
                return await((IModelRepository<SubscriptionLicenseModel>)this).GetModelByIdAsync(modelId);
            default:
                throw new Exception("LicenseType is not set.");
        }
    }
    async Task<PerpetualLicenseModel?> IModelRepository<PerpetualLicenseModel>.GetModelByIdAsync(int modelId)
    {
        return await context.Licenses.OfType<PerpetualLicenseModel>().FirstOrDefaultAsync(m => m.Id == modelId);
    }

    async Task<SubscriptionLicenseModel?> IModelRepository<SubscriptionLicenseModel>.GetModelByIdAsync(int modelId)
    {
        return await context.Licenses.OfType<SubscriptionLicenseModel>().FirstOrDefaultAsync(m => m.Id == modelId);
    }


    public bool IsIdUnique(int modelId)
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                return ((IModelRepository<PerpetualLicenseModel>)this).IsIdUnique(modelId);
            case "SubscriptionLicense":
                return ((IModelRepository<SubscriptionLicenseModel>)this).IsIdUnique(modelId);
            default:
                throw new Exception("LicenseType is not set.");
        }
    }

    bool IModelRepository<PerpetualLicenseModel>.IsIdUnique(int modelId)
    {
        // TODO (?) check whether .OfType<PerpetualLicenseModel>() can be removed
        //return !context.Licenses.Any(model => model.Id == modelId);
        return !context.Licenses.OfType<PerpetualLicenseModel>().Any(model => model.Id == modelId);
    }

    bool IModelRepository<SubscriptionLicenseModel>.IsIdUnique(int modelId)
    {
        // TODO (?) check whether .OfType<SubscriptionLicenseModel>() can be removed
        //return !context.Licenses.Any(model => model.Id == modelId);
        return !context.Licenses.OfType<SubscriptionLicenseModel>().Any(model => model.Id == modelId);
    }

}
