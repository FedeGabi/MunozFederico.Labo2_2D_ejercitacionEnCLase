using System;

namespace DeseaContinuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int numero;
            do
            {
                Console.WriteLine("ingrese numero: ");
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("caracter invalido");
                }
                else
                {
                    acumulador += numero;
                }

            } while (Validador.ValidarRespuesta());

            Console.WriteLine($"La suma total es: {acumulador}");

        }
    }
}
