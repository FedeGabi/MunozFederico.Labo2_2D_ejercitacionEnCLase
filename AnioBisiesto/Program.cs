using System;

namespace AnioBisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            Console.WriteLine("ingrese año Inicio: ");
            while(!int.TryParse(Console.ReadLine(), out anioInicio))   // Pido año de inicio
            {
                Console.WriteLine("Error... reingrese año: ");
            }

            Console.WriteLine("ingrese anio Fin: ");
            while (!int.TryParse(Console.ReadLine(), out anioFin))      // Pido año final
            {
                Console.WriteLine("Error... reingrese año: ");
            }

            if (anioInicio < anioFin)
            {
                Console.Clear();
                Console.WriteLine("AÑOS BISIESTOS: ");
                for (int i = anioInicio; i < anioFin ; i++)
                {
                    if (DateTime.IsLeapYear(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("el año de incio debe ser menor al anio de finalizacion");
            }

        }
    }
}
