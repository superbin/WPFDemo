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
using WpfDemos.ViewModels;

namespace WpfDemos.Views
{
    /// <summary>
    /// Interaction logic for mvvm.xaml
    /// </summary>
    public partial class mvvm : Window
    {
        private WindowMVVM ViewModel = null;
        public mvvm()
        {
            InitializeComponent();
            ViewModel = Resources["ViewModel"] as WindowMVVM;
            if (ViewModel == null)
            {
                throw new NullReferenceException("ViewModel can't be NULL");
            }
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (ViewModel != null)
            {
                var userDetails = ViewModel.NewUserDetails;
                e.CanExecute = !string.IsNullOrWhiteSpace(userDetails.FirstName) &&
                    !string.IsNullOrWhiteSpace(userDetails.LastName);
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ViewModel.UserCollection.Add(ViewModel.NewUserDetails);
            ViewModel.SelectedUser = ViewModel.NewUserDetails;
            ViewModel.NewUserDetails = new Models.UserModel();
        }
    }
}
