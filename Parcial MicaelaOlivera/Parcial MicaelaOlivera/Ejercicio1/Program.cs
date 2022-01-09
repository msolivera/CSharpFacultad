using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Modifique el código de este proyecto para que:
             * - La clase Salon y Alumno cumplan con el principio de encapsulación.
             * - La clase Alumno quede inmutable.
             * - En el método Main de la clase Program, brindar un ejemplo de igualdad y un ejemplo de identidad.
             */

            Salon s1 = new Salon("Laboratorio de Quimica");
            Salon s2 = new Salon("Laboratorio de Quimica");
            s1 = s2;

            Alumno a1 = new Alumno("Pablo","Perez");
            Alumno a2 = new Alumno("Pablo", "Perez");


        }
    }
}
