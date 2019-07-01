using System;
using System.Windows;
using System.Windows.Input;
using ViewModel;

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderView : Window
    {
        public AddOrderView()
        {
            InitializeComponent();
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
    }
}
