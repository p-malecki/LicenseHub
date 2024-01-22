using LicenseHubApp.Views.Interfaces;
using static LicenseHubApp.Utils.ListStoredInStringParser;
namespace LicenseHubApp.Views.Forms;

public partial class EmployeeDetailView : UserControl, IEmployeeDetailView
{
    public EmployeeDetailView()
    {
        InitializeComponent();
        AssociateAndRaiseViewEvents();
        Message = "";
    }

    private void AssociateAndRaiseViewEvents()
    {

        btnEdit.Click += delegate
        {
            EditBtnClicked?.Invoke(this, EventArgs.Empty);
        };

        btnSave.Click += delegate
        {
            SaveBtnClicked?.Invoke(this, EventArgs.Empty);
            if (IsSuccessful)
            {
                MessageBox.Show(Message);
            }
            else
            {
                MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        };

        btnEditCancel.Click += delegate
        {
            EditCancelBtnClicked?.Invoke(this, EventArgs.Empty);
        };

        chbEmployeeIsActive.Click += delegate // property change doesn't fire the Click event
        {
            IsActiveToggled?.Invoke(this, EventArgs.Empty);
        };

        btnGoToWorkstation.Click += delegate
        {
            GoToWorkstationBtnClicked?.Invoke(this, EventArgs.Empty);
        };

        btnCloseDetailView.Click += delegate
        {
            CloseDetailViewBtnClicked?.Invoke(this, EventArgs.Empty);
        };
    }


    #region Properties
    public string Message { get; set; }
    public bool IsSuccessful { get; set; }


    public int EmployeeId { get; set; }

    public string EmployeeCompanyName
    {
        get => lbCompanyName.Text;
        set => lbCompanyName.Text = value;
    }
    public bool EmployeeIsActive
    {
        get => chbEmployeeIsActive.Checked;
        set => chbEmployeeIsActive.Checked = value;
    }
    public string EmployeeName
    {
        get => txtEmployeeName.Text;
        set => txtEmployeeName.Text = value;
    }
    public string EmployeeProfession
    {
        get => txtEmployeeProfession.Text;
        set => txtEmployeeProfession.Text = value;
    }
    public string EmployeePhoneNumbers
    {
        get => ParseMultilineToSingleLine(rtxtEmployeePhoneNumbers.Text);
        set => rtxtEmployeePhoneNumbers.Text = ParseSingleLineToMultiline(value);
    }
    public string EmployeeEmails
    {
        get => ParseMultilineToSingleLine(rtxtEmployeeEmails.Text);
        set => rtxtEmployeeEmails.Text = ParseSingleLineToMultiline(value);
    }
    public string EmployeeWebsites
    {
        get => ParseMultilineToSingleLine(rtxtEmployeeWebsites.Text);
        set => rtxtEmployeeWebsites.Text = ParseSingleLineToMultiline(value);
    }
    public string EmployeeIPs
    {
        get => ParseMultilineToSingleLine(rtxtEmployeeIPs.Text);
        set => rtxtEmployeeIPs.Text = ParseSingleLineToMultiline(value);
    }
    public string EmployeeDescription
    {
        get => ParseMultilineToSingleLine(rtxtEmployeeDescription.Text);
        set => rtxtEmployeeDescription.Text = ParseSingleLineToMultiline(value);
    }

    public bool IsGoToWorkstationEnabled
    {
        get => btnGoToWorkstation.Enabled;
        set => btnGoToWorkstation.Enabled = value;
    }


    #endregion


    #region Events

    public event EventHandler? EditBtnClicked;
    public event EventHandler? SaveBtnClicked;
    public event EventHandler? EditCancelBtnClicked;
    public event EventHandler? IsActiveToggled;
    public event EventHandler? GoToWorkstationBtnClicked;
    public event EventHandler? CloseDetailViewBtnClicked;

    #endregion


    #region Methods
    public void SetWorkstationListBindingSource(BindingSource workstationList)
    {
        dgvWorkstationsData.DataSource = workstationList;
        dgvWorkstationsData.ClearSelection();
    }

    public void SetViewToEditable(bool editable)
    {
        txtEmployeeName.ReadOnly = !editable;
        txtEmployeeProfession.ReadOnly = !editable;
        rtxtEmployeePhoneNumbers.ReadOnly = !editable;
        rtxtEmployeeEmails.ReadOnly = !editable;
        rtxtEmployeeWebsites.ReadOnly = !editable;
        rtxtEmployeeIPs.ReadOnly = !editable;
        rtxtEmployeeDescription.ReadOnly = !editable;

        rtxtEmployeePhoneNumbers.BackColor = editable ? Color.White : SystemColors.Control;
        rtxtEmployeeEmails.BackColor = editable ? Color.White : SystemColors.Control;
        rtxtEmployeeWebsites.BackColor = editable ? Color.White : SystemColors.Control;
        rtxtEmployeeIPs.BackColor = editable ? Color.White : SystemColors.Control;
        rtxtEmployeeDescription.BackColor = editable ? Color.White : SystemColors.Control;

        btnEdit.Visible = !editable;
        btnSave.Visible = editable;
        btnEditCancel.Visible = editable;
        chbEmployeeIsActive.Visible = editable;
    }

    #endregion

}