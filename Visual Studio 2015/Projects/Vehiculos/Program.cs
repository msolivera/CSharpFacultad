using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo ferrari = new Vehiculo("Ferrari");
            ferrari.Matricula = "AAA-1234";


            Console.WriteLine("El ferrari va a recorrer 200Km");
            ferrari.Recorrer(200);
            Console.WriteLine("El Ferrari ha recorrido :" + ferrari.Kilometraje + "kms");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("El ferrari va a recorrer 300Km");
            ferrari.Recorrer(300);
            Console.WriteLine("El Ferrari ha recorrido :" + ferrari.Kilometraje + "kms");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("El ferrari va a recorrer 400Km");
            ferrari.Recorrer(400);
            Console.WriteLine("El Ferrari ha recorrido :" + ferrari.Kilometraje + "kms");
            Console.ReadKey();
        }
    }
}
