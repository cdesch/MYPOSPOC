using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPOSPOC
{
    class UserListViewModel : ViewModelBase
    {
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

        }
    }
    
}
