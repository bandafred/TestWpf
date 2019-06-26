using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace ViewModel
{
    public class OrdersViewModel : DependencyObject
    {
        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(OrdersViewModel), new PropertyMetadata(null));

        public OrdersViewModel()
        {
            var ordersModel = new GetOrders().GetAllOrders;

            Items = CollectionViewSource.GetDefaultView(ordersModel);
        }
    }
}
