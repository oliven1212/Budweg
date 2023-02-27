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
    /// Interaction logic for WhistleBlowerPopup.xaml
    /// </summary>
    public partial class WhistleBlowerPopup : Window
    {
        MainViewModel mvm = new MainViewModel();

        public WhistleBlowerPopup()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void TitleField_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }
    }
}
