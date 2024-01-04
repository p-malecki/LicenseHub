﻿using LicenseHubApp.Models.Managers;
using LicenseHubApp.Models;
using LicenseHubApp.Views.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LicenseHubApp.Views.Forms
{
    public partial class MainForm : Form, IMainView
    {
        private static MainForm? _instance;


        // Constructor
        private MainForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnClients.Click += delegate
            {
                //ClientsBtnClicked?.Invoke(this, EventArgs.Empty);

                foreach (var tabPage in tabControl1.TabPages)
                {
                    tabControl1.TabPages.Remove((TabPage)tabPage);
                }

                tabControl1.TabPages.Add(tabPageClients);
            };



            btnLogout.Click += delegate
            {
                LogoutBtnClicked?.Invoke(this, EventArgs.Empty);
            };
        }


        // Properties
        public string LoggedInUser
        {
            get => lbLoggedInUser.Text;
            set => lbLoggedInUser.Text = value;
        }


        // Events
        public event EventHandler DashboardBtnClicked;
        public event EventHandler ClientsBtnClicked;
        public event EventHandler OrdersBtnClicked;
        public event EventHandler ProductsBtnClicked;
        public event EventHandler LicencesBtnClicked;
        public event EventHandler ReportsBtnClicked;
        public event EventHandler SettingsBtnClicked;
        public event EventHandler LogoutBtnClicked;


        // Singleton
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
    }
}