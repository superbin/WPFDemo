using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for DataBinding.xaml
    /// </summary>
    public partial class DataBinding : Window, INotifyPropertyChanged
    {
        public DataBinding()
        {
            InitializeComponent();
        }
        private string _personName;
        public string Department { get => "Software Engineering"; }
        //public string PersonName {
        //    get => _personName;
        //    set
        //    {
        //        _personName = value;
        //        OnPropertyChanged("PersonName");
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello " + PersonName);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            PersonName = string.Empty;
        }
        //public void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}


        public string PersonName
        {
            get { return (string)GetValue(PersonNameProperty); }
            set { SetValue(PersonNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PersonName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PersonNameProperty =
            DependencyProperty.Register("PersonName", typeof(string), typeof(DataBinding), new PropertyMetadata(string.Empty));


    }
}
