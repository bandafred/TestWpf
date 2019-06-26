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

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new OrdersViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow orderWindow = new AddOrderWindow();
            orderWindow.ShowDialog();
        }
    }
}
