using System.Windows;
using ViewModel;

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        /// <summary>
        /// Заполнение таблицы данными.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new OrdersViewModel();
        }

        /// <summary>
        /// Вывод модального окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow orderWindow = new AddOrderWindow();
            orderWindow.ShowDialog();
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
            if (selectedIndex < countItems-1)
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

        private void Window_Activated(object sender, System.EventArgs e)
        {
            MainWindow_Loaded(sender, null);
        }
    }
}
