﻿using LicenseHubApp.Views.Interfaces;

namespace LicenseHubApp.Views.Forms
{
    public partial class MainForm : Form, IMainView
    {
        #region Constructor

        private static MainForm? _instance;

        private MainForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        public static MainForm GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new MainForm();
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }

            parentContainer.Hide();
            _instance.Closed += (s, args) => parentContainer.Close();

            _instance.Show();
            return _instance;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnDashboard.Click += delegate
            {
                //DashboardBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowOnlyOnePageInTabControl(mainTabControl, tpDashboard);
            };

            btnClients.Click += delegate
            {
                ClientsBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowOnlyOnePageInTabControl(mainTabControl, tpClients);
            };

            btnProducts.Click += delegate
            {
                ProductsBtnClicked?.Invoke(this, EventArgs.Empty);
                ShowOnlyOnePageInTabControl(mainTabControl, tpProducts);
            };


            btnSettings.Click += delegate
            {
                SettingsBtnClicked?.Invoke(this, EventArgs.Empty);
            };
            btnLogout.Click += delegate
            {
                LogoutBtnClicked?.Invoke(this, EventArgs.Empty);
            };
        }
        #endregion


        #region Properties
        public string LoggedInUser
        {
            get => lbLoggedInUser.Text[6..];
            set => lbLoggedInUser.Text = "User: " + value;
        }

        public Control.ControlCollection ClientTabPageCollection => tpClients.Controls;
        public Control.ControlCollection ProductTabPageCollection => tpProducts.Controls;

        #endregion


        #region Events
        public event EventHandler DashboardBtnClicked;
        public event EventHandler ClientsBtnClicked;
        public event EventHandler OrdersBtnClicked;
        public event EventHandler ProductsBtnClicked;
        public event EventHandler LicencesBtnClicked;
        public event EventHandler ReportsBtnClicked;
        public event EventHandler SettingsBtnClicked;
        public event EventHandler LogoutBtnClicked;

        #endregion



        #region Methods

        private static void ShowOnlyOnePageInTabControl(TabControl tbControl, TabPage pageToShow)
        {
            // TODO TabOperations extract method
            foreach (var tabPage in tbControl.TabPages)
            {
                tbControl.TabPages.Remove((TabPage)tabPage);
            }

            tbControl.TabPages.Add(pageToShow);
        }

        #endregion

    }
}
