using System;
using MovilVentasModulo1.Domain.Interfaces;

namespace MovilVentas_Modulo1.Api.Services
{
    public class NotificacionPedidos: INotificacionPedidos
    {
        public NotificacionPedidos()
        {
        }

        public string MostrarNotificacion(string title, string message)
        {
            return $"{title} desde el API, {message}  :D :D :D";
        }
    }
}
