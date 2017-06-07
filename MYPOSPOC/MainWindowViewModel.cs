using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace MYPOSPOC
{
    class MainWindowViewModel
    {

        private readonly IDialogCoordinator _dialogCoordinator;

        public MainWindowViewModel(IDialogCoordinator dialogCoordinator)
        {
            //this.Title = "Flyout Binding Test";
            _dialogCoordinator = dialogCoordinator;

        }


    
    }
}
