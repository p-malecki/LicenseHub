using LicenseHubApp.Views.Interfaces;
using System.Windows.Forms;
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
            cbCompanySelectedFilter.Items.Add("name");
            cbCompanySelectedFilter.Items.Add("nip");
            cbCompanySelectedFilter.SelectedIndex = 0;
            
            chbSidePanelSearchOnlyActive.Checked = true;
            cbSidePanelSelectedFilter.Items.Add("name");
            cbSidePanelSelectedFilter.Items.Add("profession");
            cbSidePanelSelectedFilter.Items.Add("phone number");
            cbSidePanelSelectedFilter.Items.Add("email");
            cbSidePanelSelectedFilter.Items.Add("ip");
            
            // TODO add workstation filters to combobox selector
            
            cbSidePanelSelectedFilter.SelectedIndex = 0;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnCloseSidePanel.Click += delegate
            {
                CloseRightPanelBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowOnlyLeftPanel();
            };

            #region CompanyManagement

            btnCompanySearch.Click += delegate
            {
                CompanySearchBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            btnCompanyShowDetails.Click += delegate
            {
                CompanyShowDetailsBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ShowBothPanels(false);
                    ShowOnlyOnePageInTabControl(tabControlSidePanelLeft, tpCompanyDetails);
                }
                else
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnCompanyAdd.Click += delegate
            {
                CompanyAddBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowBothPanels(true);
                ShowOnlyOnePageInTabControl(tabControlSidePanelLeft, tpCompanyDetails);
            };

            btnCompanyEdit.Click += delegate
            {
                CompanyEditBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ShowBothPanels(true);
                    ShowOnlyOnePageInTabControl(tabControlSidePanelLeft, tpCompanyDetails);
                }
                else
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            dgvCompanyData.SelectionChanged += delegate
            {
                CompanyShowDetailsBtnClicked?.Invoke(this, EventArgs.Empty);
                SidePanelShowDetailsBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            btnCompanyShowEmployees.Click += delegate
            {
                CompanyShowEmployeesBtnClicked?.Invoke(this, EventArgs.Empty);
                tpSidePanelData.Text = @"Employees";
                ShowBothPanels(false);
                ShowOnlyOnePageInTabControl(tabControlSidePanelLeft, tpSidePanelData);
                ShowOnlyOnePageInTabControl(tabControlSidePanelRight, tpSidePanelEmployeeDetails);
            };

            #endregion

            #region EmployeeManagement

            btnSidePanelSearch.Click += delegate
            {
                SidePanelSearchBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            btnSidePanelShowDetails.Click += delegate
            {
                SidePanelShowDetailsBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ShowOnlyRightPanel(false);
                }
                else
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnSidePanelAdd.Click += delegate
            {
                SidePanelAddBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowOnlyRightPanel(true);
            };

            btnSidePanelEdit.Click += delegate
            {
                SidePanelEditBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ShowOnlyRightPanel(true);
                }
                else
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnSidePanelSave.Click += delegate
            {
                SidePanelSaveBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    ShowOnlyRightPanel(false);
                    MessageBox.Show(Message);
                }
                else
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };

            btnSidePanelEditCancel.Click += delegate
            {
                SidePanelEditCancelBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowBothPanels(false);
            };

            btnSidePanelToggleIsActive.Click += delegate
            {
                SidePanelToggleIsActiveBtnClicked?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            dgvSidePanelData.SelectionChanged += delegate
            {
                SidePanelShowDetailsBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            #endregion

            #region WorkstationManagement

            // TODO WorkstationManagement

            #endregion
        }
        #endregion


        #region Properties
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }
        public bool IsEdit { get; set; }
        public string SidePanelTarget { get; set; }


        public string CompanySearchValue
        {
            get => txtCompanySearchValue.Text.Trim();
            set => txtCompanySearchValue.Text = value;
        }
        public string CompanySelectedFilter { get; set; }
        public bool CompanySearchOnlyActive
        {
            get => chbCompanySearchOnlyActive.Checked;
            set => chbCompanySearchOnlyActive.Checked = value;
        }

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


        public string SidePanelSearchValue
        {
            get => txtSidePanelSearchValue.Text.Trim();
            set => txtSidePanelSearchValue.Text = value;
        }
        public string SidePanelSelectedFilter { get; set; }
        public bool SidePanelSearchOnlyActive
        {
            get => chbSidePanelSearchOnlyActive.Checked;
            set => chbSidePanelSearchOnlyActive.Checked = value;
        }
        public string SidePanelToggleIsActiveBtnText
        {
            get => btnSidePanelToggleIsActive.Text;
            set => btnSidePanelToggleIsActive.Text = value;
        }


        public int EmployeeId { get; set; }
        public string EmployeeIsActiveInfo
        {
            get => (lbEmployeeIsActiveInfo.Text == @"status: Active") ? "true" : "false";
            set => lbEmployeeIsActiveInfo.Text = (value == "true") ? "status: Active" : "status: Deactivated";
        }
        public new string EmployeeName
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
        public event EventHandler CompanyShowEmployeesBtnClicked;

        public event EventHandler SidePanelSearchBtnClicked;
        public event EventHandler SidePanelShowDetailsBtnClicked;
        public event EventHandler SidePanelAddBtnClicked;
        public event EventHandler SidePanelEditBtnClicked;
        public event EventHandler SidePanelSaveBtnClicked;
        public event EventHandler SidePanelEditCancelBtnClicked;
        public event EventHandler SidePanelToggleIsActiveBtnClicked;
        #endregion


        #region Methods
        public void SetCompanyListBindingSource(BindingSource companyList)
        {
            dgvCompanyData.DataSource = companyList;
            dgvCompanyData.ClearSelection();
        }
        public void SetSidePanelListBindingSource(BindingSource modelList)
        {
            dgvSidePanelData.DataSource = modelList;
            dgvSidePanelData.ClearSelection();
        }

        public void SetCompanyEditBtnToEnabled(bool enabled)
        {
            btnCompanyEdit.Enabled = enabled;
        }
        public void SetSidePanelEditBtnToEnabled(bool enabled)
        {
            btnSidePanelEdit.Enabled = enabled;
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
            switch (SidePanelTarget)
            {
                case "Employee":
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

                    btnSidePanelSave.Visible = editable;
                    btnSidePanelEditCancel.Visible = editable;
                    btnSidePanelToggleIsActive.Visible = editable && IsEdit;

                    btnSidePanelSave.Text = IsEdit ? "Save changes" : "Add employee";
                    break;
                }
                case "Workstation":
                {
                    // TODO add SetPanelToEditable for Workstation
                    break;
                }
                default: 
                {
                    txtCompanyName.ReadOnly = !editable;
                    txtCompanyNip.ReadOnly = !editable;
                    rtxtCompanyLocalizations.ReadOnly = !editable;
                    rtxtCompanyWebsites.ReadOnly = !editable;
                    rtxtCompanyDescription.ReadOnly = !editable;

                    rtxtCompanyLocalizations.BackColor = editable ? Color.White : SystemColors.Control;
                    rtxtCompanyWebsites.BackColor = editable ? Color.White : SystemColors.Control;
                    rtxtCompanyDescription.BackColor = editable ? Color.White : SystemColors.Control;

                    btnCompanySave.Visible = editable;
                    btnCompanyEditCancel.Visible = editable;
                    btnCompanyToggleIsActive.Visible = editable && IsEdit;

                    btnCompanySave.Text = IsEdit ? "Save changes" : "Add company";
                break;
                }
            }
        }

        private static void ShowOnlyOnePageInTabControl(TabControl tbControl, TabPage pageToShow)
        {
            foreach (var tabPage in tbControl.TabPages)
            {
                tbControl.TabPages.Remove((TabPage)tabPage);
            }

            tbControl.TabPages.Add(pageToShow);
        }

        #endregion


        #region DEBUG_METHODS
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

        #endregion
    }
}
