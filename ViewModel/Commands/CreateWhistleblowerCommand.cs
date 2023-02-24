using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;

namespace Budweg
{
    public class CreateWhistleblowerCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            bool result = true;
            return result;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                //mvm.Whistleblowers.Add(new Whistleblower(mvm.Title, mvm.Text, mvm.PicturePath)); // mvm.WhistleblowerTypeChoice
                MessageBox.Show($"{mvm.Title}, {mvm.Text}, {mvm.PicturePath}");

            }
        }
    }
}

