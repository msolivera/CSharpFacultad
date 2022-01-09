using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int suma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;

        }
        static int dividir(int numero1 , int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }
        static void Main(string[] args)
        {
            int numero1 = 12;
            int numero2 = 2;
            Console.WriteLine(suma(numero1, numero2));
            Console.WriteLine(dividir(numero1, numero2));
            Console.ReadKey();
             

        }
    }
}
