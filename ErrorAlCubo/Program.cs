using System;

namespace ErrorAlCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            Console.WriteLine("Ingrese numero: ");
            while(!double.TryParse( Console.ReadLine(), out numero) || numero <=0 )
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            Console.WriteLine("NUMERO: {0}", numero);
            Console.WriteLine("Su cuadrado es {0}, y su cubo es {1}",Math.Pow(numero, 2), Math.Pow(numero, 3));
        }
    }
}
