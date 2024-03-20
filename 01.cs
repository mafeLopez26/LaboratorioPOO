using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Registrar cliente");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarCliente();
                        break;
                    case 2:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione nuevamente.");
                        break;
                }
            }
        }

        static void RegistrarCliente()
        {
            Cuenta cuenta = new Cuenta();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Menú de cuenta:");
                Console.WriteLine("1. Acreditar saldo");
                Console.WriteLine("2. Cargar saldo");
                Console.WriteLine("3. Obtener saldo actual");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el monto a acreditar: ");
                        int montoCredito = int.Parse(Console.ReadLine());
                        cuenta.Credit(montoCredito);
                        Console.WriteLine("Saldo acreditado exitosamente.");
                        break;
                    case 2:
                        Console.Write("Ingrese el monto a cargar: ");
                        int montoCarga = int.Parse(Console.ReadLine());
                        cuenta.Cargar(montoCarga);
                        break;
                    case 3:
                        Console.WriteLine("Saldo actual de la cuenta: " + cuenta.ObtenerSaldo());
                        break;
                    case 4:
                        Console.WriteLine("Volviendo al menú principal...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione nuevamente.");
                        break;
                }
            }
        }

        class Cuenta
        {
            private int saldo = 0;
            private int monto = 0;

            public Cuenta()
            {
                saldo = 0;
            }

            public void Credit(int monto)
            {
                this.monto = monto;
                saldo += monto;
            }
            public void Cargar(int monto)
            {
                this.monto = monto;
                if (monto > saldo)
                {
                    Console.WriteLine("El monto a cargar excede el saldo de la cuenta");
                }
                else
                {
                    saldo -= monto;
                    Console.WriteLine("Saldo cargado exitosamente.");
                }
            }
            public int ObtenerSaldo()
            {
                return saldo;
            }
        }
    }
}
