using System;

namespace LosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool bandera = true;
            bool banderaMostrar = true;
            Console.WriteLine("ingrese numero: ");
            while(!int.TryParse(Console.ReadLine(), out numero) || numero <1)
            {
                Console.WriteLine("ERROR... Reingrese numero");
            }
            for (int i =1; i<numero; i++)
            {
                banderaMostrar = true;
                for (int j = 2; j < i-1; j++)
                {
                    if (bandera)
                    {
                        banderaMostrar = false;
                        bandera = false;
                    }
                    else if (i % j == 0)
                    {
                        banderaMostrar = false;
                        break;
                    }
                }
                if (banderaMostrar && i > 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}
