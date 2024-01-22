using LicenseHubApp.Models;
using LicenseHubApp.Repositories;
using LicenseHubApp.Views.Interfaces;


namespace LicenseHubApp.Presenters
{
    public class UserManagementPresenter
    {
        private readonly IUserManagementView _view;
        private readonly IUserRepository _repository;
        private readonly BindingSource _userBindingSource;


        public UserManagementPresenter(IUserManagementView view, IUserRepository repository)
        {
            _view = view;
            _repository = repository;
            _userBindingSource = [];
            view.SetUserListBindingSource(_userBindingSource);

            _view.AddBtnClicked += OnAddBtnClicked;
            _view.EditBtnClicked += OnEditBtnClicked;
            _view.DeleteBtnClicked += OnDeleteBtnClicked;
            _view.SaveBtnClicked += OnSaveBtnClicked;
            _view.CancelBtnClicked += OnCancelBtnClicked; 

            LoadAllList();
        }


        private void LoadAllList()
        {
            _userBindingSource.DataSource = _repository.GetAll();
        }
        private void OnAddBtnClicked(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void OnEditBtnClicked(object sender, EventArgs e)
        {
            var model = (UserModel)_userBindingSource.Current;
            _view.Id = model.Id;
            _view.Username = model.Username;
            _view.IsAdmin = model.IsAdmin;
            _view.IsEdit = true;
        }
        private void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            try
            {
                var model = (UserModel)_userBindingSource.Current;
                _repository.Delete(model.Id);
                _view.IsSuccessful = true;
                _view.Message = "You’ve deleted user.";
                LoadAllList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private async void OnSaveBtnClicked(object sender, EventArgs e)
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
                    var modelBeforeChange = await _repository.GetById(_view.Id);

                    if (!_repository.IsUsernameUnique(_view.Id, _view.Username))
                        throw new InvalidOperationException($"User with Username {_view.Username} already exists.");

                    if (!_repository.IsAdminChangeValid(modelBeforeChange.IsAdmin, _view.IsAdmin))
                        throw new InvalidOperationException($"Unable to remove the last admin privileges.");

                    model.Id = _view.Id;
                    if (_view.Password.Length == 0)
                        model.Password = modelBeforeChange.Password;

                    await _repository.Update(model.Id, model);
                    _view.Message = "User details have been saved.";
                }
                else
                {
                    await _repository.Create(model);
                    _view.Message = "User has been added.";
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
