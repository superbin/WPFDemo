using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDemos
{
    /// <summary>
    /// Interaction logic for LogicalResource.xaml
    /// </summary>
    public partial class LogicalResource : Window
    {
        public LogicalResource()
        {
            InitializeComponent();
        }

        private void RedRadio_Checked(object sender, RoutedEventArgs e)
        {
            var brush = Resources["myLinearBrush2"];
            if (brush is LinearGradientBrush lBrush)
            {
                lBrush = new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop(Colors.LightGoldenrodYellow, 0),
                        new GradientStop(Colors.Red, 1)
                    }
                };
                Resources["myLinearBrush2"] = lBrush;
            }
        }

        private void GreenRadio_Checked(object sender, RoutedEventArgs e)
        {
            var brush = Resources["myLinearBrush2"];
            if (brush is LinearGradientBrush lBrush)
            {
                lBrush = new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop(Colors.LightYellow, 0),
                        new GradientStop(Colors.Green, 1)
                    }
                };
                Resources["myLinearBrush2"] = lBrush;
            }
        }

        private void BlueRadio_Checked(object sender, RoutedEventArgs e)
        {
            var brush = Resources["myLinearBrush2"];
            if (brush is LinearGradientBrush lBrush)
            {
                lBrush = new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop(Colors.LightBlue, 0),
                        new GradientStop(Colors.Blue, 1)
                    }
                };
                Resources["myLinearBrush2"] = lBrush;
            }
        }
    }
}
