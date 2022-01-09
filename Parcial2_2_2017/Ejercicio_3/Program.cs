using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Calculadora
    {
        private Boolean EsNumerico(String valor)
        {
            int n;
            return int.TryParse(valor, out n);
        }

        public Double Dividir(String a, String b)
        {
            if ((a == null) || (b == null))
            {
                throw new ParametroNuloException("Los parámetros no pueden ser nulos.");
            }
            else
            {
                if ((!EsNumerico(a)) || (!EsNumerico(b)))
                {
                    throw new ParametroNoNumericoException("Los valores deben ser numericos.");
                }
                else
                {
                    Double db = Double.Parse(b);
                    if (db == 0)
                    {
                        throw new DividirPorCeroException("No se puede dividir por cero.");
                    }
                    else
                    {
                        Double da = Double.Parse(a);
                        return da / db;
                    }
                }
                    
             }
             return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* *
             * Genere excepciones propias en los siguientes casos:
             * 1- los parámetros son nulos.
             * 2- los parámetros no son numéricos.
             * 3- Se intenta dividir por cero.
             * 
             * Haga los cambios pertinentes en la clase Calculadora y muestre como se 
             * controlarían las excepciones generadas en el método Main del Program.
             * 
             * */

            Calculadora c = new Calculadora();
            try
            {
                Console.WriteLine(c.Dividir("hola","4"));


            }
            catch( ParametroNoNumericoException ex1)
            {
                Console.WriteLine(ex1.ToString());
            }
            catch (ParametroNuloException ex2)
            {
                Console.WriteLine(ex2.ToString());
            }
            catch (DividirPorCeroException ex3)
            {
                Console.WriteLine(ex3.ToString());
            }

            Console.ReadKey();



        }
    }
}
