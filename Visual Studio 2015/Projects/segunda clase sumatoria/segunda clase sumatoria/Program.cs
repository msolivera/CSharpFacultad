using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segunda_clase_sumatoria
{
    class Program
    {

        static int Sumatoria()

        {
            Console.WriteLine("SUMARIA \n Ingrese valores a sumar: \n");
            string res = Console.ReadLine();

            while (res != "x")
            {

                int numero = Convert.ToInt32(res);

                int resultado = numero;
                int resultado2 = resultado + numero;

            }
            if (res == "x")
                {
                    Console.WriteLine("FIN :)");
                   }
            return resultado2; //corregir
        }


            static void Main(string[] args)
        {
                Console.WriteLine(Sumatoria());

            }


        }

    }
