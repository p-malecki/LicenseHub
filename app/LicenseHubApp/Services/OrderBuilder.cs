using LicenseHubApp.Models;

namespace LicenseHubApp.Services;

public class OrderBuilder
{
    private OrderModel _orderModel = new();

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

    public void AddWorkstationProduct(WorkstationProductModel workstationProduct, int quantity)
    {
        for (var i = 0; i < quantity; i++)
            _orderModel.WorkstationProducts.Add(workstationProduct);
    }
    
    public void RemoveWorkstationProduct(WorkstationProductModel workstationProduct)
    {
        _orderModel.WorkstationProducts.Remove(workstationProduct);
    }

    public List<WorkstationProductModel> GetAllWorkstationProducts()
    {
        return _orderModel.WorkstationProducts.ToList();
    }

    public OrderModel GetProduct()
    {
        var result = _orderModel;
        Reset();
        return result;
    }
}