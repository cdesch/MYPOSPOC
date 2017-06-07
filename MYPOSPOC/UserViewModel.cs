using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPOSPOC
{
    class UserViewModel : ViewModelBase 
    {


        //Needs to be a CRUD function here
        public string FirstName
        {
            get { return _currentUser.FirstName; }
            set
            {
                _currentUser.FirstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _currentUser.LastName; }
            set
            {
                _currentUser.LastName = value;
                RaisePropertyChanged("LastName");
            }
        }



        private User _currentUser;
        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (value != _currentUser)
                {
                    _currentUser = value;
                    RaisePropertyChanged("CurrentUser");
                }
            }
        }
        public UserViewModel()
        {
            _currentUser = new User();
        }

        public UserViewModel(User user)
        {
            _currentUser = user;
        }
    }
}
