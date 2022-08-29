using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeseaContinuar
{
    internal class Validador
    {
        public static bool ValidarRespuesta()
        {
            char letra;
            Console.WriteLine("¿desea continuar? (S/N): ");
            letra = Console.ReadLine()[0];
            if(Char.ToLower(letra) == 's')
            {
                return true;
            }
            return false;
        }
    }
}
