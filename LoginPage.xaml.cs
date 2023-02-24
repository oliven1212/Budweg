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

namespace Budweg
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public MainViewModel mvm = new();

        public LoginPage()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void Click_CreateWhistleblower(object sender, RoutedEventArgs e)
        {
            WhistleBlowerPopup page = new WhistleBlowerPopup();
            this.Close();
            page.Show();
        }
        
    }
}
