using LicenseHubApp.Views.Interfaces;
using System.Windows.Forms;
using static LicenseHubApp.Utils.ListStoredInStringParser;

namespace LicenseHubApp.Views.Forms
{
    public partial class ClientManagementUC : UserControl, IClientManagementView
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

            chbCompanySearchOnlyActive.CheckedChanged += delegate
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
                lbSidePanelLeftTabTitle.Text = @"Employees";
                tpSidePanelData.Text = @"Employees";

                chbSidePanelSearchOnlyActive.Text = @"Only Active";
                ShowBothPanels(false);
                ShowOnlyOnePageInTabControl(tabControlSidePanelLeft, tpSidePanelData);
                ShowOnlyOnePageInTabControl(tabControlSidePanelRight, tpSidePanelEmployeeDetails);

                // filters 
                chbSidePanelSearchOnlyActive.Checked = true;
                cbSidePanelSelectedFilter.Items.Clear();
                cbSidePanelSelectedFilter.Items.Add("name");
                cbSidePanelSelectedFilter.Items.Add("profession");
                cbSidePanelSelectedFilter.Items.Add("phone number");
                cbSidePanelSelectedFilter.Items.Add("email");
                cbSidePanelSelectedFilter.Items.Add("ip");
                cbSidePanelSelectedFilter.SelectedIndex = 0;
            };

            btnCompanyShowWorkstations.Click += delegate
            {
                CompanyShowWorkstationsBtnClicked?.Invoke(this, EventArgs.Empty);
                lbSidePanelLeftTabTitle.Text = @"Workstations";
                tpSidePanelData.Text = @"Workstations";

                chbSidePanelSearchOnlyActive.Text = @"No faulty";
                ShowBothPanels(false);
                ShowOnlyOnePageInTabControl(tabControlSidePanelLeft, tpSidePanelData);
                ShowOnlyOnePageInTabControl(tabControlSidePanelRight, tpSidePanelWorkstationDetails);

                // filters 
                chbSidePanelSearchOnlyActive.Checked = true;
                cbSidePanelSelectedFilter.Items.Clear();
                cbSidePanelSelectedFilter.Items.Add("computer name");
                cbSidePanelSelectedFilter.Items.Add("username");
                cbSidePanelSelectedFilter.Items.Add("hard disk");
                cbSidePanelSelectedFilter.Items.Add("cpu");
                cbSidePanelSelectedFilter.Items.Add("bios version");
                cbSidePanelSelectedFilter.Items.Add("os");
                cbSidePanelSelectedFilter.Items.Add("os bit version");
                cbSidePanelSelectedFilter.SelectedIndex = 0;
            };

            #endregion

            #region SidePaneManagement

            btnSidePanelSearch.Click += delegate
            {
                SidePanelSearchBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            chbSidePanelSearchOnlyActive.CheckedChanged += delegate
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

        public string CompanySelectedFilter
        {
            get => cbCompanySelectedFilter.Text;
            set => cbCompanySelectedFilter.Text = value;
        }
        public bool CompanySearchOnlyActive
        {
            get => chbCompanySearchOnlyActive.Checked;
            set => chbCompanySearchOnlyActive.Checked = value;
        }

        public int CompanyId { get; set; }
        public string CompanyIsActiveInfo
        {
            get => (lbCompanyIsActiveInfo.Text == @"status: Active") ? "True" : "False";
            set => lbCompanyIsActiveInfo.Text = (value == "True") ? "status: Active" : "status: Deactivated";
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

        public string SidePanelSelectedFilter
        {
            get => cbSidePanelSelectedFilter.Text;
            set => cbSidePanelSelectedFilter.Text = value;
        }
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
            get => (lbEmployeeIsActiveInfo.Text == @"status: Active") ? "True" : "False";
            set => lbEmployeeIsActiveInfo.Text = (value == "True") ? "status: Active" : "status: Deactivated";
        }
        public string EmployeeName
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


        public int WorkstationId { get; set; }
        public string WorkstationHasFaultInfo
        {
            get => (lbEmployeeIsActiveInfo.Text == @"status: Has fault") ? "True" : "False";
            set => lbEmployeeIsActiveInfo.Text = (value == "True") ? "status: Has fault" : "status: No fault";
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
        public event EventHandler CompanyShowWorkstationsBtnClicked;

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

        public void SetSpecifiedCompanyBtnsToEnabled(bool enabled)
        {
            btnCompanyShowDetails.Enabled = enabled;
            btnCompanyEdit.Enabled = enabled;
            btnCompanyShowEmployees.Enabled = enabled;
            btnCompanyShowWorkstations.Enabled = enabled;
        }
        public void SetSpecifiedSidePanelBtnsToEnabled(bool enabled)
        {
            btnSidePanelShowDetails.Enabled = enabled;
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
        public void SetPanelToEditable(bool editable)
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

                    btnSidePanelSave.Visible = editable;
                    btnSidePanelEditCancel.Visible = editable;
                    btnSidePanelToggleIsActive.Visible = editable && IsEdit;

                    btnSidePanelSave.Text = IsEdit ? "Save changes" : "Add workstation";
                    break;
                }
                default: // Company
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
