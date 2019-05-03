using System;
using System.Collections.Generic;
using MovilVentas_Modulo1.ConsoleApp.Services;
using MovilVentasModulo1.Domain.Interfaces;

namespace MovilVentas_Modulo1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<string> lista = new List<string>();

            INotificacionPedidos notificacionPedidos = new NotificacionPedidos();

            string msg= notificacionPedidos.MostrarNotificacion("Hola", "saludo a el curso de .net core");
             
            Console.WriteLine(msg);
        }
    }
}
