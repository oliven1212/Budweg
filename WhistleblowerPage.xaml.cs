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
using System.Windows.Shapes;

namespace Budweg
{
    /// <summary>
    /// Interaction logic for WhistleblowerPage.xaml
    /// </summary>
    public partial class WhistleblowerPage : Window
    {
        MainViewModel mvm = new MainViewModel();

        public WhistleblowerPage()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
