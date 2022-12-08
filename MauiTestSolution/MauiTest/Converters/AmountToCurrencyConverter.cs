using System.Globalization;

namespace MauiTest.Converters
{
    public class AmountToCurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Label)parameter).Text.Equals("True") ? $"+ {(decimal)value:C}" : $"- {(decimal)value:C}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
