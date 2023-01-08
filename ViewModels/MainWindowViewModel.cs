using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab2._19.ViewModels
{
    class MainWindowViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private int radius;
        public int Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }       

        private int circleLength;
        public int CircleLength
        {
            get => circleLength;
            set
            {
                circleLength = value;
                OnPropertyChanged();
            }
        }

        public ICommand Addcommand { get; }
        private void OnAddCommandExecute(object p)
        {
            CircleLength = Ariph.Add(radius);
        }
        private bool CanAddCommandExecuted (object p)
        {
            if (radius != 0)
                return true;
            else
                return false;
        }
        public MainWindowViewModel()
        {
            Addcommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
        }
    }
}
