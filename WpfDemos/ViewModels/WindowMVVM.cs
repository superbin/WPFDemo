using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using WpfDemos.Models;

namespace WpfDemos.ViewModels
{
    class WindowMVVM : INotifyPropertyChanged
    {
        private UserModel _selectedUser;
        private ObservableCollection<UserModel> _userCollection;
        private UserModel _newUserDetails;

        public WindowMVVM()
        {
            UserCollection = new ObservableCollection<UserModel>
            {
                new UserModel
                {
                    FirstName = "User", LastName = "One"
                },
                new UserModel
                {
                    FirstName = "User", LastName = "Two"
                },
                new UserModel
                {
                    FirstName = "User", LastName = "Three"
                },
                new UserModel
                {
                    FirstName = "User", LastName = "Four"
                }
            };
            NewUserDetails = new UserModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public UserModel SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<UserModel> UserCollection
        {
            get => _userCollection;
            set
            {
                _userCollection = value;
                OnPropertyChanged("UserCollection");
            }
        }
        public UserModel NewUserDetails
        {
            get => _newUserDetails;
            set
            {
                _newUserDetails = value;
                OnPropertyChanged("NewUserDetails");
            }
        }

    }
}
