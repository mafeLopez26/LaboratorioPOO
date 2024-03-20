using System;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factura factura = null;

            int opcion;

            while (true)
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. Crear nueva factura");
                Console.WriteLine("2. Mostrar factura actual");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el número de pieza:");
                        string numeroPieza = Console.ReadLine();

                        Console.WriteLine("Ingrese la descripción de la pieza:");
                        string descripcionPiezas = Console.ReadLine();

                        Console.WriteLine("Ingrese la cantidad de piezas:");
                        int cantidadPiezas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese el precio por artículo:");
                        int precioArticulo = Convert.ToInt32(Console.ReadLine());

                        factura = new Factura(numeroPieza, descripcionPiezas, cantidadPiezas, precioArticulo);

                        Console.WriteLine("¡Factura creada con éxito!");
                        break;

                    case 2:

                        if (factura != null)
                        {
                            Console.WriteLine("INFORMACIÓN DE LA FACTURA:");
                            Console.WriteLine("Número de pieza: " + factura.ObtenerNumeroPieza());
                            Console.WriteLine("Descripción de piezas: " + factura.ObtenerDescripcionPiezas());
                            Console.WriteLine("Cantidad de piezas: " + factura.ObtenerCantidadPiezas());
                            Console.WriteLine("Precio por artículo: " + factura.ObtenerPrecioArticulo());
                            Console.WriteLine("Monto de la factura: " + factura.obtenerMontoFactura());
                        }
                        else
                        {
                            Console.WriteLine("No hay factura creada.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("¡Hasta luego!");
                        return;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        class Factura
        {
            private string numeroPieza;
            private string descripcionPiezas;
            private int cantidadPiezas = 0;
            private int precioarticulo = 0;

            public Factura(string numeroPieza, string descripcionPiezas, int cantidadPiezas, int precioarticulo)
            {
                this.numeroPieza = numeroPieza;
                this.descripcionPiezas = descripcionPiezas;
                this.cantidadPiezas = cantidadPiezas;
                this.precioarticulo = precioarticulo;
            }

            public void EstablecerNumeroPieza(string numeroPieza)
            {
                this.numeroPieza = numeroPieza;
            }

            public string ObtenerNumeroPieza()
            {
                return numeroPieza;
            }

            public void EstablecerDescripcionPiezas(string descripcionPiezas)
            {
                this.descripcionPiezas = descripcionPiezas;
            }

            public string ObtenerDescripcionPiezas()
            {
                return descripcionPiezas;
            }

            public void EstablecerCantidadPiezas(int cantidadPiezas)
            {
                this.cantidadPiezas = cantidadPiezas;
            }

            public int ObtenerCantidadPiezas()
            {
                return cantidadPiezas;
            }

            public void EstablecerPrecioArticulo(int precioarticulo)
            {
                this.precioarticulo = precioarticulo;
            }

            public int ObtenerPrecioArticulo()
            {
                return precioarticulo;
            }

            public int obtenerMontoFactura()
            {
                return cantidadPiezas * precioarticulo;
            }
        }
    }
}
