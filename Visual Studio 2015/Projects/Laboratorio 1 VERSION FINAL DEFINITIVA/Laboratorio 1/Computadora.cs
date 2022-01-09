using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class Computadora
    {


        

        public CPU cpu;
        public List<DiscoDuro> discos;
        public List<MemoriaRAM> mRam;
        public List<Monitor> monitores;
        /// <summary>
        /// Get: Devuelve los valores asignados a un objeto Mouse.
        /// Set: Permite alterar los valores asignados a un objeto Mouse.
        /// </summary>
        public Mouse mouse { get; set; }
        public List<Programa> programas; 
        public List<SistemaOperativo> sistemasOperativos;
        /// <summary>
        /// Get: Devuelve los valores asignados a un objeto Teclado.
        /// Set: Permite alterar los valores asignados a un objeto Teclado.
        /// </summary>
        public Teclado teclado { get; set; }
        /// <summary>
        /// Get: Devuelve el valor asignado al estado de la computadora (Encendida o apagada).
        /// Set: Permite alterar el valor asignado al estado de la computadora.
        /// </summary>
        public string Estado { get; set; }
        /// <summary>
        /// Get: Devuelve la capacidad total (la suma de la capacidad de los discos duros) de la computadora.
        /// Set: Permite alterar la capacidad total de la computadora.
        /// </summary>
        public int capacidad { get; set; }
        public Computadora( CPU cpu, List<MemoriaRAM> mRam)
        {
            this.cpu = cpu;
            this.mRam = mRam;
            this.discos = new List < DiscoDuro >();
            this.monitores = new List<Monitor>();
            this.mouse = mouse;
            this.programas = new List<Programa>();
            this.sistemasOperativos = new List<SistemaOperativo>();
            this.teclado = teclado;
            this.Estado = "Apagada";
            Local.EliminarComponente(cpu);    
            foreach (MemoriaRAM memoria in mRam) 
            {
                Local.EliminarComponente(memoria);
            }
            
                   
        }
        
        ///<sumary>
        ///Añade un objeto memoria RAM a la lista de memorias RAM de un objeto computadora y lo elimina del inventario del local.
        ///</sumary>
        ///<param name="memoria">Corresponde a un objeto MemoriaRAM</param>
        public void AñadirMemoriaRam(MemoriaRAM memoria)
        {
            
            mRam.Add(memoria);
            Local.EliminarComponente(memoria);

        }
        /// <summary>
        /// Añade un objeto Disco Duro a la lista de discos duros de un objeto computadora y lo elimina del inventario del local.
        /// </summary>
        /// <param name="disco">Corresponde a un objeto DiscoDuro</param>
        public void AñadirDiscosDuros(DiscoDuro disco)
        {
            discos.Add(disco);
            this.capacidad += disco.capacidad;
            Local.EliminarComponente(disco);

        }
        /// <summary>
        /// Añade un objeto Monitor a la lista de monitores de un objeto computadora y lo elimina del inventario del local.
        /// </summary>
        /// <param name="monitor">Corresponde a un objeto Monitor</param>
        public void AñadirMonitores(Monitor monitor)
        {
            monitores.Add(monitor);
            Local.EliminarComponente(monitor);

        }

        /// <summary>
        /// Enciende la PC (Cambia su estado de apagado a encendido)
        /// </summary>
        public void PrenderPc()
        {
            if(this.Estado == "Apagada")
            {
                Console.WriteLine("Iniciando Sesion ...");
                Console.WriteLine("¡Sesión iniciada con éxito!");
                this.Estado = "Encendida";

            }

           
        }
        /// <summary>
        /// Apaga el PC (Cambia el estado de la computadora de encendido a apagado)
        /// </summary>
        public void ApagarPc()
        {
            if (this.Estado == "Encendida")
            {
                Console.WriteLine("Cerrando Sesion");
                this.Estado = "Apagada";

            }
        }
        /// <summary>
        /// Método para instalar un sistema operativo en un objeto Computadora (Agrega el objeto SO dado como parámetro a la lista de objetos SistemaOperativo dentro del objeto Computadora).
        /// </summary>
        /// <param name="so">Corresponde a un objeto Sistema Operativo</param>
        public void instalarSO(SistemaOperativo so)
        {
            if (this.capacidad >= so.peso && this.discos.Count > 0) 
            {
                if (this.Estado == "Encendida")
                {
                    this.sistemasOperativos.Add(so);
                    so.pcVinculada = this;
                    this.capacidad -= so.peso;
                    Local.EliminarComponente(so);
                }

            }
            else
            {
                Console.WriteLine("No hay suficiente espacio en el disco para instalar este sistema operativo");

            }
        }
        /// <summary>
        /// Despliega la ficha de un programa dado como parámetro que se encuentre instalado en el objeto Computadora, siempre y cuando la computadora esté encendida.
        /// </summary>
        /// <param name="programa">Corresponde a un objeto programa</param>
        public void EjecutarProgama(Programa programa)
        {
            foreach (Programa prog in programas)
            {
                if (this.Estado == "Encendida")
                {
                    if (programa == prog)
                    {
                        Console.WriteLine("Se esta ejecutando...  " + prog.Imprimir());
                    }
                    else
                    { Console.WriteLine("El programa: " + programa + " no se encuentra instalado en la Computadora"); }
                }
            }
        }
        /// <summary>
        /// Imprime los datos de todos los componentes (objetos monitor, mouse, disco duro, etc) dentro de un objeto computadora.
        /// </summary>
        public void Ficha()
        {

            Console.WriteLine("Ficha Tecnica: \n");
            Console.WriteLine("CPU: \n");
            Console.WriteLine(this.cpu.Imprimir()+"\n");
            Console.WriteLine("Discos duros:");
            foreach (DiscoDuro disco in this.discos)
            {
                Console.WriteLine(disco.Imprimir()+"\n");
            }
            Console.WriteLine("Memoria RAM: \n");
            foreach (MemoriaRAM ram in this.mRam)
            {
                Console.WriteLine(ram.Imprimir()+"\n");
            }
            Console.WriteLine("Monitor: \n");
            foreach (Monitor monitor in monitores)
            {
                Console.WriteLine(monitor.Imprimir()+"\n");
            }
            if (!(this.mouse == null))
            {
                Console.WriteLine("Mouse: " + this.mouse.Imprimir() + "\n");
            }
            Console.WriteLine("Programas: \n");
            foreach (Programa prog in programas)
            {
                Console.WriteLine(prog.Imprimir() + "\n");
            }
            Console.WriteLine("Sistema Operativo: \n");
            foreach (SistemaOperativo sistema in sistemasOperativos)
            {
                Console.WriteLine(sistema.Imprimir() + "\n");
            }
            if (!(this.teclado == null))
            {
                Console.WriteLine("Teclado: " + this.teclado.Imprimir());
            }
        }
            
    }
}
