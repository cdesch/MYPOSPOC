using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPOSPOC
{
    class MasterDetailViewModel : ViewModelBase
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
        public MasterDetailViewModel()
        {
            _currentUserList = new UserList();
        }

        public void SelectedUser()
        {
            Console.Write("UserSelected");
            //DO Something when user is selected
        }
    }
}
