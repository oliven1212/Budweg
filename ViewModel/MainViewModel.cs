using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace Budweg
{
    public class MainViewModel : INotifyPropertyChanged
    {
        // WHISTLEBLOWER

        public ICommand CreateWhistleblowerCommand { get; } = new CreateWhistleblowerCommand();
        public ObservableCollection<Whistleblower> Whistleblowers { get; set; } = new ObservableCollection<Whistleblower>();
        public event PropertyChangedEventHandler? PropertyChanged;



        public string Title { get; set; }
        public string Text { get; set; }
        public string PicturePath { get; set; }
        public Whistleblower.WhistleblowerType WhistleblowerTypeChoice { get; set; }

    }
}
