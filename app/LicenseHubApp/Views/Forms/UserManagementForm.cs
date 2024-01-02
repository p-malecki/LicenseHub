﻿using LicenseHubApp.Views.Interfaces;
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
    public partial class UserManagementForm : Form, IUserManagementView
    {
        // Constructor
        public UserManagementForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageUserDetails);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnAdd.Click += delegate
            {
                AddBtnClicked?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageUserList);
                tabControl1.TabPages.Add(tabPageUserDetails);
                tabPageUserDetails.Text = "Add new user";
            };

            btnEdit.Click += delegate
            {
                EditBtnClicked?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageUserList);
                tabControl1.TabPages.Add(tabPageUserDetails);
                tabPageUserDetails.Text = "Edit selected user";
            };

            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected user?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteBtnClicked?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnSave.Click += delegate
            {
                SaveBtnClicked?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageUserDetails);
                    tabControl1.TabPages.Add(tabPageUserList);
                }
                MessageBox.Show(Message);
            };

            btnCancel.Click += delegate
            {
                CancelBtnClicked?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageUserDetails);
                tabControl1.TabPages.Add(tabPageUserList);
            };

        }


        // Properties
        public int Id
        {
            get => int.Parse(txtId.Text);
            set => txtId.Text = value.ToString();
        }
        public string Username
        {
            get => txtUsername.Text;
            set => txtUsername.Text = value;
        }
        public string Password
        {
            get => txtNewPassword.Text;
            set => txtNewPassword.Text = value;
        }
        public bool IsAdmin
        {
            get => cbIsAdmin.Checked;
            set => cbIsAdmin.Checked = value;
        }

        public bool IsEdit { get; set; }

        public bool IsSuccessful { get; set; }

        public string Message { get; set; }


        // Events
        public event EventHandler AddBtnClicked;
        public event EventHandler EditBtnClicked;
        public event EventHandler DeleteBtnClicked;
        public event EventHandler SaveBtnClicked;
        public event EventHandler CancelBtnClicked;


        // Methods
        public void SetUserListBindingSource(BindingSource userList)
        {
            dataGridView1.DataSource = userList;
            dataGridView1.ClearSelection();
        }

    }
}