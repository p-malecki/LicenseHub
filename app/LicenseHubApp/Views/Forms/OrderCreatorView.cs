using LicenseHubApp.Views.Interfaces;
using System.Xml.Linq;
using LicenseHubApp.Models;
using System.Windows.Forms;

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
            cmbProduct.SelectedIndexChanged += delegate
            {
                ProductSelectedChanged?.Invoke(this, EventArgs.Empty);
            };
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
                IsSuccessful = true;
                OrderAddBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    MessageBox.Show(Message, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsSuccessful = true;
                }
            };
            btnOrderCancel.Click += delegate
            {
                OrderCancelBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            rdoCompanyName.Click += delegate
            {
                OrderIsCompanyNameSelected = true;
            };
            rdoCompanyNip.Click += delegate
            {
                OrderIsCompanyNipSelected = true;
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
                
                cmbSelectedCompany.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbSelectedCompany.SelectedIndex = 0;
            }
        }

        public bool OrderIsCompanyNipSelected
        {
            get => rdoCompanyNip.Checked;
            set
            {
                rdoCompanyName.Checked = !value;
                rdoCompanyNip.Checked = value;

                cmbSelectedCompany.DropDownStyle = ComboBoxStyle.DropDown;
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
            get => cmbLicenseType.Text;
            set => cmbLicenseType.Text = value;
        }

        public int LicenseLeaseTermInDays
        {
            get => (int)nudLicenseLeaseTermInDays.Value;
            set => nudLicenseLeaseTermInDays.Value = value;
        }

        #endregion


        #region Events

        public event EventHandler? ProductSelectedChanged;
        public event EventHandler? ProductAddBtnClicked;
        public event EventHandler? ProductRemoveBtnClicked;
        public event EventHandler? LicenseRegisterBtnClicked;
        public event EventHandler? LicenseActivateBtnClicked;
        public event EventHandler? OrderAddBtnClicked;
        public event EventHandler? OrderCancelBtnClicked;

        #endregion


        #region Methods

        public void SetCompanyNameList(IList<CompanyModel> companyModels)
        {
            cmbSelectedCompany.DataSource = companyModels.Select(m => m.Name).ToList();
            if (companyModels.Count > 0)
                cmbSelectedCompany.SelectedIndex = 0;
        }
        public void SetProductNameList(IList<ProductModel> productModels)
        {
            cmbProduct.DataSource = productModels.Select(m => m.Name).ToList();
            if (productModels.Count > 0)
                cmbProduct.SelectedIndex = 0;
        }
        public void SetProductReleaseNameList(IList<ProductReleaseModel> productReleaseModels)
        {
            cmbRelease.DataSource = productReleaseModels.Select(m => m.ReleaseNumber).ToList();
            if (productReleaseModels.Count > 0)
                cmbRelease.SelectedIndex = 0;
        }
        public void SetLicenseTypeListBindingSource(BindingSource licenseTypeList)
        {
            cmbLicenseType.DataSource = licenseTypeList;
            if (licenseTypeList.Count > 0)
                cmbLicenseType.SelectedIndex = 0;
        }
        public void SetWorkstationProductListBindingSource(BindingSource workstationProductList)
        {
            dgvWorkstationProductData.DataSource = workstationProductList;
        }

        public void SetProductAddBtnState(bool enabled)
        {
            btnProductAdd.Enabled = enabled;
        }

        public void SetProductToSelectable(bool editable)
        {
            btnProductRemove.Enabled = editable;
            btnLicenseRegister.Enabled = editable;
            btnLicenseActivate.Enabled = editable;
        }

        public void SetOrderAddBtnState(bool enabled)
        {
            btnOrderAdd.Enabled = enabled;
        }

        #endregion

    }
}
