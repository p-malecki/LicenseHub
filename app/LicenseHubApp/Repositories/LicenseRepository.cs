using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;
using LicenseHubApp.Repositories.GenericRepository;
using System.Linq;
using System.ComponentModel;
namespace LicenseHubApp.Repositories;


public class LicenseRepository(
    IPerpetualLicenseRepository perpetualLicenseRepository,
    ISubscriptionLicenseRepository subscriptionLicenseRepository)
    : ILicenseRepository
{
    private readonly IPerpetualLicenseRepository? _perpetualLicenseRepository = perpetualLicenseRepository;
    private readonly ISubscriptionLicenseRepository? _subscriptionLicenseRepository = subscriptionLicenseRepository;


    public async Task Create(LicenseModel model)
    {
        switch (model.GetType().Name)
        {
            case "PerpetualLicenseModel":
                await _perpetualLicenseRepository!.Create((PerpetualLicenseModel)model);
                break;
            case "SubscriptionLicenseModel":
                await _subscriptionLicenseRepository!.Create((SubscriptionLicenseModel)model);
                break;
            default:
                throw new Exception("LicenseType is not set or incorrect license type.");
        }
    }
    public async Task Update(int id, LicenseModel model)
    {
        switch (model.GetType().Name)
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
        switch ("PerpetualLicense") // TODO rm PerpetualLicense and SubscriptionLicense and make only License class
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
        switch ("PerpetualLicense")
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
        return "PerpetualLicense" switch
        {
            "PerpetualLicense" => await _perpetualLicenseRepository!.GetById(modelId),
            "SubscriptionLicense" => await _subscriptionLicenseRepository!.GetById(modelId),
            _ => throw new Exception("LicenseType is not set.")
        };
    }
    public bool IsIdUnique(int modelId)
    {
        return "PerpetualLicense" switch
        {
            "PerpetualLicense" => _perpetualLicenseRepository!.IsIdUnique(modelId),
            "SubscriptionLicense" => _subscriptionLicenseRepository!.IsIdUnique(modelId),
            _ => throw new Exception("LicenseType is not set.")
        };
    }
}
