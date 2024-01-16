using LicenseHubApp.Models;
namespace LicenseHubApp.Repositories;


public class LicenseRepository(
    IPerpetualLicenseRepository perpetualLicenseRepository,
    ISubscriptionLicenseRepository subscriptionLicenseRepository)
    : BaseRepository, ILicenseRepository
{
    private string? _licenseType;
    private readonly IPerpetualLicenseRepository? _perpetualLicenseRepository = perpetualLicenseRepository;
    private readonly ISubscriptionLicenseRepository? _subscriptionLicenseRepository = subscriptionLicenseRepository;


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
                await _perpetualLicenseRepository!.AddAsync((PerpetualLicenseModel)model);
                break;
            case "SubscriptionLicense":
                await _subscriptionLicenseRepository!.AddAsync((SubscriptionLicenseModel)model);
                break;
        }
    }
    public async Task EditAsync(int modelId, LicenseModel updatedModel)
    {
        switch (_licenseType)
        {
            case null:
                throw new Exception("LicenseType is not set.");
            case "PerpetualLicense":
                await _perpetualLicenseRepository!.EditAsync(modelId, (PerpetualLicenseModel)updatedModel);
                break;
            case "SubscriptionLicense":
                await _subscriptionLicenseRepository!.EditAsync(modelId, (SubscriptionLicenseModel)updatedModel);
                break;
        }
    }
    public async Task DeleteAsync(int modelId)
    {
        switch (_licenseType)
        {
            case null:
                throw new Exception("LicenseType is not set.");
            case "PerpetualLicense":
                await _perpetualLicenseRepository!.DeleteAsync(modelId);
                break;
            case "SubscriptionLicense":
                await _subscriptionLicenseRepository!.DeleteAsync(modelId);
                break;
        }
    }
    public async Task<IList<LicenseModel>> GetAllAsync()
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                return (IList<LicenseModel>)await _perpetualLicenseRepository!.GetAllAsync();
            case "SubscriptionLicense":
                return (IList<LicenseModel>)await _subscriptionLicenseRepository!.GetAllAsync();
            default:
                throw new Exception("LicenseType is not set.");
        }
    }
    public async Task<LicenseModel?> GetModelByIdAsync(int modelId)
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                return await _perpetualLicenseRepository!.GetModelByIdAsync(modelId);
            case "SubscriptionLicense":
                return await _subscriptionLicenseRepository!.GetModelByIdAsync(modelId);
            default:
                throw new Exception("LicenseType is not set.");
        }
    }
    public bool IsIdUnique(int modelId)
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                return _perpetualLicenseRepository!.IsIdUnique(modelId);
            case "SubscriptionLicense":
                return _subscriptionLicenseRepository!.IsIdUnique(modelId);
            default:
                throw new Exception("LicenseType is not set.");
        }
    }
}
