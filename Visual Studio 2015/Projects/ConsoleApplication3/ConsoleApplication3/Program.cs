using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    
    class Program
    {
        static int Factorial(int numero)
        {
            if (numero == 0) 
            { return 1;
            }
       
           else {
                return Factorial(numero - 1) * numero;

            }

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.ReadKey();
        }
    }
}

