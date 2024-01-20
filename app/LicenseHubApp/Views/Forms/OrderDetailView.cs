using LicenseHubApp.Views.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Windows.Forms;
namespace LicenseHubApp.Views.Forms;


public partial class OrderDetailView : UserControl, IOrderDetailView
{
    #region Constructor

    public OrderDetailView()
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

        btnEdit.Click += delegate
        {
            EditBtnClicked?.Invoke(this, EventArgs.Empty);
        };

        btnEditCancel.Click += delegate
        {
            EditCancelBtnClicked?.Invoke(this, EventArgs.Empty);
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

        btnGoToWorkstationProduct.Click += delegate
        {
            GoToWorkstationProductBtnClicked?.Invoke(this, EventArgs.Empty);
        };

    }

    #endregion


    #region Properties


    public string Message { get; set; }
    public bool IsSuccessful { get; set; }

    public int OrderId { get; set; }
    public string OrderCompanyName
    {
        get => lblCompanyName.Text;
        set => lblCompanyName.Text = value;
    }
    public string OrderCompanyNip
    {
        get => lblCompanyNip.Text;
        set => lblCompanyNip.Text = value;
    }
    public DateTime DateOfOrder
    {
        get => dtpDateOfOrder.Value;
        set => dtpDateOfOrder.Value = value;
    }
    public DateTime DateOfPayment
    {
        get => dtpDateOfPayment.Value;
        set => dtpDateOfPayment.Value = value;
    }
    public string Description
    {
        get => rtxDescription.Text;
        set => rtxDescription.Text = value;
    }

    public bool IsGoToWorkstationProductEnabled
    {
        get => btnGoToWorkstationProduct.Enabled;
        set => btnGoToWorkstationProduct.Enabled = value;
    }


    #endregion


    #region Events

    public event EventHandler CloseDetailViewBtnClicked;
    public event EventHandler EditBtnClicked;
    public event EventHandler EditCancelBtnClicked;
    public event EventHandler SaveBtnClicked;
    public event EventHandler GoToWorkstationProductBtnClicked;

    #endregion


    #region Methods

    public void SetWorkstationProductListBindingSource(BindingSource workstationProductList)
    {
        dgvWorkstationProductData.DataSource = workstationProductList;
        dgvWorkstationProductData.ClearSelection();
    }

    public void SetViewToEditable(bool editable)
    {
        dtpDateOfOrder.Enabled = editable;
        dtpDateOfPayment.Enabled = editable;
        rtxDescription.ReadOnly = editable;
        rtxDescription.BackColor = editable ? Color.White : SystemColors.Control;
    }

    #endregion

}