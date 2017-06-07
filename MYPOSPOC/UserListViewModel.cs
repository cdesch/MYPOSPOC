using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MYPOSPOC
{
    class UserListViewModel : ViewModelBase
    {
        private static UserListViewModel instance = null;

        /*
        private UserList _currentUserList;
        public UserList CurrentUserList
        {
            get { return _currentUserList; }
            set
            {
                if (value != _currentUserList)
                {
                    _currentUserList = value;
                    RaisePropertyChanged("CurrentUserList");
                }
            }
        }
        public UserListViewModel()
        {
            _currentUserList = new UserList();

        }*/

        private UserViewModel selectedCustomer = null;
        private ObservableCollection<UserViewModel> _customerList = null;
        

        public ObservableCollection<UserViewModel> CustomerList
        {
            get
            {
                return GetCustomers();
            }
            set
            {
                _customerList = value;
                RaisePropertyChanged("CustomerList");
            }
        }

        //the currently selected customer
        public UserViewModel SelectedCustomer
        {
            get
            {
                return selectedCustomer;
            }
            set
            {
                selectedCustomer = value;
                RaisePropertyChanged("SelectedCustomer");
            }
        }
        /*
        public UserListViewModel()
        {
            _users = new ObservableCollection<User>();
            User c = new User() { FirstName = "John", LastName = "Doe" };
            _users.Add(c);
            c = new User() { FirstName = "Jane", LastName = "Doe" };
            _users.Add(c);
            c = new User() { FirstName = "John", LastName = "Davis" };
            _users.Add(c);
            c = new User() { FirstName = "Kim", LastName = "Kardashian" };
            _users.Add(c);


        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
        }
        */

        private UserListViewModel()
        {
            this.CustomerList = GetCustomers();
        }

        public static UserListViewModel Instance()
        {
            if (instance == null)
                instance = new UserListViewModel();
            return instance;
        }

        internal ObservableCollection<UserViewModel> GetCustomers()
        {
            _customerList = new ObservableCollection<UserViewModel>();
            User c = new User() { FirstName = "John", LastName = "Doe" };
            _customerList.Add(new UserViewModel(c));
            c = new User() { FirstName = "Jane", LastName = "Doe" };
            _customerList.Add(new UserViewModel(c));
            c = new User() { FirstName = "John", LastName = "Davis" };
            _customerList.Add(new UserViewModel(c));
            c = new User() { FirstName = "Kim", LastName = "Kardashian" };
            _customerList.Add(new UserViewModel(c));

            return _customerList;
        }

    }

}
