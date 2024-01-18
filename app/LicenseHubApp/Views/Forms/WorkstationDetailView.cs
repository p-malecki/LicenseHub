using LicenseHubApp.Views.Interfaces;

namespace LicenseHubApp.Views.Forms;

public partial class WorkstationDetailView : UserControl, IWorkstationDetailView
{
    public WorkstationDetailView()
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
            if (!IsSuccessful)
            {
                MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        chbWorkstationHasFault.Click += delegate // property change doesn't fire the Click event
        {
            HasFaultToggled?.Invoke(this, EventArgs.Empty);
        };

        btnGoToEmployee.Click += delegate
        {
            GoToEmployeeBtnClicked?.Invoke(this, EventArgs.Empty);
        };

        btnGoToWorkstationProduct.Click += delegate
        {
            GoToWorkstationProductBtnClicked?.Invoke(this, EventArgs.Empty);
        };

        btnCloseDetailView.Click += delegate
        {
            CloseDetailViewBtnClicked?.Invoke(this, EventArgs.Empty);
        };
    }


    #region Properties
    public string Message { get; set; }
    public bool IsSuccessful { get; set; }


    public int WorkstationId { get; set; }

    public string WorkstationCompanyName
    {
        get => lbCompanyName.Text;
        set => lbCompanyName.Text = value;
    }
    public bool WorkstationHasFault
    {
        get => chbWorkstationHasFault.Checked;
        set => chbWorkstationHasFault.Checked = value;
    }
    public string WorkstationComputerName
    {
        get => txtWorkstationComputerName.Text;
        set => txtWorkstationComputerName.Text = value;
    }
    public string WorkstationUsername
    {
        get => txtWorkstationUsername.Text;
        set => txtWorkstationUsername.Text = value;
    }
    public string WorkstationHardDisk
    {
        get => rtxtWorkstationHardDisk.Text;
        set => rtxtWorkstationHardDisk.Text = value;
    }
    public string WorkstationCpu
    {
        get => rtxtWorkstationCpu.Text;
        set => rtxtWorkstationCpu.Text = value;
    }
    public string WorkstationBiosVersion
    {
        get => rtxtWorkstationBiosVersion.Text;
        set => rtxtWorkstationBiosVersion.Text = value;
    }
    public string WorkstationOs
    {
        get => txtWorkstationOs.Text;
        set => txtWorkstationOs.Text = value;
    }
    public string WorkstationOsBitVersion
    {
        get => txtWorkstationOsBitVersion.Text;
        set => txtWorkstationOsBitVersion.Text = value;
    }


    public bool IsGoToEmployeeEnabled
    {
        get => btnGoToEmployee.Enabled;
        set => btnGoToEmployee.Enabled = value;
    }

    public bool IsGoToWorkstationProductEnabled
    {
        get => btnGoToWorkstationProduct.Enabled;
        set => btnGoToWorkstationProduct.Enabled = value;
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
        dgvEmployeesData.DataSource = employeeList;
        dgvEmployeesData.ClearSelection();
    }
    public void SetWorkstationProductListBindingSource(BindingSource workstationProductList)
    {
        dgvWorkstationProductsData.DataSource = workstationProductList;
        dgvWorkstationProductsData.ClearSelection();
    }

    public void SetViewToEditable(bool editable)
    {
        txtWorkstationComputerName.ReadOnly = !editable;
        txtWorkstationUsername.ReadOnly = !editable;
        rtxtWorkstationHardDisk.ReadOnly = !editable;
        rtxtWorkstationCpu.ReadOnly = !editable;
        rtxtWorkstationBiosVersion.ReadOnly = !editable;
        txtWorkstationOs.ReadOnly = !editable;
        txtWorkstationOsBitVersion.ReadOnly = !editable;

        rtxtWorkstationHardDisk.BackColor = editable ? Color.White : SystemColors.Control;
        rtxtWorkstationCpu.BackColor = editable ? Color.White : SystemColors.Control;
        rtxtWorkstationBiosVersion.BackColor = editable ? Color.White : SystemColors.Control;

        btnEdit.Visible = !editable;
        btnSave.Visible = editable;
        btnEditCancel.Visible = editable;
        chbWorkstationHasFault.Visible = editable;
    }

    #endregion

}