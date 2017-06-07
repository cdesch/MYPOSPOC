using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MYPOSPOC
{
    class Settings : INotifyPropertyChanged
    {


        string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    RaisePropertyChanged("FirstName");
                }
            }
        }

        string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    RaisePropertyChanged("LastName");
                }
            }
        }
        public Settings()
        {
            _LastName = "MyLast Name";
            _FirstName = "My First Name";
        }

        /*
        public String Title { get; set; }
        public String Name { get; set; }


        public Settings()
        {
            Name = "";
            Title = "";
        }

        public Settings(string title, string name)
        {
            Name = name;
            Title = Title;
        }
        */
        //Delegate

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
