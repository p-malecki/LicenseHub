using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using LicenseHubApp.Repositories.GenericRepository;
using System.Linq;
namespace LicenseHubApp.Repositories;


public class LicenseRepository(
    IPerpetualLicenseRepository perpetualLicenseRepository,
    ISubscriptionLicenseRepository subscriptionLicenseRepository)
    : ILicenseRepository
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

    public async Task Create(LicenseModel model)
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                await _perpetualLicenseRepository!.Create((PerpetualLicenseModel)model);
                break;
            case "SubscriptionLicense":
                await _subscriptionLicenseRepository!.Create((SubscriptionLicenseModel)model);
                break;
            default:
                throw new Exception("LicenseType is not set.");
        }
    }
    public async Task Update(int id, LicenseModel model)
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                await _perpetualLicenseRepository!.Update(id, (PerpetualLicenseModel)model);
                break;
            case "SubscriptionLicense":
                await _subscriptionLicenseRepository!.Update(id, (SubscriptionLicenseModel)model);
                break;
            default:
                throw new Exception("LicenseType is not set.");
        }
    }
    public async Task Delete(int id)
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                await _perpetualLicenseRepository!.Delete(id);
                break;
            case "SubscriptionLicense":
                await _subscriptionLicenseRepository!.Delete(id);
                break;
            default:
                throw new Exception("LicenseType is not set.");
        }
    }

    public IEnumerable<LicenseModel> GetAll()
    {
        switch (_licenseType)
        {
            case "PerpetualLicense":
                var perpetualLicenses = _perpetualLicenseRepository!.GetAll();
                return perpetualLicenses.Cast<LicenseModel>().ToList();

            case "SubscriptionLicense":
                var subscriptionLicenses = _subscriptionLicenseRepository!.GetAll();
                return subscriptionLicenses.Cast<LicenseModel>().ToList();

            default:
                throw new Exception("LicenseType is not set.");
        }
    }

    public async Task<LicenseModel?> GetById(int modelId)
    {
        return _licenseType switch
        {
            "PerpetualLicense" => await _perpetualLicenseRepository!.GetById(modelId),
            "SubscriptionLicense" => await _subscriptionLicenseRepository!.GetById(modelId),
            _ => throw new Exception("LicenseType is not set.")
        };
    }
    public bool IsIdUnique(int modelId)
    {
        return _licenseType switch
        {
            "PerpetualLicense" => _perpetualLicenseRepository!.IsIdUnique(modelId),
            "SubscriptionLicense" => _subscriptionLicenseRepository!.IsIdUnique(modelId),
            _ => throw new Exception("LicenseType is not set.")
        };
    }
}
