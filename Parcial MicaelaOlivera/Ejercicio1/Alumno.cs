using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Alumno
    {
        public readonly String nombre;
        public readonly String apellido;

        public Alumno (String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
