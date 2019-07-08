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
using System.Collections.ObjectModel;

namespace WpfDemos
{
    /// <summary>
    /// Interaction logic for DataBinding.xaml
    /// </summary>
    public partial class DataBinding : Window//, INotifyPropertyChanged
    {
        public DataBinding()
        {
            InitializeComponent();
            PersonDetails = new Person
            {
                Name = "Google",
                Blog = "https://www.google.com",
                Experience = 10
            };
            DataContext = PersonDetails;

            Employees = new ObservableCollection<Employee>
            {
                new Employee
                {
                    FirstName = "Kunal", LastName = "Chowdhury",
                    Department = "Software Division"
                },
                new Employee
                {
                    FirstName = "Michael", LastName = "Washington",
                    Department = "Software Division"
                },
                new Employee
                {
                    FirstName = "John", LastName = "Strokes",
                    Department = "Finance Department"
                }
            };
            dataGrid.ItemsSource = Employees;
        }
        //private string _personName;
        public string Department { get => "Software Engineering"; }
        //public string PersonName {
        //    get => _personName;
        //    set
        //    {
        //        _personName = value;
        //        OnPropertyChanged("PersonName");
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

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


        //propdp snip
        public string PersonName
        {
            get { return (string)GetValue(PersonNameProperty); }
            set { SetValue(PersonNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PersonName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PersonNameProperty =
            DependencyProperty.Register("PersonName", typeof(string), typeof(DataBinding), new PropertyMetadata(string.Empty));



        public Person PersonDetails
        {
            get { return (Person)GetValue(PersonDetailsProperty); }
            set { SetValue(PersonDetailsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PersonDetails.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PersonDetailsProperty =
            DependencyProperty.Register("PersonDetails", typeof(Person), typeof(DataBinding), new PropertyMetadata(null));



        public ObservableCollection<Employee> Employees
        {
            get { return (ObservableCollection<Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<Employee>), typeof(DataBinding), new PropertyMetadata(null));


    }
}
