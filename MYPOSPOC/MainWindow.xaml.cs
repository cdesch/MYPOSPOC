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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        private readonly MainWindowViewModel _viewModel;

        public MainWindow()
        {

            _viewModel = new MainWindowViewModel(DialogCoordinator.Instance);

            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        { 
               var mySettings = new MetroDialogSettings()
               {
                   AffirmativeButtonText = "Hi",
                   NegativeButtonText = "Go away!",
                   FirstAuxiliaryButtonText = "Cancel",
                   MaximumBodyHeight = 100,
                   ColorScheme = MetroDialogOptions.ColorScheme
               };

        MessageDialogResult result = await this.ShowMessageAsync("Hello!", "Welcome to the world of metro!" + string.Join(Environment.NewLine, "abc", "def", "ghi", "jkl", "mno", "pqr", "stu", "vwx", "yz"),
            MessageDialogStyle.AffirmativeAndNegativeAndSingleAuxiliary, mySettings);

            if (result != MessageDialogResult.FirstAuxiliary)
                await this.ShowMessageAsync("Result", "You said: " + (result == MessageDialogResult.Affirmative? mySettings.AffirmativeButtonText : mySettings.NegativeButtonText +
                    Environment.NewLine + Environment.NewLine + "This dialog will follow the Use Accent setting."));
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginDialogData result = await this.ShowLoginAsync("Authentication", "Enter your credentials", new LoginDialogSettings { ColorScheme = this.MetroDialogOptions.ColorScheme, InitialUsername = "Your Email", EnablePasswordPreview = true });
            if (result == null)
            {
                //User pressed cancel
            }
            else
            {
                MessageDialogResult messageResult = await this.ShowMessageAsync("Authentication Information", String.Format("Username: {0}\nPassword: {1}", result.Username, result.Password));
            }
        }


        /*
                private async void Button_Click(object sender, RoutedEventArgs e)
                {
                    LoginDialogData result = await this.ShowLoginAsync("Authentication", "Enter your credentials", new LoginDialogSettings { ColorScheme = this.MetroDialogOptions.ColorScheme, InitialUsername = "MahApps" });
                    if (result == null)
                    {
                        //User pressed cancel
                    }
                    else
                    {
                        MessageDialogResult messageResult = await this.ShowMessageAsync("Authentication Information", String.Format("Username: {0}\nPassword: {1}", result.Username, result.Password));
                    }
                }
                */
    }
}
