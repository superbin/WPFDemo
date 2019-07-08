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
    /// Interaction logic for DragDrop.xaml
    /// </summary>
    public partial class DragDrop : Window
    {
        public DragDrop()
        {
            InitializeComponent();
        }

        private void SourcePanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.Source is UIElement uIElement)
            {
                System.Windows.DragDrop.DoDragDrop(uIElement, uIElement, DragDropEffects.Move);
            }
        }

        private void TargetPanel_Drop(object sender, DragEventArgs e)
        {
            var draggedData = e.Data;
            if (draggedData.GetData(draggedData.GetFormats()[0]) is UIElement droppedItem)
            {
                sourcePanel.Children.Remove(droppedItem);
                targetPanel.Children.Add(droppedItem);
            }
        }
    }
}
