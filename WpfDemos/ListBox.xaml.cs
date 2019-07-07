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
    /// Interaction logic for ListBox.xaml
    /// </summary>
    public partial class ListBox : Window
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            var newItem = new ListBoxItem { Content = "Item " + (lstBox.Items.Count + 1) };
            lstBox.Items.Add(newItem);
            lstBox.SelectedItem = newItem;
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = lstBox.SelectedItem;
            if (selectedItem != null)
            {
                lstBox.Items.Remove(selectedItem);
                lstBox.SelectedIndex = 0;
            }
        }
    }
}
