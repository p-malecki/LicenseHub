using LicenseHubApp.Views.Interfaces;
using static LicenseHubApp.Utils.ListStoredInStringParser;

namespace LicenseHubApp.Views.Forms
{
    public partial class ClientManagementUC : UserControl, ICompanyManagementView
    {

        #region Constructor
        public ClientManagementUC()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            ShowOnlyLeftPanel();
            chbCompanySearchOnlyActive.Checked = true;
            cbCompanySelectedFilter.Items.Add("Name");
            cbCompanySelectedFilter.Items.Add("Nip");
            cbCompanySelectedFilter.SelectedIndex = 0;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnCloseRightPanel.Click += delegate
            {
                CloseRightPanelBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowOnlyLeftPanel();
            };


            btnCompanySearch.Click += delegate
            {
                CompanySearchBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            btnCompanyShowDetails.Click += delegate
            {
                CompanyShowDetailsBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                    ShowBothPanels(false);
                else
                    MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            btnCompanyEditDetails.Click += delegate
            {
                CompanyEditBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowBothPanels(true);
            };

            btnCompanyAdd.Click += delegate
            {
                CompanyAddBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowBothPanels(true);
            };

            btnCompanySave.Click += delegate
            {
                CompanySaveBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ShowBothPanels(false);
                    MessageBox.Show(Message);
                }
                else
                {
                    MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };

            btnCompanyEditCancel.Click += delegate
            {
                CompanyEditCancelBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowBothPanels(false);
            };

            btnCompanyToggleIsActive.Click += delegate
            {
                CompanyToggleIsActiveBtnClicked?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                    MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            dgvCompanyData.SelectionChanged += delegate
            {
                CompanyShowDetailsBtnClicked?.Invoke(this, EventArgs.Empty);
            };


        }
        #endregion


        #region Properties
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }
        
        
        public bool CompanyIsEdit { get; set; }
        public int CompanyId { get; set; }
        public string CompanyIsActiveInfo
        {
            get => (lbCompanyIsActiveInfo.Text == @"status: Active") ? "true" : "false";
            set => lbCompanyIsActiveInfo.Text = (value == "true") ? "status: Active" : "status: Deactivated";
        }
        public new string CompanyName
        {
            get => txtCompanyName.Text;
            set => txtCompanyName.Text = value;
        }
        public string CompanyNip
        {
            get => txtCompanyNip.Text;
            set => txtCompanyNip.Text = value;
        }
        public string CompanyLocalizations
        {
            get => ParseMultilineToSingleLine(rtxtCompanyLocalizations.Text);
            set => rtxtCompanyLocalizations.Text = ParseSingleLineToMultiline(value);
        }
        public string CompanyWebsites
        {
            get => ParseMultilineToSingleLine(rtxtCompanyWebsites.Text);
            set => rtxtCompanyWebsites.Text = ParseSingleLineToMultiline(value);
        }
        public string CompanyDescription
        {
            get => ParseMultilineToSingleLine(rtxtCompanyDescription.Text);
            set => rtxtCompanyDescription.Text = ParseSingleLineToMultiline(value);
        }
        public string CompanyToggleIsActiveBtnText
        {
            get => btnCompanyToggleIsActive.Text;
            set => btnCompanyToggleIsActive.Text = value;
        }
        public string CompanySearchValue
        {
            get => txtCompanySearchValue.Text.Trim();
            set => txtCompanySearchValue.Text = value;
        }
        public string CompanySelectedFilter { get; set; }
        public bool CompanySearchOnlyActive { get; set; }




        #endregion


        #region Events
        public event EventHandler CloseRightPanelBtnClicked;
        public event EventHandler CompanySearchBtnClicked;
        public event EventHandler CompanyShowDetailsBtnClicked;
        public event EventHandler CompanyEditBtnClicked;
        public event EventHandler CompanyAddBtnClicked;
        public event EventHandler CompanySaveBtnClicked;
        public event EventHandler CompanyEditCancelBtnClicked;
        public event EventHandler CompanyToggleIsActiveBtnClicked;
        #endregion


        #region Methods
        public void SetCompanyListBindingSource(BindingSource companyList)
        {
            dgvCompanyData.DataSource = companyList;
            dgvCompanyData.ClearSelection();
        }

        private void ShowOnlyLeftPanel()
        {
            splitContainer1.SplitterDistance = this.Size.Width;
        }

        private void ShowOnlyRightPanel(bool editable)
        {
            splitContainer1.SplitterDistance = 0;

            SetPanelToEditable(editable);
        }

        private void ShowBothPanels(bool editable)
        {
            splitContainer1.SplitterDistance = 54 * this.Size.Width / 100;

            SetPanelToEditable(editable);
        }
        private void SetPanelToEditable(bool editable)
        {
            txtCompanyName.ReadOnly = !editable;
            txtCompanyNip.ReadOnly = !editable;
            rtxtCompanyLocalizations.ReadOnly = !editable;
            rtxtCompanyWebsites.ReadOnly = !editable;
            rtxtCompanyDescription.ReadOnly = !editable;

            rtxtCompanyLocalizations.BackColor = editable ? Color.White: SystemColors.Control;
            rtxtCompanyWebsites.BackColor = editable ? Color.White : SystemColors.Control;
            rtxtCompanyDescription.BackColor = editable ? Color.White : SystemColors.Control;

            btnCompanySave.Visible = editable;
            btnCompanyEditCancel.Visible = editable;
            btnCompanyToggleIsActive.Visible = editable && CompanyIsEdit;

            btnCompanySave.Text = CompanyIsEdit ? "Save changes" : "Add company";
        }
        #endregion


        // DEBUG
        private void button1_Click(object sender, EventArgs e)
        {
            ShowOnlyRightPanel(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowOnlyLeftPanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowBothPanels(true);
        }
    }
}
