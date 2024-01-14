using System.Net.Mime;
using LicenseHubApp.Views.Interfaces;

namespace LicenseHubApp.Views.Forms
{
    public partial class ProductManagementUC : UserControl, IProductManagementView
    {

        #region Constructor
        public ProductManagementUC()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            gbProductSelected.Enabled = false; // before 1st selection
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnProductSelect.Click += delegate
            {
                ProductSelectClicked?.Invoke(this, EventArgs.Empty);
            };

            btnProductAdd.Click += delegate
            {
                ProductAddBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            chbProductIsAvailable.Click += delegate // property change doesn't fire the Click event
            {
                ProductIsAvailableToggled?.Invoke(this, EventArgs.Empty);
            };

            btnProductRename.Click += delegate
            {
                ProductRenameBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            btnProductSave.Click += delegate
            {
                ProductSaveBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful && !IsEdit)
                {
                    MessageBox.Show(Message, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!IsSuccessful)
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnProductRemove.Click += delegate
            {
                var result = MessageBox.Show(@"Are you sure you want to delete the selected product?", @"Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes) return;

                ProductRemoveBtnClicked?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };

            btnReleaseAdd.Click += delegate
            {
                ReleaseAddBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            btnReleaseRemove.Click += delegate
            {
                var result = MessageBox.Show(@"Are you sure you want to delete the selected release?", @"Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes) return;

                ReleaseRemoveBtnClicked?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };

            btnReleaseSave.Click += delegate
            {
                ReleaseSaveBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful && IsEdit)
                {
                    MessageBox.Show(Message, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!IsSuccessful)
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            
        }

        #endregion


        #region Properties

        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }


        public int CbProductListSelected
        {
            get => cbProductList.SelectedIndex;
            set => cbProductList.SelectedIndex = value;
        }
        public int ProductId { get; set; }
        public new string ProductName
        {
            get => txtProductName.Text;
            set => txtProductName.Text = value;
        }
        public bool ProductIsAvailable
        {
            get => chbProductIsAvailable.Checked;
            set => chbProductIsAvailable.Checked = value;
        }
        public string ProductNewestRelease
        {
            get => lbNewestRelease.Text[20..];
            set => lbNewestRelease.Text = @"The newest release: " + value;
        }
        public string ProductNumberOfLicensesGranted
        {
            get => lbLicensesGranted.Text[28..];
            set => lbLicensesGranted.Text = @"Number of licenses granted: " + value;
        }
        public string ProductActiveClientBaseNumber
        {
            get => lbActiveClientBaseNumber.Text[20..];
            set => lbActiveClientBaseNumber.Text = @"Active client base: " + value;
        }
        public string BtnProductSaveText
        {
            get => btnProductSave.Text;
            set => btnProductSave.Text = value;
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
            get => rtxtReleaseDescription.Text;
            set => rtxtReleaseDescription.Text = value;
        }

        #endregion


        #region Events

        public event EventHandler ProductSelectClicked;
        public event EventHandler ProductAddBtnClicked;
        public event EventHandler ProductIsAvailableToggled;
        public event EventHandler ProductRenameBtnClicked;
        public event EventHandler ProductSaveBtnClicked;
        public event EventHandler ProductRemoveBtnClicked;
        public event EventHandler ReleaseAddBtnClicked;
        public event EventHandler ReleaseRemoveBtnClicked;
        public event EventHandler ReleaseSaveBtnClicked;

        #endregion


        #region Methods

        public void SetProductListBindingSource(BindingSource productList)
        {
            cbProductList.DataSource = productList;
        }

        public void SetReleaseDataBindingSource(BindingSource releaseList)
        {
            dgvReleaseData.DataSource = releaseList;
            dgvReleaseData.ClearSelection();
        }

        public void SetProductViewToSelectable(bool enabled)
        {
            btnProductSelect.Enabled = enabled;
            gbProductSelected.Enabled = enabled;
            btnProductSave.Enabled = !enabled;
        }
        public void SetProductViewToEditable(bool enabled)
        {
            gbProductSelected.Enabled = true;
            cbProductList.Enabled = !enabled;
            btnProductSave.Enabled = enabled;
            btnProductAdd.Enabled = !enabled;
            btnProductSelect.Enabled = !enabled;
            chbProductIsAvailable.Enabled = !enabled;
            btnProductRename.Enabled = !enabled;
            btnProductRemove.Enabled = !enabled;
            txtProductName.ReadOnly = !enabled;
            gbReleaseSelected.Enabled = !enabled;
        }

        #endregion


    }
}
