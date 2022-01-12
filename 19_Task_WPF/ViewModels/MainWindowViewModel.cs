using _19_Task_WPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _19_Task_WPF.ViewModels
{
    internal class MainWindowViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string PropertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private double r;
        public double R
        {
            get { return r; }
            set { r = value; OnPropertyChanged(); }
        }
        private double l;
        public double L
        {
            get { return l; }
            set { l = value; OnPropertyChanged(); }
        }
        public ICommand СircumferenceCommand { get; }
        private void OnСircumferenceCommandExecuted(object p)
        {
            L= Сircumference.Circumf(r);

        }
        private bool CanСircumferenceCommandExecuted (object p)
        {
            if (r!=0)
                return true;
            else
                return false;
        }
        public MainWindowViewModel()
        {
            СircumferenceCommand=new RelayCommand(OnСircumferenceCommandExecuted, CanСircumferenceCommandExecuted);
        }
    }
}
