using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CuantasPrimaverasTenes
{
    internal class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private long dni;

        internal Persona(string nombre, string fechaDeNacimiento, long dni)
        {
            this.setNombre(nombre);
            this.setFechaNacimiento(fechaDeNacimiento);
            this.setDni(dni);
        }

        internal void setNombre(string nombre)
        {
            string auxiliar;
            if (String.IsNullOrEmpty(nombre))
            {
                this.nombre = "Sin nombre";
            }
            else
            {

                this.nombre =nombre.Trim();
                auxiliar= this.nombre.ToLower();
                auxiliar=auxiliar.Substring(1);                
                this.nombre = char.ToString(char.ToUpper(this.nombre[0]));
                this.nombre= String.Concat(this.nombre, auxiliar);
            }
        }
        internal string getNombre()
        {
            
            return this.nombre;
        }

        internal void setFechaNacimiento(string fechaDeNacimiento)
        {
            DateTime nacimiento;
            if(DateTime.TryParse(fechaDeNacimiento, out nacimiento) && nacimiento < DateTime.Now)
            {
                this.fechaDeNacimiento = nacimiento;
            }

        }

        internal string getFechaNacimiento()
        {
            return this.fechaDeNacimiento.ToString();

        }

        internal void setDni(long dni)
        {
            if(dni > 100000000 || dni < 1000000)
            {
                this.dni = 0;
            }
            else
            {
                this.dni = dni;
            }
        }

        internal long getDni()
        {           
            return this.dni;
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento.Day}/{this.fechaDeNacimiento.Month}/{this.fechaDeNacimiento.Year}");
            sb.AppendLine($"Edad : {this.CalcularEdad()}");
            sb.AppendLine(this.EsMayorDeEdad());
            return sb.ToString();
        }

        private int CalcularEdad()
        {
            int anios;
            return anios = DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Year - 1;
        }

        public string EsMayorDeEdad()
        {
            int edad = this.CalcularEdad();
            if(edad < 18)
            {
                return "Es Menor";
            }
            return "Es mayor de edad";
        }
    }
}
