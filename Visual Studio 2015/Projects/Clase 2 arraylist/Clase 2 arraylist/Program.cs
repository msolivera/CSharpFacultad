using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2_arraylist
{
    class Program
    {

        static string Variable(string variable)
        {
            ArrayList lista2 = new ArrayList();

            lista2.Add("m");
            lista2.Add("m");
            lista2.Add("1");
            lista2.Add("2");
            lista2.Add("3");
            lista2.Add("4");
            lista2.Add("5");
            lista2.Add("6");

            int contador = 0;
            int i = 0;
            for (i = 0; i < lista2.Count; i++)
            {
                if (lista2[i].ToString() == variable.ToString())
                contador = contador + 1;

            }
            return contador.ToString();

        }

        static string Eliminar (string variable_a_eliminar)
        {
            ArrayList lista3 = new ArrayList();

            lista3.Add("1");
            lista3.Add("1");
            lista3.Add("1");
            lista3.Add("2");
            lista3.Add("3");
            lista3.Add("4");
            lista3.Add("5");
            lista3.Add("6");

            string resultado3 = "";
            int i = 0;
            for (i = 0; i < lista3.Count; i++)
            {
                if (lista3[i].ToString() == variable_a_eliminar.ToString())
                    lista3.Remove(i);
                else
                {
                    resultado3 = resultado3 + lista3[i].ToString();
                }

            }
           
            
            return resultado3;

        }

        /*static string Capicua(string cadena)
        {
            ArrayList lista4 = new ArrayList();

            lista4.Add("que");
            lista4.Add("reconocer");
            lista4.Add("seres");

           
            foreach ( var elemento in lista4)
            {
             if (lista4 [elemento] ==  
                  
            }  
                 
        }*/
        




        static void Main(string[] args)
        {
            
                ArrayList lista1 = new ArrayList();

                lista1.Add("M");
                lista1.Add("i");
                lista1.Add("c");
                lista1.Add("a");

                string resultado = "";
                int i = 0;
                for (i = 0; i < lista1.Count; i++)
                {

                    resultado = resultado + lista1[i].ToString();
                }

                // si quiero transformar de string a int int h = Convert.ToInt32(lista1[i].ToString());

                Console.WriteLine(resultado);
                Console.WriteLine(Variable("m"));
                Console.WriteLine(Eliminar("1"));
                Console.ReadKey();
                
        }
    }
}
