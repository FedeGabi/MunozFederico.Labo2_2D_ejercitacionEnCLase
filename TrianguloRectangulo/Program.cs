using System;

namespace TrianguloRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo.DibujarTriangulo(5);
        }
    }

    public class Triangulo
    {

        public static void DibujarTriangulo(int altura)
        {
            for(int i=0; i<=altura; i++)
            {
                
                for(int j = 1; j < i*2; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                
            }
            
        }
    }
}
