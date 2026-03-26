using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace HRManagementSystem.Controls.Converters;
public class NullToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        // Returns Collapsed if null, Visible otherwise
        return value == null ? Visibility.Collapsed : Visibility.Visible;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}