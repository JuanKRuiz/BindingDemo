using System;
using System.Collections.Generic;
using System.Text;

namespace BindingDemo.Models
{
public class DummyModel
{
    public bool EnableButton { get; set; }
    public string TextoUnicaVez { get; set; }
    public string TextNotificacionPorCambio { get; set; }
    public string TextNotificacionBidireccional { get; set; }


    public DummyModel()
    {
        EnableButton = true;
        TextoUnicaVez = "Asignado por única vez";
        TextNotificacionPorCambio = "Asignado cuando hay cambios en el modelo";
        TextNotificacionBidireccional = "Cambiando el modelo ante cambios en la UI";
    }
}
}
