using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tercera_clase_Clase_alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("Micaela", "Olivera");
            Alumno a2 = new Alumno("Juan", "Perez");
            Console.WriteLine(a1.GetNombre());
            Console.WriteLine(a2.GetApellido());
            a1.SetNombre("Manuel");
            Console.WriteLine(a1.GetNombre()+" "+ a1.GetApellido());
            Console.ReadKey();
        }
    }
}
