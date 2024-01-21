using LicenseHubApp.Views.Interfaces;

namespace LicenseHubApp.Views.Forms;

public partial class WorkstationProductDetailView : UserControl, IWorkstationProductDetailView
{
    public WorkstationProductDetailView()
    {
        InitializeComponent();
        AssociateAndRaiseViewEvents();
    }

    private void AssociateAndRaiseViewEvents()
    {
        btnCloseDetailView.Click += delegate
        {
            CloseDetailViewBtnClicked?.Invoke(this, EventArgs.Empty);
        };
    }


    #region Properties

    string IWorkstationProductDetailView.CompanyName
    {
        get => lblCompanyName.Text;
        set => lblCompanyName.Text = value;
    }
    public string OrderContractNumber
    {
        get => lblOrderContractNumber.Text;
        set => lblOrderContractNumber.Text = value;
    }
    public string OrderDateOfOrder 
    {
        get => lblOrderDateOfOrder.Text;
        set => lblOrderDateOfOrder.Text = value;
    }
    public string? NumberOfUsers
    {
        get => lblNumberOfUsers.Text;
        set => lblNumberOfUsers.Text = value;
    }
    string IWorkstationProductDetailView.ProductName
    {
        get => txtProductName.Text;
        set => txtProductName.Text = value;
    }
    public string ProductNewestRelease
    {
        get => txtProductNewestRelease.Text;
        set => txtProductNewestRelease.Text = value;
    }
    public string ProductDescription
    {
        get => rtxProductDescription.Text;
        set => rtxProductDescription.Text = value;
    }
    public string ReleaseNumber
    {
        get => txtReleaseNumber.Text;
        set => txtReleaseNumber.Text = value;
    }
    public string ReleaseInstallerVerificationPasscode
    {
        get => txtReleaseInstallerVerificationPasscode.Text;
        set => txtReleaseInstallerVerificationPasscode.Text = value;
    }
    public string ReleaseDescription
    {
        get => rtxReleaseDescription.Text;
        set => rtxReleaseDescription.Text = value;
    }
    public string LicenseType
    {
        get => txtLicenseType.Text;
        set => txtLicenseType.Text = value;
    }
    public DateTime LicenseRegisterDate
    {
        get => dtpLicenseRegisterDate.Value;
        set => dtpLicenseRegisterDate.Value = value;
    }
    public int LicenseLeaseInDays
    {
        get => int.Parse(txtLicenseLeaseInDays.Text);
        set => txtLicenseLeaseInDays.Text = value.ToString();
    }
    public string LicenseActivationCode
    {
        get => txtLicenseActivationCode.Text;
        set => txtLicenseActivationCode.Text = value;
    }
    public bool LicenseIsActivationCodeGenerated
    {
        get => txtLicenseActivationCodeGenVersion.Enabled;
        set => txtLicenseActivationCodeGenVersion.Enabled = value;
    }
    public string? LicenseActivationCodeGenVersion 
    {
        get => txtLicenseActivationCodeGenVersion.Text;
        set => txtLicenseActivationCodeGenVersion.Text = value;
    }
    public DateTime LicenseActivationDate
    {
        get => cdrLicenseActivationDate.SelectionStart;
        set
        {
            cdrLicenseActivationDate.SelectionStart = value;
            cdrLicenseActivationDate.SelectionEnd = value;
        }
    }
    public DateTime LicenseEndOfLicensePeriodDate 
    {
        get => cdrLicenseEndOfLicense.SelectionStart;
        set
        {
            cdrLicenseEndOfLicense.SelectionStart = value;
            cdrLicenseEndOfLicense.SelectionEnd = value;
        }
    }

    #endregion


    #region Events

    public event EventHandler? EditBtnClicked;
    public event EventHandler? SaveBtnClicked;
    public event EventHandler? EditCancelBtnClicked;
    public event EventHandler? HasFaultToggled;
    public event EventHandler? GoToEmployeeBtnClicked;
    public event EventHandler? GoToWorkstationProductBtnClicked;
    public event EventHandler? CloseDetailViewBtnClicked;

    #endregion


    #region Methods

    public void SetEmployeeListBindingSource(BindingSource employeeList)
    {
        lstEmployees.DataSource = employeeList;
    }

    #endregion
}