using LicenseHubApp.Models;

namespace LicenseHubApp.Views.Interfaces;

public interface IOrderCreatorView
{
    #region Properties

    string Message { get; set; }
    bool IsSuccessful { get; set; }


    int OrderId { get; set; }
    string OrderCompanySelected { get; set; }
    bool OrderIsCompanyNameSelected { get; set; }
    string OrderContractNumber { get; set; }
    bool OrderIsCompanyNipSelected { get; set; }
    DateTime DateOfOrder { get; set; }
    DateTime DateOfPayment { get; set; }
    string Description { get; set; }

    int ProductSelected { get; set; }
    int ProductReleaseSelected { get; set; }
    int ProductQuantity { get; set; }
    string LicenseTypeSelected { get; set; }
    int LicenseLeaseTermInDays { get; set; }

    #endregion


    #region Events

    event EventHandler ProductSelectedChanged;
    event EventHandler ProductAddBtnClicked;
    event EventHandler ProductRemoveBtnClicked;
    event EventHandler LicenseRegisterBtnClicked;
    event EventHandler LicenseActivateBtnClicked;
    event EventHandler OrderAddBtnClicked;
    event EventHandler OrderCancelBtnClicked;

    #endregion


    #region Methods

    void SetCompanyNameList(IList<CompanyModel> companyModels);
    void SetProductNameList(IList<ProductModel> productModels);
    void SetProductReleaseNameList(IList<ProductReleaseModel> productReleaseModels);
    void SetLicenseTypeListBindingSource(BindingSource licenseTypeList);

    void SetWorkstationProductListBindingSource(BindingSource workstationProductList);
    void SetProductAddBtnState(bool enabled);
    void SetProductToSelectable(bool editable);
    void SetOrderAddBtnState(bool enabled);

    #endregion
}