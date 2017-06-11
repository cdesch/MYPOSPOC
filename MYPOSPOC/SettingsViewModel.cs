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
