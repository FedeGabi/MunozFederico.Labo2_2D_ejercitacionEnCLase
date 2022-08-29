using System;

namespace CuantasPrimaverasTenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("loRENita", "22/08/1986", 32856240);
            Persona persona2 = new Persona("pEpiTO", "5/5/1999", 34285674);
            Persona persona3 = new Persona("roBERtiTO", "11/11/2004", 55256240);
            Console.WriteLine(persona1.MostrarInfo());
            Console.WriteLine(persona2.MostrarInfo());
            Console.WriteLine(persona3.MostrarInfo());
        }
    }
}
