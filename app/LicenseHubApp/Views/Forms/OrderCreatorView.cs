using LicenseHubApp.Views.Interfaces;

namespace LicenseHubApp.Views.Forms
{
    public partial class OrderCreatorView : UserControl, IOrderCreatorView
    {
        private string _message;
        private bool _isSuccessful;
        private int _orderId;
        private string _orderCompanySelector;
        private string _orderCompanyName;
        private string _orderCompanyNip;
        private DateTime _dateOfOrder;
        private DateTime _dateOfPayment;
        private string _description;
        private string _productName;
        private string _productRelease;
        private int _productQuantity;
        private string _licenseType;
        private int _licenseLeaseTermInDays;

        public OrderCreatorView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //btnCloseDetailView.Click += delegate
            //{
            //    CloseDetailViewBtnClicked?.Invoke(this, EventArgs.Empty);
            //};
        }


        #region Properties

        public string Message
        {
            get => _message;
            set => _message = value;
        }

        public bool IsSuccessful
        {
            get => _isSuccessful;
            set => _isSuccessful = value;
        }

        public int OrderId
        {
            get => _orderId;
            set => _orderId = value;
        }

        public string OrderCompanySelector
        {
            get => _orderCompanySelector;
            set => _orderCompanySelector = value;
        }

        public string OrderCompanyName
        {
            get => _orderCompanyName;
            set => _orderCompanyName = value;
        }

        public string OrderCompanyNip
        {
            get => _orderCompanyNip;
            set => _orderCompanyNip = value;
        }

        public DateTime DateOfOrder
        {
            get => _dateOfOrder;
            set => _dateOfOrder = value;
        }

        public DateTime DateOfPayment
        {
            get => _dateOfPayment;
            set => _dateOfPayment = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public string ProductRelease
        {
            get => _productRelease;
            set => _productRelease = value;
        }

        public int ProductQuantity
        {
            get => _productQuantity;
            set => _productQuantity = value;
        }

        public string LicenseType
        {
            get => _licenseType;
            set => _licenseType = value;
        }

        public int LicenseLeaseTermInDays
        {
            get => _licenseLeaseTermInDays;
            set => _licenseLeaseTermInDays = value;
        }

        #endregion


        #region Events

        public event EventHandler? OrderCompanyNameSelectorBtnToggled;
        public event EventHandler? OrderCompanyNipSelectorBtnToggled;
        public event EventHandler? ProductAddBtnClicked;
        public event EventHandler? ProductCancelBtnClicked;
        public event EventHandler? ProductRemoveBtnClicked;
        public event EventHandler? LicenseRegisterBtnClicked;
        public event EventHandler? LicenseActivateBtnClicked;
        public event EventHandler? OrderAddBtnClicked;
        public event EventHandler? OrderCancelBtnClicked;

        #endregion


        #region Methods

        public void SetWorkstationProductListBindingSource(BindingSource workstationProductList)
        {
            throw new NotImplementedException();
        }

        public void SetProductToSelectable(bool editable)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
