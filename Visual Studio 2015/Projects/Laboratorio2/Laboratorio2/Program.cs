using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa c1 = new Casa("8 de octubre 2601");
            DispositivoElectricoNoInteigenteConTemp dis1 = new DispositivoElectricoNoInteigenteConTemp("Horno", "James", 80);
            DispositivoElectronico dis2 = new DispositivoElectronico("Telefono", "panavox");
            TarjetaRed tarj = new TarjetaRed("192.164.0.1", "A1:64:8E:32");
            DispositivoInteligente dis3 = new DispositivoInteligente(tarj, "Smart TV", "Samsung");
            TarjetaRed tarj1 = new TarjetaRed("192.164.1.1", "A2:64:8E:32");
            DispositivoInteligenteConTemp dis4 = new DispositivoInteligenteConTemp(tarj1, "Aire Acondicionado", "James", 10);
            Luz luz1 = new Luz("Foco", "Lucesita", 300);
            LuzDimirizable luz2 = new LuzDimirizable("Foco", "Lucesita", 300);
            TarjetaRed tarj3 = new TarjetaRed("192.162.1.1", "A2:44:8E:32");
            LuzInteligente luz3 = new LuzInteligente(tarj3, "FOco", "Lucesita", 300);
            c1.ComprarDispositivo(dis1);
            c1.ComprarDispositivo(dis2);
            c1.ComprarDispositivoInteligente(dis3);
            c1.ComprarDispositivo(luz1);
            c1.ComprarDispositivo(luz2);
            c1.ComprarDispositivoInteligente(luz3);

            c1.MostrarFichas();
            dis1.Encender();
            c1.Apagon();
            c1.DesecharDispositivo(luz3);
            dis1.Encender();
            c1.ApagarUnDispositivo(dis1);
            dis3.Encender();
            c1.ApagarRemotamente();

            Console.ReadKey();
         

        }
    }
}
