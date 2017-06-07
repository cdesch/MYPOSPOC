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

namespace MYPOSPOC
{
    /// <summary>
    /// Interaction logic for MasterDetailControl.xaml
    /// </summary>
    public partial class MasterDetailControl : UserControl
    {


        //private MasterDetailViewModel viewModel;
        private UserListViewModel viewModel;

        public MasterDetailControl()
        {
            InitializeComponent();
            //viewModel = new MasterDetailViewModel();
            viewModel =  UserListViewModel.Instance();

            this.DataContext = viewModel;
        }
    }
}
