using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenar_empleados_de__empresa
{
    class Empleado
    {
        public readonly String nombre;
        public readonly Int32 cedula;
        public Int32 edad { get; set; }
        public readonly String sexo;

        public Empleado (String nombre, Int32 cedula, Int32 edad, String sexo)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.edad = edad;
            this.sexo = sexo;
        }

        public void Curriculum()
        {
            Console.WriteLine("Datos personales:");
            Console.WriteLine("Nombre: "  + this.nombre+ "\n" + " CI: "+this.cedula+ "\n" + " Edad: "+this.edad+ "\n" + " Sexo: " +this.sexo+"\n");
        }
    }
}
