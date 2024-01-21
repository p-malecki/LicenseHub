using LicenseHubApp.Models;
using LicenseHubApp.Models.Filters;
using LicenseHubApp.Services.Managers;
using LicenseHubApp.Utils;
using LicenseHubApp.Views.Interfaces;


namespace LicenseHubApp.Presenters
{
    public class OrderDetailPresenter
    {
        private readonly IOrderDetailView _view;
        private readonly OrderModel _order;
        private readonly OrderManager _orderManager;
        private readonly BindingSource _workstationProductBindingSource;
        private readonly EventHandler<GoToDetailViewEventArgs>? _goToWorkstationProductDetailViewChanged;
        private readonly EventHandler _closeDetailViewClicked;

        public OrderDetailPresenter(
            IOrderDetailView view,
            OrderModel order,
            OrderManager orderManager,
            EventHandler<GoToDetailViewEventArgs>? goToWorkstationProductDetailViewChanged,
            EventHandler CloseDetailViewClicked
            )
        {
            _view = view;
            _order = order;
            _orderManager = orderManager;
            _goToWorkstationProductDetailViewChanged = goToWorkstationProductDetailViewChanged;

            ShowModel();
            _view.SetViewToEditable(false);

            _workstationProductBindingSource = [];
            view.SetWorkstationProductListBindingSource(_workstationProductBindingSource);
            LoadAllWorkstationList();

            _view.EditBtnClicked += OnEditBtnClicked;
            _view.EditCancelBtnClicked += OnEditCancelBtnClicked;
            _view.SaveBtnClicked += OnSaveBtnClicked;
            _view.GoToWorkstationProductBtnClicked += delegate
            {
                var workstationProduct = GetSelectedWorkstationProduct();
                if (workstationProduct != null)
                {
                    _goToWorkstationProductDetailViewChanged?.Invoke(this,
                        new GoToDetailViewEventArgs() { WorkstationProduct = workstationProduct });
                }
            };
            _view.CloseDetailViewBtnClicked += delegate
            {
                _closeDetailViewClicked.Invoke(this, EventArgs.Empty);
            };
        }

        private void ShowModel()
        {
            _view.OrderCompanyName = _order.Company.Name;
            _view.OrderCompanyNip = _order.Company.Nip;
            _view.OrderId = _order.Id;
            _view.DateOfOrder = _order.DateOfOrder;
            _view.DateOfPayment = _order.DateOfPayment;
            _view.Description = _order.Description;

            _view.IsSuccessful = true;
        }

        private void LoadAllWorkstationList()
        {
            var results = _order.WorkstationProducts;

            if (results.Count > 0)
            {
                _workstationProductBindingSource.DataSource = results;
                _view.IsGoToWorkstationProductEnabled = true;
            }
            else
            {
                _workstationProductBindingSource.DataSource = new List<WorkstationProductModel>();
                _view.IsGoToWorkstationProductEnabled = false;
            }
        }

        private WorkstationProductModel? GetSelectedWorkstationProduct()
        {
            if (_workstationProductBindingSource.Count == 0)
                return null;
            return (WorkstationProductModel)_workstationProductBindingSource.Current;
        }

        private void OnEditBtnClicked(object? sender, EventArgs e)
        {
            _view.SetViewToEditable(true);
        }

        private void OnEditCancelBtnClicked(object? sender, EventArgs e)
        {
            _view.SetViewToEditable(false);
        }

        private void OnSaveBtnClicked(object? sender, EventArgs e)
        {
            try
            {
                var model = new OrderModel()
                {
                    Id = _view.OrderId,
                    DateOfOrder = _view.DateOfOrder,
                    DateOfPayment = _view.DateOfPayment,
                    Description = _view.Description,
                };

                _orderManager.Save(model);
                _view.Message = "Order details have been saved.";
                _view.SetViewToEditable(false);
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                ShowModel();
                _view.SetViewToEditable(false);
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

    }
}
