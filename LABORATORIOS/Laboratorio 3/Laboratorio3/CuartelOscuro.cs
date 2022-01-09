using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class CuartelOscuro : Edificio, IProduccionTropas
    {
        public CuartelOscuro(String nombre, Int32 vida, Int32 lvl, Int32 coste) : base(nombre, vida, lvl, coste)
        { }
        /// <summary>
        /// Crea una tropa segun el parametro recibido
        /// </summary>
        /// <param name="nombre">Nombre de la unidad a crear</param>
        public void CrearTropa(String nombre)
        {
            Aldea A1 = Aldea.GetInstancia();

            switch (nombre)
            {
                case "Esbirro":
                    Tropa esbirro = new Esbirro("Esbirro", 72, 1, 32, 46, 2, 6);
                    A1.Tropas.Add(esbirro);
                    break;

                case "Montapuercos":
                    Tropa monta = new Montapuerco("Montapuercos", 415, 1, 24, 92, 5, 40);
                    A1.Tropas.Add(monta);
                    break;

                case "Valquiria":
                    Tropa valquiria = new Valquiria("Valquiria", 850, 1, 24, 119, 8, 70);
                    A1.Tropas.Add(valquiria);
                    break;

                case "Golem":
                    Tropa golem = new Golem("Golem", 6000, 1, 12, 50, 30, 450);
                    A1.Tropas.Add(golem);
                    break;

                case "Bruja":
                    Tropa bruja = new Bruja("Bruja", 300, 1, 12, 60, 12, 250);
                    A1.Tropas.Add(bruja);
                    break;

                case "Sabueaso de lava":
                    Tropa lava = new SabuesoLava("Sabueso de lava", 6700, 30, 24, 14, 8, 390);
                    A1.Tropas.Add(lava);
                    break;

                case "Lanzarocas":
                    Tropa lanzaroca = new Lanzarrocas("Lanzarocas", 350, 1, 14, 85, 6, 130);
                    A1.Tropas.Add(lanzaroca);
                    break;

                default:
                    break;
            }
        }

    }
}

