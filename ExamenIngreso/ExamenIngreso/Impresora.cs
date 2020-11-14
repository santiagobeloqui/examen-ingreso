using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngreso
{
    class Impresora
    {
        public static void ImprimirCotizacion(Cotizacion cotizacion)
        {
            Console.WriteLine("Simulacion de impresion de Cotizacion");
        }

        public static void ImprimirHistorial(List<Cotizacion> historial)
        {
            Console.WriteLine("Simulacion de impresion de Historial");
            if (historial.Count >=1)
            {
                Console.WriteLine("Historial");
                Console.WriteLine("---------");
                foreach (Cotizacion cotizacion in historial)
                {
                    Console.WriteLine($"Cotizacion {cotizacion.NumeroIdentificacion}. Fecha y hora: {cotizacion.FechaHora}. Resultado: ${cotizacion.ResultadoCotizacion}.");
                }

            }
            else
            {
                Console.WriteLine("El Historial esta vacio");
            }
        }
    }
}
