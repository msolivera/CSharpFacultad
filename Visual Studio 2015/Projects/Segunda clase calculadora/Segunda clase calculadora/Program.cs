using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_clase_calculadora
{
    class Program
    {

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1 - Sumar");
                Console.WriteLine("2 - Restar");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplica");
                Console.WriteLine("-----------------");
                Console.WriteLine("s -Salir \n");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case ("1"):
                        Console.WriteLine("Ingrese numero a");
                        string a = Console.ReadLine();
                        int c = Convert.ToInt32(a);
                        Console.WriteLine("Ingrese numero b");
                        string b = Console.ReadLine();
                        int d = Convert.ToInt32(b);
                        Console.WriteLine("El resultado es: " + (c + d) + "\n");
                        break;


                    case ("2"):
                        Console.WriteLine("Ingrese numero a");
                        string e = Console.ReadLine();
                        int g = Convert.ToInt32(e);
                        Console.WriteLine("Ingrese numero b");
                        string f = Console.ReadLine();
                        int h = Convert.ToInt32(f);
                        Console.WriteLine("El resultado es: " + (g - h) + "\n");
                        break;

                    case ("3"):
                        Console.WriteLine("Ingrese numero a");
                        string i = Console.ReadLine();
                        int  k= Convert.ToInt32(i);
                        Console.WriteLine("Ingrese numero b");
                        string j = Console.ReadLine();
                        int m = Convert.ToInt32(j);
                        Console.WriteLine("El resultado es: " + (k / m) + "\n");
                        break;


                    case ("4"):
                        Console.WriteLine("Ingrese numero a");
                        string n = Console.ReadLine();
                        int o = Convert.ToInt32(n);
                        Console.WriteLine("Ingrese numero b");
                        string ñ = Console.ReadLine();
                        int p = Convert.ToInt32(ñ);
                        Console.WriteLine("El resultado es: " + (o * p) + "\n");
                        break;

                    case ("s"):
                        salir = true;
                        Console.WriteLine("Ha finalizado el programa");
                        Console.ReadKey();
                        break;

                    default:

                        Console.WriteLine("Comando Desconocido \n");
                        break;


                }












            }
        }

    }
}  

