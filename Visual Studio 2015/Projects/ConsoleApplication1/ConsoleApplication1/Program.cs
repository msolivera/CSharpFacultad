using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void  Main(string[] args)
            {
                string nombre;
             int edad;
               nombre = "Micaela";
            edad = 23;
            Console.WriteLine("Hola mi nombre es " + nombre +" y tengo " + edad+" años");
            Console.ReadKey();


            int i = 0;
            while (i < 10)
            { if (i % 2 == 0)
                 { Console.WriteLine(i+"Es par");
                }
             else
               {
                  Console.WriteLine(i+ "Es Impar");
                      }
            i++;

               }
             Console.ReadKey();
                

        }
    }
}
