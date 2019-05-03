using System;
using MovilVentasModulo1.Domain.Interfaces;

namespace MovilVentas_Modulo1.ConsoleApp.Services
{
    public class NotificacionPedidos: INotificacionPedidos
    {
        public NotificacionPedidos()
        {
        }

        public string MostrarNotificacion(string title, string message)
        {
            return $"{title}! {message} :D";
        }
    }
}
