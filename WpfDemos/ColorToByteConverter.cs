using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfDemos
{
    public class ColorToByteConverter : IValueConverter
    {
        Color oldColor;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color color && parameter is string param)
            {
                oldColor = color;
                switch (param)
                {
                    case "r":
                        return color.R;
                    case "g":
                        return color.G;
                    case "b":
                        return color.B;
                    default:
                        return color.A;
                }                
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = oldColor;
            var colorValue = System.Convert.ToByte(value);
            if (parameter is string param)
            {
                switch (param)
                {
                    case "r":
                        color.R = (byte)colorValue;
                        break;
                    case "g":
                        color.G = (byte)colorValue;
                        break;
                    case "b":
                        color.B = (byte)colorValue;
                        break;
                    default:
                        color.A = (byte)colorValue;
                        break;
                }
            }
            oldColor = color;
            return color;
        }
    }
}
