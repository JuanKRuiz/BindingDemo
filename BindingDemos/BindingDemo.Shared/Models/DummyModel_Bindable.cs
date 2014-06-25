using System.ComponentModel;

namespace BindingDemo.Models
{
    public class DummyModel_Bindable : BindableBase
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


        public DummyModel_Bindable()
        {
            EnableButton = true;
            TextoUnicaVez = "Asignado por única vez";
            TextNotificacionPorCambio = "Asignado cuando hay cambios en el modelo";
            TextNotificacionBidireccional = "Cambiando el modelo ante cambios en la UI";
        }
    }
}
