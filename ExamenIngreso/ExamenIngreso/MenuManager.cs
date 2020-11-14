using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngreso
{
    class MenuManager
    {
        private Tienda tienda;
        private Vendedor vendedor;
        private Prenda prendaElegida;

        public MenuManager(Tienda tienda, Vendedor vendedor)
        {
            this.tienda = tienda;
            this.vendedor = vendedor;
        }
        public void IniciarMenu()
        {
            Console.WriteLine($"Bienvenido/a al Cotizador de {tienda.Nombre} - {tienda.Direccion}");
            Console.WriteLine($"Vendedor/a: {vendedor.Nombre} {vendedor.Apellido} - Codigo: {vendedor.CodigoVendedor}");
            int opcionPrincipal = 0;
            do
            {
                Console.WriteLine("\nIngrese el numero de opcion deseada\n 1.Cotizar\n 2.Imprimir historial de cotizaciones\n 3.Salir");
                String opcionPrincipalToParse = Console.ReadLine();
                try
                {
                    opcionPrincipal = int.Parse(opcionPrincipalToParse);
                    if (opcionPrincipal == 1)
                    {
                        this.ElegirPrenda();
                        this.Cotizar();
                    }
                    else if (opcionPrincipal == 2)
                    {
                        Impresora.ImprimirHistorial(vendedor.Historial);
                    }
                }
                catch
                {
                    this.AlertarOpcionIncorrecta();
                }

            } while (opcionPrincipal != 3);
        }

        private void ElegirPrenda()
        {

            int opcionPrenda = 0;
            do
            {
                Console.WriteLine("\nElija el tipo de prenda\n 1.Camisa\n 2.Pantalon");
                String opcionPrendaToParse = Console.ReadLine();
                try
                {
                    opcionPrenda = int.Parse(opcionPrendaToParse);
                    if(opcionPrenda == 1)
                    {
                        this.ElegirTipoCamisa();

                    } else if(opcionPrenda == 2)
                    {
                        this.ElegirTipoPantalon();
                    }
                }
                catch
                {
                    this.AlertarOpcionIncorrecta();
                }

            } while (opcionPrenda != 1 && opcionPrenda != 2);

        }

        private void ElegirTipoCamisa()
        {
            int opcionMangas = 0;
            do 
            {
                Console.WriteLine("\nElija el tipo de mangas\n 1.Cortas\n 2.Largas"); 
                String opcionMangasToParse = Console.ReadLine();
                try
                {
                    opcionMangas = int.Parse(opcionMangasToParse);
                    
                }
                catch
                {
                    this.AlertarOpcionIncorrecta();
                }

            } while (opcionMangas != 1 && opcionMangas != 2);
            int opcionCuello = 0;
            do
            {
                Console.WriteLine("\nElija el tipo de cuello\n 1.Mao\n 2.Normal");
                String opcionCuelloToParse = Console.ReadLine();
                try
                {
                    opcionCuello = int.Parse(opcionCuelloToParse);
                }
                catch
                {
                    this.AlertarOpcionIncorrecta();
                }

            } while (opcionCuello != 1 && opcionCuello != 2);

            List<Prenda> camisas = new List<Prenda>();

            foreach (Prenda prenda in tienda.PrendasEnVenta)
            {
                if (prenda.GetType() == typeof(Camisa))
                {
                    camisas.Add(prenda);
                }
            }

            foreach (Camisa camisa in tienda.PrendasEnVenta)
            {
                if(opcionMangas == 1 && opcionCuello == 1)
                {
                    if(camisa.EsMangaCorta && camisa.EsCuelloMao)
                    {
                        this.prendaElegida = camisa;
                    }

                } else if (opcionMangas == 1 && opcionCuello == 2)
                {
                    if (camisa.EsMangaCorta && !camisa.EsCuelloMao)
                    {
                        this.prendaElegida = camisa;
                    }
                }
                else if(opcionMangas == 2 && opcionCuello == 1)
                {
                    if (!camisa.EsMangaCorta && camisa.EsCuelloMao)
                    {
                        this.prendaElegida = camisa;
                    }
                }
                else if(opcionMangas == 2 && opcionCuello == 2)
                {
                    if (!camisa.EsMangaCorta && !camisa.EsCuelloMao)
                    {
                        this.prendaElegida = camisa;
                    }
                }
            }
        }

        private void ElegirTipoPantalon()
        {
            int opcionChupin = 0;
            do
            {
                Console.WriteLine("\nElija el tipo de pantalon\n 1.Chupin\n 2.Normal");
                String opcionChupinToParse = Console.ReadLine();
                try
                {
                    opcionChupin = int.Parse(opcionChupinToParse);

                }
                catch
                {
                    this.AlertarOpcionIncorrecta();
                }

            } while (opcionChupin != 1 && opcionChupin != 2);

            List<Prenda> pantalones = new List<Prenda>();

            foreach(Prenda prenda in tienda.PrendasEnVenta)
            {
                if(prenda.GetType() == typeof(Pantalon))
                {
                    pantalones.Add(prenda);
                }
            }

            foreach (Pantalon pantalon in pantalones)
            {
                if (opcionChupin == 1)
                {
                    if (pantalon.EsChupin)
                    {
                        this.prendaElegida = pantalon;
                    }

                }
                else
                {
                    if (!pantalon.EsChupin)
                    {
                        this.prendaElegida = pantalon;
                    }
                }
            }
        }

        private void Cotizar()
        {
            int opcionCalidad = 0;
            float precio = 0f;
            bool esCalidadPremium = false;
            int cantidad = 0;
            do
            {
                Console.WriteLine("\nElija la calidad de la prenda\n 1.Standard\n 2.Premium");
                String opcionCalidadToParse = Console.ReadLine();
                try
                {
                    opcionCalidad = int.Parse(opcionCalidadToParse);
                    if(opcionCalidad == 1)
                    {
                        esCalidadPremium = false;
                    } else if( opcionCalidad == 2)
                    {
                        esCalidadPremium = true;
                    }
                }
                catch
                {
                    this.AlertarOpcionIncorrecta();
                }

            } while (opcionCalidad != 1 && opcionCalidad != 2);

            do
            {
                Console.WriteLine("\nIngrese el precio de la prenda:");
                String precioToParse = Console.ReadLine();
                try
                {
                    precio = float.Parse(precioToParse);
                }
                catch
                {
                    this.AlertarOpcionIncorrecta();
                }

            } while (precio <= 0);

            do
            {
                Console.WriteLine("\nIngrese la cantidad de prendas:");
                String cantidadToParse = Console.ReadLine();
                try
                {
                    cantidad = int.Parse(cantidadToParse);
                    if(cantidad > prendaElegida.UnidadesEnStock)
                    {
                        Console.WriteLine("\nNo hay suficiente cantidad en stock.");
                    }
                }
                catch
                {
                    this.AlertarOpcionIncorrecta();
                }

            } while (cantidad <= 0 || cantidad > prendaElegida.UnidadesEnStock);

            float valorPrenda = this.prendaElegida.CalcularPrecio(precio, esCalidadPremium);
            float valorTotal = valorPrenda * cantidad;

            Cotizacion cotizacion = new Cotizacion(vendedor.Historial.Count + 1, DateTime.Now, vendedor.CodigoVendedor, this.prendaElegida, cantidad, valorTotal);
            vendedor.Historial.Add(cotizacion);

            Console.WriteLine($"\nEl total de la cotización es: ${valorTotal}");

            int opcionImprimir = 0;
            do
            {
                Console.WriteLine("\nSi desea imprimir la cotización ingrese 1. Para volver al menu principal ingrese 2.");
                String opcionImprimirToParse = Console.ReadLine();
                try
                {
                    opcionImprimir = int.Parse(opcionImprimirToParse);
                    if(opcionImprimir == 1)
                    {
                        Impresora.ImprimirCotizacion(cotizacion);
                    }
                }
                catch
                {
                    this.AlertarOpcionIncorrecta();
                }
            } while (opcionImprimir != 1 && opcionImprimir != 2);
        }

        private void AlertarOpcionIncorrecta()
        {
            Console.WriteLine("\nValor no aceptado");
        }
    }
}
