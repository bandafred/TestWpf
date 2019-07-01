using JetBrains.Annotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ViewModel;
using WpfTest.Infrastructure.Helper;

namespace WpfTest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _text;
        private List<OrdersModel> _selectedItems;
        private List<OrdersModel> _ordersModel;

        public MainViewModel()
        {
            OpenAddOrderViewCommand = new Command(o => OpenAddOrderViewCommandExecute());
            ItemsOrder = new GetOrders().GetAllOrders;
        }

        public void OpenAddOrderViewCommandExecute()
        {
            var v = new AddOrderView();
            v.ShowDialog();
        }


        public List<OrdersModel> ItemsOrder
        {
            get => _ordersModel;
            set
            {
                _ordersModel = value;
                OnPropertyChanged();
            }
        }

        public List<OrdersModel> SelectedItems
        {
            get => _selectedItems;
            set
            {
                _selectedItems = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(SelectedItemsSumm));

            }
        }

        public double? SelectedItemsSumm => SelectedItems?.Sum(model => model.Summ);

        public ICommand OpenAddOrderViewCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
