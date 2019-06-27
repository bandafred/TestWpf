using System;
using System.Windows;
using System.Windows.Input;
using ViewModel;

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        public AddOrderWindow()
        {
            InitializeComponent();
            cbSelectedNameGoods.ItemsSource = new GetAllNamesGoods().GetAllNames;
            dtpDateOrder.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// Закрытие модального окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Запрет ввода не цифровых данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbCountGoods_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Сохранение нового заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var date = dtpDateOrder.DisplayDate;
            var nameGoods = cbSelectedNameGoods.SelectedItem.ToString();
            int count = 0;
            try
            {
                count = Convert.ToInt32(tbCountGoods.Text);
            }
            catch (Exception exception)
            {
                throw new Exception($"{tbCountGoods.Text} не является числом!");
            }

            new SaveOrder(date, nameGoods, count);

            this.Close();
        }
    }
}
