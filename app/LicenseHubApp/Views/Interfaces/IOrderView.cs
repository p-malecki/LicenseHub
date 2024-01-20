namespace LicenseHubApp.Views.Interfaces;

public interface IOrderView
{
    #region Properties

    string Message { get; set; }
    bool IsSuccessful { get; set; }

    bool AreCompanyFiltersActive { get; set; }
    string CompanySearchCompanyName { get; set; }
    string CompanySearchCompanyNip { get; set; }
    bool AreOrderFiltersActive { get; set; }
    string OrderSearchOrderContractNumber { get; set; }

    #endregion


    #region Events

    event EventHandler SearchBtnClicked;
    event EventHandler AddBtnClicked;
    event EventHandler ShowDetailsBtnClicked;
    event EventHandler EditBtnClicked;

    #endregion


    #region Methods

    void SetOrderListBindingSource(BindingSource orderList);
    void SetViewToSelectable(bool enabled);

    #endregion
}