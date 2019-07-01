using System.Windows;
using System.Windows.Controls;
using ViewModel;

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Расчет суммы выбранных заказов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_SelectedCellsChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selectedIndex = dgOrders.SelectedIndex;
            var countItems = dgOrders.Items.Count;
            if (selectedIndex < countItems - 1)
            {
                var list = dgOrders.SelectedItems;
                double summ = 0;
                foreach (OrdersModel item in list)
                {
                    summ += item.Summ;
                }

                tbSumm.Text = $"Итого: {summ} руб.";
            }
        }
    }
}
