using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class Local
    {
        public static Int32 Id = 0;
        public static ArrayList inventario = new ArrayList();
        public static List<Computadora> inventarioComputadoras = new List<Computadora>();
        /// <summary>
        /// Asigna un valor ID único para cada instancia de un objeto creado que se añade al inventario del Local.
        /// </summary>
        /// <returns>Devuelve un valor de ID único.</returns>
        public static Int32 DarId()
        {
            Id++;
            return Id;
        }
        /// <summary>
        /// Añade un objeto creado a la lista del inventario del Local.
        /// </summary>
        /// <param name="componente">Corresponde a un objeto de cualquier tipo.</param>
        public static void AñadirComponente(Object componente)
        {
            inventario.Add(componente);
        }
        /// <summary>
        /// Elimina un objeto de cualquier tipo de la lista del inventario del Local.
        /// </summary>
        /// <param name="ComponenteABorrar"> Corresponde a un objeto de cualquier tipo.</param>
        public static void EliminarComponente(Object ComponenteABorrar)
        {
            inventario.Remove(ComponenteABorrar);
        }
        /// <summary>
        /// Crea una instancia de la clase Computadora dada una lista de objetos memoria RAM y un objeto CPU.
        /// </summary>
        /// <param name="mRam">Corresponde a una lista de objetos memoria RAM. </param>
        /// <param name="cpu">Corresponde a un objeto CPU. </param>
        /// <returns> Devuelve un objeto Computadora.</returns>
        public static Computadora CrearPc(List<MemoriaRAM> mRam, CPU cpu)
        {
            Computadora pc = new Computadora(cpu, mRam);
            inventarioComputadoras.Add(pc);
            return pc;
        }
        
        /// <summary>
        /// Imprime todos los objetos Computadora con sus respectivos atributos pertenecientes al inventario del local.
        /// </summary>
        public static void FichaInventarioPC()
        {
            foreach (Computadora pc in inventarioComputadoras)
            {
                pc.Ficha();
            }
        
        }
    }
}