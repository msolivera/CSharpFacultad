using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenar_empleados_de__empresa
{
    class Empresa
    {
        private String nombreEmpresa { get; set; }
        public List<Empleado> empleados { get; set; }

        public Empresa (String nombreEmpresa)
        {
            this.nombreEmpresa = nombreEmpresa;
            empleados = new List<Empleado>();
        }

        public void AñadirEmpleado (Empleado empleado)
        {
            empleados.Add(empleado);
        }
        public void ContarEmpleados()
        {
            Console.WriteLine(empleados.Count());
        }

        public void ContarEmpleadoPorSexo(String sexoDado)
        {
            int contador = 0;
            int resultado = 0;
            int totalEmpleados = empleados.Count();
            foreach (Empleado empleado in empleados)
            {
                if (empleado.sexo == sexoDado)
                {
                    contador += 1;
                    
                }
                
            }
            resultado = (contador*100 /totalEmpleados);
            Console.WriteLine("Cantidad de empleados del sexo "+sexoDado+":" +contador+" Porcentaje: "+resultado+"%");
        }

        public void Promedio ()
        {
            int total = 0;
            int contador = 0;
            int resultado = 0;
            foreach (Empleado empleado in empleados)
            {
                total = empleado.edad + total;
                contador++;

            }
            resultado = total / contador;
            Console.WriteLine(resultado); 

        }

        public void PromedioPorSexo(String sexoDado)
        {
            int contadorEdades = 0;
            int resultado = 0;
            int totalEmpleados = 0;
            foreach (Empleado empleado in empleados)
            {
                if (empleado.sexo == sexoDado)
                {
                    totalEmpleados += 1;
                    contadorEdades = empleado.edad + contadorEdades;

                }

            }
            resultado = (contadorEdades/totalEmpleados);
            Console.WriteLine("Cantidad de empledados del sexo "+sexoDado+":"+totalEmpleados+" Promedio de edad: "+resultado);

        }
        public void CurriculumDeEmpleados()
        {
            Console.WriteLine("Curriculums de Empleados de " + this.nombreEmpresa + ":\n");
            foreach (Empleado e in empleados)
            {
               
                e.Curriculum();
            }
        }
    }
}
