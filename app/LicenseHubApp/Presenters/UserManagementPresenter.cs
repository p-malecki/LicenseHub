using LicenseHubApp.Models;
using LicenseHubApp.Views.Interfaces;
using LicenseHubApp.Models.Managers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata;


namespace LicenseHubApp.Presenters
{
    internal class UserManagementPresenter
    {
        private IUserManagementView _view;
        private UserManager _manager;
        private BindingSource usersBindingSource;


        public UserManagementPresenter(IUserManagementView view, UserManager manager)
        {
            _view = view;
            _manager = manager;
            usersBindingSource = new BindingSource();
            view.SetUserListBindingSource(usersBindingSource);

            _view.AddBtnClicked += OnAddBtnClicked;
            _view.EditBtnClicked += OnEditBtnClicked;
            _view.DeleteBtnClicked += OnDeleteBtnClicked;
            _view.SaveBtnClicked += OnSaveBtnClicked;
            _view.CancelBtnClicked += OnCancelBtnClicked; 

            LoadAllList();
        }


        private void LoadAllList()
        {
            usersBindingSource.DataSource = _manager.GetAll();
        }
        private void OnAddBtnClicked(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void OnEditBtnClicked(object sender, EventArgs e)
        {
            var model = (UserModel)usersBindingSource.Current;
            _view.Id = model.Id;
            _view.Username = model.Username;
            _view.IsAdmin = model.IsAdmin;
            _view.IsEdit = true;
        }
        private void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var model = (UserModel)usersBindingSource.Current;
                _manager.Delete(model);
                _view.IsSuccessful = true;
                _view.Message = "User deleted successfully";
                LoadAllList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void OnSaveBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var model = new UserModel
                {
                    Username = _view.Username,
                    Password = _view.Password,
                    IsAdmin = _view.IsAdmin
                };

                if (_view.IsEdit)
                {
                    var modelBeforeChange = _manager.GetModelById(_view.Id);
                    _manager.ValidateUsername(modelBeforeChange, _view.Username);
                    _manager.ValidateAdminChange(modelBeforeChange, _view.IsAdmin);

                    model.Id = modelBeforeChange.Id;
                    if (_view.Password.Length == 0)
                        model.Password = modelBeforeChange.Password;

                    _manager.Save(model);

                    _view.Message = "User edited successfuly";
                }
                else
                {
                    _manager.Add(model);
                    _view.Message = "User added sucessfully";
                }
                _view.IsSuccessful = true;
                LoadAllList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }
        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            _view.Id = 0;
            _view.Username = "";
            _view.Password = "";
            _view.IsAdmin = false;
        }
    }
}
