using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Vehiculo
{
    class Calculadora
    {
        private string Color { get; set; }
        public Calculadora ( string color)
        {
            this.Color = color;

        }

        public void Sumar(int a,int b)
        {
            Console.WriteLine("El resultado de la Calculadora "+ Color+" es: "+(a+b) +"\n");
            
        }
        public void Restar(int a, int b)
        {
            Console.WriteLine("El resultado de la Calculadora " + Color + " es: " + (a - b) + "\n");

        }
        public void Multiplicar(int a, int b)
        {
            Console.WriteLine("El resultado de la Calculadora " + Color + " es: " + (a * b) + "\n");

        }
        public void Dividir(int a, int b)
        {
            Console.WriteLine("El resultado de la Calculadora " + Color + " es: " + (a / b) + "\n");

        }
        public static void Suma(int a, int b,string color)
        {
            Console.WriteLine("El resultado de la Calculadora " + color + " es: " + (a + b) + "\n");

        }
        public static void Resta(int a, int b,string color)
        {
            Console.WriteLine("El resultado de la Calculadora " + color + " es: " + (a - b) + "\n");

        }
        public static void Multiplica(int a, int b, string color)
        {
            Console.WriteLine("El resultado de la Calculadora " + color + " es: " + (a * b) + "\n");

        }
        public static void Divide(int a, int b, string color)
        {
            Console.WriteLine("El resultado de la Calculadora " + color + " es: " + (a / b) + "\n");

        }

    }
}
