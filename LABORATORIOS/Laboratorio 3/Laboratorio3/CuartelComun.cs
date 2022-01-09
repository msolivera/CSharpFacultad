using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class CuartelComun : Edificio, IProduccionTropas
    {
        public CuartelComun(String nombre, Int32 vida, Int32 lvl, Int32 coste) : base(nombre, vida, lvl, coste)
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
                case "Barbaro":
                    Tropa barbaro = new Barbaro();
                    A1.Tropas.Add(barbaro);
                    break;

                case "Arquera":
                    Tropa arquera = new Arquera("Arquera", 78, 1, 20, 18, 1, 25);
                    A1.Tropas.Add(arquera);
                    break;

                case "Gigante":
                    Tropa gigante = new Gigante("Gigante", 48, 1, 12, 24, 5, 250);
                    A1.Tropas.Add(gigante);
                    break;

                case "Mago":
                    Tropa mago = new Mago ("Mago", 130, 1, 16, 125, 4, 1500);
                    A1.Tropas.Add(mago);
                    break; 

                case "Duende":
                    Tropa duende = new Duende("Duende", 43, 1, 32, 48, 1, 25);
                    A1.Tropas.Add(duende);
                    break;

                case "Globo Bombastico":
                    Tropa globo = new Globo("Globo Bombastico", 280, 1, 10, 72, 5, 2000);
                    A1.Tropas.Add(globo);
                    break;

                case "P.E.K.K.A":
                    Tropa pekka = new PEKKA("P.E.K.K.A.", 3500, 1, 16, 310, 25, 2800);
                    A1.Tropas.Add(pekka);
                    break;

                case "Dragon":
                    Tropa dragon = new Dragon("Dragon", 2300, 1, 16, 180, 10, 7500);
                    A1.Tropas.Add(dragon);
                    break;

                case "Esqueleto":
                    Tropa esqueleto = new Esqueleto("Esqueleto", 35, 1, 24, 32, 2, 100);
                    A1.Tropas.Add(esqueleto);
                    break;

                case "Curandera":
                    Tropa curandera = new Curandera("Curandera", 840, 1, 16, 55, 14, 5000);
                    A1.Tropas.Add(curandera);
                    break;

                case "Dragon bebe":
                    Tropa dragonBebe = new DragonBebe("Dragon Bebe", 1400, 1, 16, 95, 10, 1500);
                    A1.Tropas.Add(dragonBebe);
                    break;

                case "Minero":
                    Tropa minero = new Minero("Minero", 670, 1, 24, 96, 5, 4000);
                    A1.Tropas.Add(minero);
                    break;

                default:
                    break;

            }
            
            
        }
    }
}
            
