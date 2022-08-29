using System;

namespace TrianguloEquilatero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo.DibujarTriangulo(10);
        }
    }

    public class Triangulo
    {

        public static void DibujarTriangulo(int altura)
        {
            for (int i = 0; i <= altura; i++)
            {
                for(int j = altura; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }

        }
    }
}
