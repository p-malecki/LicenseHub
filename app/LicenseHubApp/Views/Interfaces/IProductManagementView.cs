﻿namespace LicenseHubApp.Views.Interfaces;

public interface IProductManagementView
{
    #region Properties

    bool IsEdit { get; set; }
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    int CbProductListSelected { get; set; }
    int ProductId { get; set; }
    string ProductName { get; set; }
    bool ProductIsAvailable { get; set; }
    string ProductNewestRelease { get; set; }
    string ProductNumberOfLicensesGranted { get; set; }
    string ProductActiveClientBaseNumber { get; set; }
    string BtnProductSaveText { get; set; }

    string ReleaseNumber { get; set; }
    string ReleaseInstallerVerificationPasscode { get; set; }
    string ReleaseDescription { get; set; }

    #endregion


    #region Events

    event EventHandler ProductSelectClicked;
    event EventHandler ProductAddBtnClicked;
    event EventHandler ProductIsAvailableToggled;
    event EventHandler ProductRenameBtnClicked;
    event EventHandler ProductSaveBtnClicked;
    event EventHandler ProductRemoveBtnClicked;
    event EventHandler ReleaseAddBtnClicked;
    event EventHandler ReleaseRemoveBtnClicked;
    event EventHandler ReleaseSaveBtnClicked;

    #endregion


    #region Methods

    void SetProductListBindingSource(BindingSource productList);
    void SetReleaseDataBindingSource(BindingSource releaseList);
    void SetProductViewToSelectable(bool enabled);
    void SetProductViewToEditable(bool enabled);

    #endregion
}