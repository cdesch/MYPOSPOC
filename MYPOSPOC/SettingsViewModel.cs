using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MYPOSPOC
{
    class SettingsViewModel : ViewModelBase
    {
        // public Settings settings { get; set; }


        string _PrinterName;

        public string PrinterName
        {
            get
            {
                return _PrinterName;
            }
            set
            {
                if (_PrinterName != value)
                {
                    _PrinterName = value;
                    Properties.Settings.Default.PrinterName = _PrinterName;
                    Console.WriteLine("PrinterNameChanged");
                    RaisePropertyChanged("PrinterName");
                }
            }
        }


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

        private Settings _settings;
        public Settings CurrentSettings
        {
            get { return _settings; }
            set
            {
                if (value != _settings)
                {
                    _settings = value;
                    RaisePropertyChanged("CurrentSettings");
                }
            }
        }
        public SettingsViewModel()
        {
            _settings = new Settings();

        }
    }


}
