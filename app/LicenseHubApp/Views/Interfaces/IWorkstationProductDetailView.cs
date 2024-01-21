namespace LicenseHubApp.Views.Interfaces;


public interface IWorkstationProductDetailView
{
    #region Properties

    string CompanyName { get; set; }
    string OrderContractNumber { get; set; }
    string OrderDateOfOrder { get; set; }
    string? NumberOfUsers { get; set; }

    string ProductName { get; set; }
    string ProductNewestRelease { get; set; }
    string ProductDescription { get; set; }
    string ReleaseNumber { get; set; }
    string ReleaseInstallerVerificationPasscode { get; set; }
    string ReleaseDescription { get; set; }

    string LicenseType { get; set; }
    DateTime LicenseRegisterDate { get; set; }
    int LicenseLeaseInDays { get; set; }
    string LicenseActivationCode { get; set; }
    bool LicenseIsActivationCodeGenerated { get; set; }
    string? LicenseActivationCodeGenVersion { get; set; }
    DateTime LicenseActivationDate { get; set; }
    DateTime LicenseEndOfLicensePeriodDate { get; set; }


    #endregion


    #region Events

    event EventHandler CloseDetailViewBtnClicked;

    #endregion


    #region Methods

    void SetEmployeeListBindingSource(BindingSource employeeList);

    #endregion

}