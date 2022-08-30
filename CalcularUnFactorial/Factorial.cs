using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularUnFactorial
{
    internal static class Factorial
    {

        public static double CalcularFactorial(double numero)
        {
            if(numero==0)
            {
                return 1;
            }
            return numero * CalcularFactorial(numero -1);
        }

    }
}
