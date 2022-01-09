using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Salon
    {
        public String profesor { get; set; }
        public List<Alumno> alumnos { get; set; }
        public readonly String nombre;

        public Salon (String nombre)
        {
            this.nombre = nombre;
            alumnos = new List<Alumno>();
        }
    }
}
