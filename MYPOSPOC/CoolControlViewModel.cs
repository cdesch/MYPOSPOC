using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls.Dialogs;

namespace MYPOSPOC
{
    class CoolControlViewModel
    {

        private IDialogCoordinator dialogCoordinator;

        // Constructor
        public CoolControlViewModel(IDialogCoordinator instance)
        {
            dialogCoordinator = instance;
        }

        // Methods
        private async void FooMessage()
        {
            await dialogCoordinator.ShowMessageAsync(this, "HEADER", "MESSAGE");
        }

        private async void FooProgress()
        {
            // Show...
            ProgressDialogController controller = await dialogCoordinator.ShowProgressAsync(this, "HEADER", "MESSAGE");
            controller.SetIndeterminate();

            // Do your work... 

            // Close...
            await controller.CloseAsync();
        }

        public void callfunction()
        {
            this.FooMessage();
        }
    }
}
