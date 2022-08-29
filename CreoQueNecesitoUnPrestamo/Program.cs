using System;

namespace CreoQueNecesitoUnPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta nuevaCuenta = new Cuenta("Robertito Perez", 0);
            Cuenta nuevaCuenta2 = new Cuenta("Carlitos Garcia", 0);
            Cuenta nuevaCuenta3 = new Cuenta("Albertito Diaz", 0);

            Console.Write(nuevaCuenta.Mostrar());
            Console.Write(nuevaCuenta2.Mostrar());
            Console.Write(nuevaCuenta3.Mostrar());
            Console.WriteLine("\n");

            nuevaCuenta.Ingresar(4080);
            nuevaCuenta2.Ingresar(1800);
            nuevaCuenta3.Ingresar(2650);

            Console.Write(nuevaCuenta.Mostrar());
            Console.Write(nuevaCuenta2.Mostrar());
            Console.Write(nuevaCuenta3.Mostrar());
            Console.WriteLine("\n");

            nuevaCuenta.Retirar(1250);
            nuevaCuenta2.Retirar(1000);
            nuevaCuenta3.Retirar(950);

            Console.Write(nuevaCuenta.Mostrar());
            Console.Write(nuevaCuenta2.Mostrar());
            Console.Write(nuevaCuenta3.Mostrar());
            Console.WriteLine("\n");
        }
    }
}
