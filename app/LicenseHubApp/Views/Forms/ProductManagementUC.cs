using LicenseHubApp.Views.Interfaces;

namespace LicenseHubApp.Views.Forms
{
    public partial class ProductManagementUC : UserControl, IProductManagementView
    {

        #region Constructor
        public ProductManagementUC()
        {
            InitializeComponent();
        }

        private void AssociateAndRaiseViewEvents()
        {

        }

        #endregion


        #region Properties


        #endregion


        #region Events


        #endregion


        #region Methods
        public void SetBindingSource(BindingSource productList)
        {
            dgvProductsData.DataSource = productList;
            dgvProductsData.ClearSelection();
        }

        #endregion


    }
}
