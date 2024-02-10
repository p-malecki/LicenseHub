using LicenseHubApp.Views.Interfaces;
using System.Xml.Linq;

namespace LicenseHubApp.Views.Forms
{
    public partial class OrderCreatorView : UserControl, IOrderCreatorView
    {
        public OrderCreatorView()
        {
            Message = "";

            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnProductAdd.Click += delegate
            {
                ProductAddBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            btnProductRemove.Click += delegate
            {
                ProductRemoveBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            btnLicenseRegister.Click += delegate
            {
                LicenseRegisterBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            btnLicenseActivate.Click += delegate
            {
                LicenseActivateBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            btnOrderAdd.Click += delegate
            {
                OrderAddBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            btnOrderCancel.Click += delegate
            {
                OrderCancelBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            rdoCompanyName.Click += delegate
            {
                OrderCompanyNameSelectorBtnToggled?.Invoke(this, EventArgs.Empty);
                rdoCompanyName.Checked = true;
                rdoCompanyNip.Checked = false;
            };
            rdoCompanyNip.Click += delegate
            {
                OrderCompanyNipSelectorBtnToggled?.Invoke(this, EventArgs.Empty);
                rdoCompanyNip.Checked = true;
                rdoCompanyName.Checked = false;
            };
        }


        #region Properties

        public string Message { get; set; }

        public bool IsSuccessful { get; set; }

        public int OrderId { get; set; }

        public string OrderCompanySelected
        {
            get => cmbSelectedCompany.Text;
            set => cmbSelectedCompany.Text = value;
        }

        public bool OrderIsCompanyNameSelected
        {
            get => rdoCompanyName.Checked;
            set
            {
                rdoCompanyName.Checked = value;
                rdoCompanyNip.Checked = !value;
                
                cmbSelectedCompany.SelectedIndex = 0;
            }
        }

        public bool OrderIsCompanyNipSelected
        {
            get => rdoCompanyNip.Checked;
            set
            {
                rdoCompanyNip.Checked = value;
                rdoCompanyName.Checked = !value;

                cmbSelectedCompany.Text = "";
            }
        }

        public string OrderContractNumber
        {
            get => txtCompanyContractNumber.Text;
            set => txtCompanyContractNumber.Text = value;
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

        public int ProductSelected
        {
            get => cmbProduct.SelectedIndex;
            set => cmbProduct.SelectedIndex = value;
        }

        public int ProductReleaseSelected
        {
            get => cmbRelease.SelectedIndex;
            set => cmbRelease.SelectedIndex = value;
        }

        public int ProductQuantity
        {
            get => (int)nudProductQuantity.Value;
            set => nudProductQuantity.Value = value;
        }

        public string LicenseTypeSelected
        {
            get => cmbLicenseType.SelectedText;
            set => cmbLicenseType.SelectedText = value;
        }

        public int LicenseLeaseTermInDays
        {
            get => (int)nudLicenseLeaseTermInDays.Value;
            set => nudLicenseLeaseTermInDays.Value = value;
        }

        #endregion


        #region Events

        public event EventHandler? OrderCompanyNameSelectorBtnToggled;
        public event EventHandler? OrderCompanyNipSelectorBtnToggled;
        public event EventHandler? ProductAddBtnClicked;
        public event EventHandler? ProductRemoveBtnClicked;
        public event EventHandler? LicenseRegisterBtnClicked;
        public event EventHandler? LicenseActivateBtnClicked;
        public event EventHandler? OrderAddBtnClicked;
        public event EventHandler? OrderCancelBtnClicked;

        #endregion


        #region Methods

        public void SetCompanyListBindingSource(BindingSource companyList)
        {
            cmbSelectedCompany.DataSource = companyList;
            cmbSelectedCompany.SelectedIndex = 0;
        }
        public void SetProductListBindingSource(BindingSource productList)
        {
            cmbProduct.DataSource = productList;
            cmbProduct.SelectedIndex = 0;
        }
        public void SetProductReleaseListBindingSource(BindingSource productReleaseList)
        {
            cmbRelease.DataSource = productReleaseList;
            cmbRelease.SelectedIndex = 0;
        }
        public void SetLicenseTypeListBindingSource(BindingSource licenseTypeList)
        {
            cmbLicenseType.DataSource = licenseTypeList;
            cmbLicenseType.SelectedIndex = 0;
        }
        public void SetWorkstationProductListBindingSource(BindingSource workstationProductList)
        {
            dgvWorkstationProductData.DataSource = workstationProductList;
        }

        public void SetProductToSelectable(bool editable)
        {
            btnProductRemove.Enabled = editable;
            btnLicenseRegister.Enabled = editable;
            btnLicenseActivate.Enabled = editable;
        }

        #endregion

    }
}
