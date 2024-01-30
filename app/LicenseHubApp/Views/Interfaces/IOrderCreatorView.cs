namespace LicenseHubApp.Views.Interfaces;

public interface IOrderCreatorView
{
    #region Properties

    string Message { get; set; }
    bool IsSuccessful { get; set; }


    int OrderId { get; set; }
    string OrderCompanySelector { get; set; }
    string OrderCompanyName { get; set; }
    string OrderCompanyNip { get; set; }
    DateTime DateOfOrder { get; set; }
    DateTime DateOfPayment { get; set; }
    string Description { get; set; }

    string ProductName { get; set; }
    string ProductRelease { get; set; }
    int ProductQuantity { get; set; }
    string LicenseType { get; set; }
    int LicenseLeaseTermInDays { get; set; }

    #endregion


    #region Events

    event EventHandler OrderCompanyNameSelectorBtnToggled;
    event EventHandler OrderCompanyNipSelectorBtnToggled;
    event EventHandler ProductAddBtnClicked;
    event EventHandler ProductCancelBtnClicked;
    event EventHandler ProductRemoveBtnClicked;
    event EventHandler LicenseRegisterBtnClicked;
    event EventHandler LicenseActivateBtnClicked;
    event EventHandler OrderAddBtnClicked;
    event EventHandler OrderCancelBtnClicked;

    #endregion


    #region Methods

    void SetWorkstationProductListBindingSource(BindingSource workstationProductList);
    void SetProductToSelectable(bool editable);

    #endregion
}