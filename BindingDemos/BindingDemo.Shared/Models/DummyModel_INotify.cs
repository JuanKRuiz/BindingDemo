using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BindingDemo.Models
{
    public class DummyModel_INotify : INotifyPropertyChanged
    {
        public string TextoUnicaVez { get; set; }

        private bool _enableButton;
        public bool EnableButton
        {
            get { return _enableButton; }
            set
            {
                SetProperty(ref _enableButton, value);
            }
        }

        private string _textNotificacionPorCambio;
        public string TextNotificacionPorCambio
        {
            get { return _textNotificacionPorCambio; }
            set
            {
                SetProperty(ref _textNotificacionPorCambio, value);
            }
        }

        private string _textNotificacionBidireccional;
        public string TextNotificacionBidireccional
        {
            get { return _textNotificacionPorCambio; }
            set
            {
                SetProperty(ref _textNotificacionBidireccional, value);
            }
        }


        public DummyModel_INotify()
        {
            EnableButton = true;
            TextoUnicaVez = "Asignado por única vez";
            TextNotificacionPorCambio = "Asignado cuando hay cambios en el modelo";
            TextNotificacionBidireccional = "Cambiando el modelo ante cambios en la UI";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool SetProperty<T>(ref T propertyBackStore, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (Equals(propertyBackStore, newValue))
                return false;

            propertyBackStore = newValue;
            if (PropertyChanged != null)
                PropertyChanged(this,
                                new PropertyChangedEventArgs(propertyName)
                                );

            return true;
        }
    }
}
