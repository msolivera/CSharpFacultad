using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU c1 = new CPU("Intel", "Core 2 duo");
            DiscoDuro d1 = new DiscoDuro("Kingston", 500);
            SistemaOperativo s1 = new SistemaOperativo("Windows", "10", 30);
            MemoriaRAM m1 = new MemoriaRAM("Kingston","8gb");
            MemoriaRAM m2 = new MemoriaRAM("Corsair", "4gb");
            List<MemoriaRAM> listaMemoria = new List<MemoriaRAM>();
            listaMemoria.Add(m1);
            listaMemoria.Add(m2);
            Monitor moni = new Monitor("Samsung", "1920x1080");
            Mouse mo = new Mouse("MSI", 6);
            Teclado tecla = new Teclado("Xion", "Ingles");
            Computadora Comp1 = Local.CrearPc(listaMemoria, c1);
            Programa Minecraft = new Programa("Minecraft", "juego", 50);
            Programa AVG = new Programa("AVG", "Antivirus", 5);
            Comp1.instalarSO(s1);
            Comp1.AñadirDiscosDuros(d1);
            Comp1.instalarSO(s1);
            Comp1.AñadirMonitores(moni);
            Comp1.teclado = tecla;
            Comp1.mouse = mo;
            s1.InstalarPrograma(Minecraft);
            s1.InstalarPrograma(AVG);
            
            CPU c2 = new CPU("Inter", "Core i7");
            MemoriaRAM m3 = new MemoriaRAM("Kingston", "12 gb");
            List<MemoriaRAM> listaMemoria2 = new List<MemoriaRAM>();
            listaMemoria2.Add(m3);
            Computadora Comp2 = Local.CrearPc(listaMemoria2, c2);
            Console.ReadKey();
        }
    }
}
