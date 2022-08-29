using System;

namespace ValidadorDeRangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = 0;
            int maximo = 0;
            decimal promedio;
            int contador = 0;
            int acumulador = 0;
            Boolean bandera = true;


            do
            {
                Console.WriteLine("ingrese numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero) || (!Validador.Validar(numero, -100, 100)))
                {
                    Console.WriteLine($"Error solo se admiten valores numericos entre el rango de: -100 y 100 ... Reingrese numero: ");
                }

                if (bandera)
                {
                    acumulador += numero;
                    minimo = numero;
                    maximo = numero;
                    bandera = false;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                    acumulador += numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                    acumulador += numero;
                }
                contador++;
            } while (contador < 5);
            promedio = ((decimal)acumulador / contador);
            Console.WriteLine("El maximo fue {0} y el minimo {1}", maximo, minimo);
            Console.WriteLine("El promedio es {0}", promedio);
        }
    }
}
