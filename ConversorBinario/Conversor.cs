using System;
using System.Text;

namespace ConversorBinario
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder numeroBinario = new StringBuilder();
            StringBuilder auxiliar = new StringBuilder();
            int aux = numeroEntero;
            do
            {
                numeroBinario.Append((aux % 2).ToString());
                aux = aux / 2;

            } while (aux != 0);
            for (int i = numeroBinario.ToString().Length - 1; i >= 0; i--)
            {
                auxiliar.Append(numeroBinario[i]);
            }
            return auxiliar.ToString();
        }


        public static int ConvertirBinarioADecimal(int numero)
        {
            string stringNumero = numero.ToString();
            double acumulador = 0;
            int auxiliar;
            int j = 0;
            
            for (int i = stringNumero.Length-1; i >=0 ; i--)
            {
                if (Convert.ToInt32(stringNumero[i]) == 48)
                {
                    acumulador += (Math.Pow(2, j) * 0);
                }
                else
                {
                    acumulador += (Math.Pow(2, j) * 1);
                }
                j++;
            }
            auxiliar = Convert.ToInt32(acumulador);
            return auxiliar;
        }
    }
}
