using LicenseHubApp.Models;

namespace LicenseHubApp.Services;

public interface IOrderBuilder
{
    void Reset();
    void SetOrderData(string contractNumber, DateTime dateOfOrder, DateTime dateOfPayment, string description);
    void SetCompanyData(CompanyModel company);

    void CreateWorkstationProductData(ProductReleaseModel release, string licenseType, DateTime? registerDate,
        DateTime? activationDate);
    OrderModel GetProduct();

}