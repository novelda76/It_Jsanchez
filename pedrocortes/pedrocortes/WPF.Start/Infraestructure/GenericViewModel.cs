using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF.Start.Infraestructure
{
    public class GenericViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
