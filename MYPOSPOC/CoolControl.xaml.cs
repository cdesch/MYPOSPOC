using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace MYPOSPOC
{
    /// <summary>
    /// Interaction logic for CoolControl.xaml
    /// </summary>
    public partial class CoolControl : UserControl
    {

        private readonly CoolControlViewModel _viewModel;

        public CoolControl()
        {
            _viewModel = new CoolControlViewModel(DialogCoordinator.Instance);
            DataContext = _viewModel;

            InitializeComponent();

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            _viewModel.callfunction();
            /*
            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "Hi",
                NegativeButtonText = "Go away!",
                FirstAuxiliaryButtonText = "Cancel",
                //ColorScheme = MetroDialogOptions.ColorScheme
            };

            MessageDialogResult result = await this.ShowMessageAsync("Hello!", "Welcome to the world of metro!",
                MessageDialogStyle.AffirmativeAndNegativeAndSingleAuxiliary, mySettings);

            if (result != MessageDialogResult.FirstAuxiliary)
                await this.ShowMessageAsync("Result", "You said: " + (result == MessageDialogResult.Affirmative ? mySettings.AffirmativeButtonText : mySettings.NegativeButtonText +
                    Environment.NewLine + Environment.NewLine + "This dialog will follow the Use Accent setting."));
*/

            /*
            LoginDialogData result = await this.ShowLoginAsync("Authentication", "Enter your password", new LoginDialogSettings { ColorScheme = this.MetroDialogOptions.ColorScheme, RememberCheckBoxVisibility = Visibility.Visible });
            if (result == null)
            {
                //User pressed cancel
            }
            else
            {
                MessageDialogResult messageResult = await this.ShowMessageAsync("Authentication Information", String.Format("Username: {0}\nPassword: {1}\nShouldRemember: {2}", result.Username, result.Password, result.ShouldRemember));
            }
            */
        }
    
    }
}
