﻿using System;
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
    /// Interaction logic for ColorMixer.xaml
    /// </summary>
    public partial class ColorMixer : System.Windows.Controls.UserControl
    {
        public delegate void OnOKButtonClick(object sender, EventArgs e);
        public delegate void OnCancelButtonClick(object sender, EventArgs e);
        public event OnOKButtonClick okButtonClick;
        public event OnCancelButtonClick cancelButtonClick;

        public ColorMixer()
        {
            InitializeComponent();
        }

        public Color SelectedColor
        {
            get { return (Color)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorMixer), new PropertyMetadata(Colors.OrangeRed));


        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            okButtonClick?.Invoke(sender, e);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            cancelButtonClick?.Invoke(sender, e);
        }
    }
}
