using LicenseHubApp.Models;
using System.ComponentModel;
using System.Diagnostics;

namespace LicenseHubApp.Services;

public class OrderBuilder : IOrderBuilder
{
    private OrderModel _orderModel = new()
    {
        WorkstationProducts = new List<WorkstationProductModel>()
    };


    public void Reset()
    {
        _orderModel = new OrderModel();
    }

    public void SetOrderData(string contractNumber, DateTime dateOfOrder, DateTime dateOfPayment, string description)
    {
        _orderModel.ContractNumber = contractNumber;
        _orderModel.DateOfOrder = dateOfOrder;
        _orderModel.DateOfPayment = dateOfPayment;
        _orderModel.Description = description;
    }

    public void SetCompanyData(CompanyModel company)
    {
        _orderModel.Company = company;
        _orderModel.CompanyId = company.Id;
    }

    public void CreateWorkstationProductData(ProductReleaseModel release, string licenseType, DateTime? registerDate, DateTime? activationDate)
    {
        ILicense license;

        switch (licenseType)
        {
            case "SubscriptionLicense":
                var slc = new SubscriptionLicenseCreator();
                license = slc.CreateLicense(registerDate, activationDate);
                break;
            case "PerpetualLicense":
                var plc = new PerpetualLicenseCreator();
                license = plc.CreateLicense(registerDate, activationDate);
                break;
            default:
                throw new ArgumentException("Incorrect license type.");
        }

        var workstationProduct = new WorkstationProductModel()
        {
            ProductRelease = release,
            License = license as LicenseModel,
        };
        _orderModel.WorkstationProducts.Add(workstationProduct);
    }

    public OrderModel GetProduct()
    {
        var result = this._orderModel;
        Reset();
        return result;
    }
}