namespace LicenseHubApp.Views.Interfaces;

public interface IOrderDetailView
{
    #region Properties

    string Message { get; set; }
    bool IsSuccessful { get; set; }


    int OrderId { get; set; }
    string OrderCompanyName { get; set; }
    string OrderCompanyNip { get; set; }
    DateTime DateOfOrder { get; set; }
    DateTime DateOfPayment { get; set; }
    string Description { get; set; }

    bool IsGoToWorkstationProductEnabled { get; set; }

    #endregion


    #region Events

    event EventHandler CloseDetailViewBtnClicked;
    event EventHandler EditBtnClicked;
    event EventHandler EditCancelBtnClicked;
    event EventHandler SaveBtnClicked;
    event EventHandler GoToWorkstationProductBtnClicked;

    #endregion


    #region Methods

    void SetWorkstationProductListBindingSource(BindingSource workstationProductList);

    void SetViewToEditable(bool editable);

    #endregion
}