using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MYPOSPOC
{
    class UserList
    {

        private ObservableCollection<User> _users;

        public UserList()
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
    }
}
