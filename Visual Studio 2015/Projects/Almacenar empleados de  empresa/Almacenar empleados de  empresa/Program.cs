using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenar_empleados_de__empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realiza un programa capaz de almacenar empleados dentro de una empresa.Los empleados deberán tener una
cédula, edad y sexo (“M” o “F”) y la empresa deberá poder almacenarlos y realizar varias operaciones sobre los
mismos.Dichas operaciones son:
            -Cantidad total de empleados.
           - Cantidad de empleados por sexo, junto con el porcentaje sobre el total.
-Promedio de edades de todos los empleados.
-Promedios de edades discriminados por sexo.
La información de los empleados se cargará mediante un archivo provisto en la webasignatura.
Desarrollar las interfaces, clases y programa principal que lea el archivo, instancie la empresa, cargue los
empleados(contenidos en el archivo) y luego emita por consola los datos solicitados.*/

            Empleado e1 = new Empleado("Micaela", 52304220,23, "F");
            Empleado e2 = new Empleado("Jorge", 43658552, 27, "M");
            Empleado e3 = new Empleado("Pedro", 43468952, 25, "M");

            Empresa empre = new Empresa("NetPc");
            empre.AñadirEmpleado(e1);
            empre.AñadirEmpleado(e2);
            empre.AñadirEmpleado(e3);

            empre.ContarEmpleados();
            empre.ContarEmpleadoPorSexo("M");
            empre.Promedio();
            empre.PromedioPorSexo("F");
            empre.CurriculumDeEmpleados();

            Console.ReadKey();
        }

    }
}
