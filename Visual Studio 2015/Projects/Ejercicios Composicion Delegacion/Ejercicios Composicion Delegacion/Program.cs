using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Composicion_Delegacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular c1 = new Celular("Xiaomi", "Redmi Note 4", "Dorado");
            Display d1 = new Display();
            SIM s1 = new SIM("Antel", 091418533);
            SistemaOperativo so = new SistemaOperativo("Android", "6.0");
            c1.display = d1;
            c1.sim = s1;
            c1.Prender();
            c1.sistemaOperativo = so;
            //c1.InstalarSistemaOperativo(so);
            
            c1.MostrarEnPantalla("Hola Mundo");
            c1.AcercaDelDispositivo();
            c1.Llamar(098302262);
            c1.MandarMensaje("Hola como estas?", 099678759);
            c1.Llamar(099576315);
            c1.Apagar();

            Console.ReadKey();
        }


    }
}
