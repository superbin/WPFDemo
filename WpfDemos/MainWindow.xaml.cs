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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonProgressBar_Click(object sender, RoutedEventArgs e)
        {
            var window = new ProgressBar();
            window.Show();
        }

        private void ButtonSlider_Click(object sender, RoutedEventArgs e)
        {
            var window = new Slider();
            window.Show();
        }

        private void ButtonCalendar_Click(object sender, RoutedEventArgs e)
        {
            var window = new Calendar();
            window.Show();
        }

        private void ButtonListBox_Click(object sender, RoutedEventArgs e)
        {
            var window = new ListBox();
            window.Show();
        }

        private void ButtonComboBox_Click(object sender, RoutedEventArgs e)
        {
            var window = new ComboBox();
            window.Show();
        }

        private void BoldToolButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonGrid_Click(object sender, RoutedEventArgs e)
        {
            var window = new Grid();
            window.Show();
        }

        private void ButtonCanvas_Click(object sender, RoutedEventArgs e)
        {
            var window = new Canvas();
            window.Show();
        }

        private void ButtonDragDrop_Click(object sender, RoutedEventArgs e)
        {
            var window = new DragDrop();
            window.Show();
        }

        private void ButtonDataBinding_Click(object sender, RoutedEventArgs e)
        {
            var window = new DataBinding();
            window.Show();
        }

        private void ButtonCustomControl_Click(object sender, RoutedEventArgs e)
        {
            var window = new CustomControl();
            window.Show();
        }

        private void ButtonBehavior_Click(object sender, RoutedEventArgs e)
        {
            var window = new Behavior();
            window.Show();
        }

        private void ButtonUserControl_Click(object sender, RoutedEventArgs e)
        {
            var window = new UserControl();
            window.Show();
        }

        private void ButtonStyle_Click(object sender, RoutedEventArgs e)
        {
            var window = new Style();
            window.Show();
        }

        private void ButtonTrigger_Click(object sender, RoutedEventArgs e)
        {
            var window = new Trigger();
            window.Show();
        }

        private void ButtonResource_Click(object sender, RoutedEventArgs e)
        {
            var window = new Resource();
            window.Show();
        }
    }
}
