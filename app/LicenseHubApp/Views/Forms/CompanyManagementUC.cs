using LicenseHubApp.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseHubApp.Views.Forms
{
    public partial class CompanyManagementUC : UserControl, ICompanyManagementView
    {

        #region Constructor
        public CompanyManagementUC()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            ShowOnlyLeftPanel();
            chbSearchOnlyActiveCompanies.Checked = true;
            cbSelectedFilter.Items.Add("Name");
            cbSelectedFilter.Items.Add("Nip");
            cbSelectedFilter.SelectedIndex = 0;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate
            {
                SearchBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            btnShowDetails.Click += delegate
            {
                ShowDetailsBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                    ShowBothPanels(false);
                else
                    MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            btnEdit.Click += delegate
            {
                EditBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowBothPanels(true);
            };
            btnAdd.Click += delegate
            {
                AddBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowOnlyRightPanel(true);
            };

            btnCloseRightPanel.Click += delegate
            {
                CloseRightPanelBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowOnlyLeftPanel();
            };
            btnSave.Click += delegate
            {
                SaveBtnClicked?.Invoke(this, EventArgs.Empty);
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
            btnEditCancel.Click += delegate
            {
                EditCancelBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowOnlyLeftPanel();
            };
            btnToggleIsActive.Click += delegate
            {
                ToggleIsActiveBtnClicked?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                    MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
        #endregion


        #region Properties
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }
        public bool IsEdit { get; set; }

        public string SearchValue
        {
            get => txtSearchValue.Text.Trim();
            set => txtSearchValue.Text = value;
        }
        public string SelectedFilter { get; set; }
        public bool SearchOnlyActiveCompanies { get; set; }


        public int CompanyId { get; set; }
        public string CompanyIsActiveInfo
        {
            get => (lbIsActiveInfo.Text == @"status: Active") ? "true" : "false";
            set => lbIsActiveInfo.Text = (value == "True") ? "status: Active" : "status: Deactivated";
        }

        public new string CompanyName
        {
            get => txtCompanyName.Text;
            set => txtCompanyName.Text = value;
        }
        public string CompanyNip
        {
            get => txtNip.Text;
            set => txtNip.Text = value;
        }
        public string CompanyLocalizations
        {
            get => ParseMultilineToSingleLine(rtxtLocalizations.Text);
            set => rtxtLocalizations.Text = ParseSingleLineToMultiline(value);
        }
        public string CompanyWebsites
        {
            get => ParseMultilineToSingleLine(rtxtWebsites.Text);
            set => rtxtWebsites.Text = ParseSingleLineToMultiline(value);
        }
        public string CompanyDescription
        {
            get => ParseMultilineToSingleLine(rtxtDescription.Text);
            set => rtxtDescription.Text = ParseSingleLineToMultiline(value);
        }

        public string ToggleIsActiveBtnText
        {
            get => btnToggleIsActive.Text;
            set => btnToggleIsActive.Text = value;
        }
        #endregion


        #region Events
        public event EventHandler SearchBtnClicked;
        public event EventHandler ShowDetailsBtnClicked;
        public event EventHandler EditBtnClicked;
        public event EventHandler AddBtnClicked;
        public event EventHandler CloseRightPanelBtnClicked;
        public event EventHandler SaveBtnClicked;
        public event EventHandler EditCancelBtnClicked;
        public event EventHandler ToggleIsActiveBtnClicked;
        #endregion


        #region Methods
        public void SetUserListBindingSource(BindingSource companyList)
        {
            dataGridView1.DataSource = companyList;
            dataGridView1.ClearSelection();
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
            txtNip.ReadOnly = !editable;
            rtxtLocalizations.ReadOnly = !editable;
            rtxtWebsites.ReadOnly = !editable;
            rtxtDescription.ReadOnly = !editable;

            btnSave.Visible = editable;
            btnEditCancel.Visible = editable;
            btnToggleIsActive.Visible = editable;
        }
        #endregion



        // UTILS
        // TODO export utils
        private string ParseSingleLineToMultiline(string singleLineInput)
        {
            var symbol = '#';

            var sb = new StringBuilder(singleLineInput);
            sb.Replace(symbol.ToString(), Environment.NewLine);

            var multilineLineOutput = sb.ToString();
            return multilineLineOutput;
        }
        static string ParseMultilineToSingleLine(string multilineInput)
        {
            var symbol = '#';

            var lines = multilineInput.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var singleLineOutput = string.Join(symbol, lines);
            return singleLineOutput;
        }



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
