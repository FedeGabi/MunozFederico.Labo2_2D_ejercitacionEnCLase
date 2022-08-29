using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreoQueNecesitoUnPrestamo
{
    internal class Cuenta
    {

        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {

            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular()
        {
            return titular;
        }

        public double Cantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"Razon social: {titular}");
            cadena.AppendLine($"Cantidad: {cantidad}");
            return cadena.ToString();
        }

        public void Ingresar(double monto)
        {
            if(monto>0)
            {
                cantidad = monto;
            }
        }

        public void Retirar(double monto)
        {
            cantidad = cantidad - monto;
        }

    }
}
