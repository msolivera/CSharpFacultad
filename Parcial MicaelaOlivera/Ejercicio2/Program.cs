using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Considere la clase Cocina. Critique el código en base a lo aprendido hasta ahora
            * en el curso y haga las modificaciones necesarias para solucionar los problemas encontrados.
            * Comente todos los cambios que realice.
            */

            Heladera hela = new Heladera("James");
            Horno horno = new Horno("Panavox");
            Cocinero cocinero = new Cocinero("Micaela");
            Cocina cocina = new Cocina();

            cocina.Cocinar("Papas al horno");//se intenta cocinar sin cocinero, heladera u horno
            cocina.prepararComida();

            cocina.cocinero = cocinero;
            cocina.heladera = hela;
            cocina.horno = horno;

            cocina.Cocinar("Milanesa");
            cocina.prepararComida();


            Console.ReadKey();
        }
    }
}
