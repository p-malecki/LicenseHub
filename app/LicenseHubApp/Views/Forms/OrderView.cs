using LicenseHubApp.Views.Interfaces;
namespace LicenseHubApp.Views.Forms;


public partial class OrderView : UserControl, IOrderView
{
    #region Constructor

    public OrderView()
    {
        InitializeComponent();
        AssociateAndRaiseViewEvents();

        cmbSearchCompanyName.Items.Add("all");
        cmbSearchCompanyName.SelectedIndex = 0;
        // TODO load combobox filters
    }

    private void AssociateAndRaiseViewEvents()
    {
        chbCompanyFilters.CheckedChanged += delegate
        {
            AreCompanyFiltersActive = chbCompanyFilters.Checked;
        };

        chbOrderFilters.CheckedChanged += delegate
        {
            AreOrderFiltersActive = chbOrderFilters.Checked;
        };

        btnSearch.Click += delegate
        {
            SearchBtnClicked?.Invoke(this, EventArgs.Empty);
            if (!IsSuccessful)
            {
                MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        };

        btnAdd.Click += delegate
        {
            AddBtnClicked?.Invoke(this, EventArgs.Empty);
        };

        btnShowDetails.Click += delegate
        {
            ShowDetailsBtnClicked?.Invoke(this, EventArgs.Empty);
            if (!IsSuccessful)
            {
                MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        };

        txtSearchCompanyNip.KeyPress += NumbersOnlyTextBoxKeyPressed;
        txtSearchOrderContractNumber.KeyPress += NumbersOnlyTextBoxKeyPressed;

    }

    #endregion


    #region Properties


    public string Message { get; set; }
    public bool IsSuccessful { get; set; }

    public bool AreCompanyFiltersActive
    {
        get => chbCompanyFilters.Checked;
        set
        {
            chbCompanyFilters.Checked = value;
            cmbSearchCompanyName.Enabled = value;
            txtSearchCompanyNip.Enabled = value;
            //btnSearch.Enabled = value | chbOrderFilters.Checked;
        }
    }

    public string CompanySearchCompanyName
    {
        get => cmbSearchCompanyName.Text;
        set => cmbSearchCompanyName.Text = value;
    }
    public string CompanySearchCompanyNip
    {
        get => txtSearchCompanyNip.Text.Trim();
        set => txtSearchCompanyNip.Text = value;
    }
    public bool AreOrderFiltersActive
    {
        get => chbOrderFilters.Checked;
        set
        {
            chbOrderFilters.Checked = value;
            txtSearchOrderContractNumber.Enabled = value;
            //btnSearch.Enabled = value | chbCompanyFilters.Checked;
        }
    }
    public string OrderSearchOrderContractNumber
    {
        get => txtSearchOrderContractNumber.Text.Trim();
        set => txtSearchOrderContractNumber.Text = value;
    }

    #endregion


    #region Events

    public event EventHandler SearchBtnClicked;
    public event EventHandler AddBtnClicked;
    public event EventHandler ShowDetailsBtnClicked;

    #endregion


    #region Methods

    public void SetOrderListBindingSource(BindingSource orderList)
    {
        dgvOrderData.DataSource = orderList;
        dgvOrderData.ClearSelection();
    }

    public void SetViewToSelectable(bool enabled)
    {
        btnShowDetails.Enabled = enabled;
    }


    // TODO (ref) extract method, add to num textboxes
    private void NumbersOnlyTextBoxKeyPressed(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    #endregion

}