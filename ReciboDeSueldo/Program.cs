using System;

namespace ReciboDeSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado pepito;
            bool seguir = true;
            string nombre;
            int aniosAntiguedad;
            double valorHora;
            int horasTrabajadas;

            do
            {
                pepito = new Empleado();
                Console.WriteLine("ingrese valor hora: ");
                while (!double.TryParse(Console.ReadLine(), out valorHora))
                {

                    Console.WriteLine("ERROR... reingrese valor hora");
                }
                Console.WriteLine("ingrese nombre empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese anios antiguedad: ");
                while (!int.TryParse(Console.ReadLine(), out aniosAntiguedad))
                {

                    Console.WriteLine("ERROR... reingrese antiguedad");
                }
                Console.WriteLine("ingrese horas trabajadas: ");
                while (!int.TryParse(Console.ReadLine(), out horasTrabajadas))
                {

                    Console.WriteLine("ERROR... reingrese horas trabajadas");
                }
                pepito = new Empleado(nombre, aniosAntiguedad, valorHora, horasTrabajadas);
                seguir = Empleado.seguirIngresando();

            } while (seguir);

            pepito.mostrarRecibo();
            Console.ReadKey();
            
        }
    }

    public class Empleado
    {
        private string nombre;
        private int aniosAntiguedad;
        private double valorHora;
        private int horasTrabajadas;

        public Empleado()
        {

        }

        public Empleado(string nombre, int aniosAntiguedad, double valorHora, int horasTrabajadas)
        {
            this.nombre = nombre;
            this.aniosAntiguedad = aniosAntiguedad;
            this.valorHora = valorHora;
            this.horasTrabajadas = horasTrabajadas;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getAntiguedad()
        {
            return this.aniosAntiguedad;
        }

        public double getValorHora()
        {
            return this.valorHora;
        }

        public int getHsTrabajadas()
        {
            return this.horasTrabajadas;
        }

        public double multiplicarHoras()
        {
            return this.valorHora * this.horasTrabajadas;
        }

        public double aplicarAntiguedad()
        {
            return this.aniosAntiguedad * 150;
        }

        public double calcularBruto()
        {
            double calculoHoras = this.multiplicarHoras();
            double calculoAniguedad = this.aplicarAntiguedad();
            return calculoHoras + calculoAniguedad;
        }

        public double aplicarDescuento()
        {
            return this.calcularBruto() - this.calcularBruto() * 0.13;
        }

        public void mostrarRecibo()
        {
            Console.WriteLine("Nombre {0}", this.nombre);
            Console.WriteLine("Antiguedad {0} X 150 -  {1}", this.aniosAntiguedad, this.aplicarAntiguedad());
            Console.WriteLine("Valor hora {0} X {1} Horas trabajadas -  {2}", this.valorHora, this.horasTrabajadas, this.multiplicarHoras() );
            Console.WriteLine("Sueldo Bruto {0}", this.calcularBruto());
            Console.WriteLine("Sueldo Neto a cobrar {0}", this.aplicarDescuento());

        }


        public static bool seguirIngresando()
        {
            Console.WriteLine("Desea ingresar nuevo empleado (si o no): ");
            if (Console.ReadLine().ToLower() == "si")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
