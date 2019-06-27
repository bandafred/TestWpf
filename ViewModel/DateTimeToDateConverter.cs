using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ViewModel
{
    /// <summary>
    /// Конвертер даты в вид типа "dd.MM.yyyy".
    /// </summary>
    public class DateTimeToDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value).ToString("dd.MM.yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
