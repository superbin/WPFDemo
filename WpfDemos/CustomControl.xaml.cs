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
    /// Interaction logic for CustomControl.xaml
    /// </summary>
    public partial class CustomControl : Window
    {
        public CustomControl()
        {
            InitializeComponent();
        }

        private void SearchControl_SearchButtonClick(object sender, SearchEventArgs e)
        {
            MessageBox.Show("You search for :" + e.SearchItem);
        }
    }
}
