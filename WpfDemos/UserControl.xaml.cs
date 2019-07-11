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
using System.Windows.Shapes;

namespace WpfDemos
{
    /// <summary>
    /// Interaction logic for UserControl.xaml
    /// </summary>
    public partial class UserControl : Window
    {
        public UserControl()
        {
            InitializeComponent();
        }

        private void ColorMixer_okButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("OK button clicked");
        }

        private void ColorMixer_cancelButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel button clicked");
        }
    }
}
