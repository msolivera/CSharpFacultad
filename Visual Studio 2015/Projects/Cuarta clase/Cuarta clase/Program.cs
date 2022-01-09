using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuarta_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            string n = a.nombre;
            a.nombre = "Fede";
        }
    }
}
