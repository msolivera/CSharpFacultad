using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Aldea
    {
        private static Aldea instancia = null;
        public String Nombre { get; set; }
        public List<IRecolector> Recolectores { get; set; }
        public CastilloDeClan CastilloClan { get; set; }
        public Ayuntamiento Ayuntamiento { get; set; }
        public List<Campamento> Campamento { get; set; }
        public List<Defensa> Defensas { get; set; }
        public List<Tropa> Tropas { get; set; }
        public List<Almacen> Almacenes { get; set; }
        public List<CuartelComun> Cuarteles { get; set; }
        public List<CuartelOscuro> CuartelesO { get; set; }
        public List<Edificio> ListEdificios { get; set; }

        public Int32 OroMaximo { get; set; }
        public Int32 OroActual { get; set; }
        public Int32 ElixirRojoMaximo { get; set; }
        public Int32 ElixirRojoActual { get; set; }
        public Int32 ElixirNegroMaximo { get; set; }
        public Int32 ElixirNegroActual { get; set; }

        public Int32 CapacidadTotalTropas { get; set; }

        private Aldea()
        {
            Ayuntamiento = new Ayuntamiento("Ayuntamiento", 3200, 11, 0);
            ElixirNegroMaximo = this.ObtenerElixirOscuroMaximo();
            ElixirRojoMaximo = this.ObtenerElixirRojoMaximo();
            OroMaximo = this.ObtenerOroMaximo();
            ElixirRojoActual = this.ObtenerElixirRojoActual();
            OroActual = this.ObtenerOroActual();
            ElixirNegroActual = this.ObtenerElixirOscuroActual();
            ListEdificios = new List<Edificio>();
            Defensas = new List<Defensa>();
            Tropas = new List<Tropa>();
            Almacenes = new List<Almacen>();
            Campamento = new List<Campamento>();
            Recolectores = new List<IRecolector>();
            Cuarteles = new List<CuartelComun>();
            CuartelesO = new List<CuartelOscuro>();



        }
        public static Aldea GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Aldea();
            }
            return instancia;
        }
        /// <summary>
        /// Recorre la lista de recolectores, llevando cuenta de los que son de oro
        /// </summary>
        /// <returns>Cantidad de recolectores de oro</returns>
        public Int32 ObtenerRecolectoresOro()
        {

            Int32 contador = 0;
            foreach (IRecolector Rec in this.Recolectores)
            {
                if (Rec is RecolectorOro)
                {
                    contador += 1;
                }

            }
            return contador;
        }
        /// <summary>
        /// Recorre la lista de recolectores, llevando cuenta de los que son de Elixir Rojo
        /// </summary>
        /// <returns>Cantidad de recolectores de Elixir rojo</returns>
        public Int32 ObtenerRecolectoresElixirRojo()
        {

            Int32 contador2 = 0;
            foreach (IRecolector Rec in this.Recolectores)
            {
                if (Rec is RecolectorElixirRojo)
                {
                    contador2 += 1;
                }

            }
            return contador2;
        }
        /// <summary>
        /// Recorre la lista de recolectores, llevando cuenta de los que son de Elixir Oscuro
        /// </summary>
        /// <returns>Cantidad de recolectores de elixir oscuro/returns>
        public Int32 ObtenerRecolectoresElixirNegro()
        {

            Int32 contador3 = 0;
            foreach (IRecolector Rec in this.Recolectores)
            {
                if (Rec is RecolectorElixirOscuro)
                {
                    contador3 += 1;
                }

            }
            return contador3;
        }
        /// <summary>
        /// Obtiene la suma de oro total de todos los almacenes existentes, castillo y ayuntamiento
        /// </summary>
        /// <returns>Oro maximo de la aldea</returns>
        public Int32 ObtenerOroMaximo()
        {
            Int32 OroMaximo = 0;
            OroMaximo = Ayuntamiento.CapacidadMaximaOro;
            if (!(Almacenes == null))
            {
                foreach (Almacen almacen in this.Almacenes)
                {
                    if (almacen is AlmacenOro)
                    {
                        OroMaximo += almacen.CapacidadMaxima;
                    }
                }

            }
            if (!(this.CastilloClan == null))
            {
                OroMaximo += this.CastilloClan.CapacidadOro;
            }
            return OroMaximo;
        }
        /// <summary>
        /// Devuelve la suma de oro existente en los lugares que se almacena
        /// </summary>
        /// <returns>Oro actual de la aldea</returns>
        public Int32 ObtenerOroActual()
        {
            Int32 OroActual1 = 0;
            OroActual1 = this.Ayuntamiento.CantidadOroActual;
            if (!(Almacenes == null))
            {
                foreach (Almacen almacen in this.Almacenes)
                {
                    if (almacen is AlmacenOro)
                    {
                        OroActual1 += almacen.CantidadActual;
                    }
                }
            }
            if (!(this.CastilloClan == null))
            {
                OroActual1 += this.CastilloClan.CantidadOroActual;
            }
            return OroActual1;
        }
        /// <summary>
        /// Devuelve la cantidad maxima almacenable, de elixir rojo, por los edificios de la aldea
        /// </summary>
        /// <returns>Cantidad maxima de elixir rojo almacenable </returns>
        public Int32 ObtenerElixirRojoMaximo()
        {

            Int32 ElixirRojoMaximo1 = 0;
            ElixirRojoMaximo1 = this.Ayuntamiento.CapacidadMaximaElixirRojo;
            if (!(Almacenes == null))
            {
                foreach (Almacen almacen in this.Almacenes)
                {
                    if (almacen is AlmacenElixirRojo)
                    {
                        ElixirRojoMaximo1 += almacen.CapacidadMaxima;
                    }
                }
            }
            if (!(this.CastilloClan == null))
            {
                ElixirRojoMaximo1 += this.CastilloClan.CapacidadElixirRojo;
            }
            return ElixirRojoMaximo1;
        }
        /// <summary>
        ///Obtiene la suma de elixir rojo actual en los edificios que la almacenan en la aldea
        /// </summary>
        /// <returns>Elixir rojo actual en la aldea</returns>
        public Int32 ObtenerElixirRojoActual()
        {
            Int32 ElixirActual = 0;
            ElixirActual = this.Ayuntamiento.CantidadElixirRojoActual;
            if (!(Almacenes == null))
            {
                foreach (Almacen almacen in this.Almacenes)
                {
                    if (almacen is AlmacenElixirRojo)
                    {
                        ElixirActual = ElixirActual + almacen.CantidadActual;
                    }
                }
            }
            if (!(this.CastilloClan == null))
            {
                ElixirActual += this.CastilloClan.CantidadElixirActual;
            }
            return ElixirActual;
        }
        /// <summary>
        /// Obtiene la suma de elixir oscuro maximo almacenable en la aldea
        /// </summary>
        /// <returns>Elixir oscuo maximo de la aldea</returns>
        public Int32 ObtenerElixirOscuroMaximo()
        {

            Int32 ElixirNegroMaximo = 0;
            if (!(Almacenes == null))
            {
                foreach (Almacen almacen in this.Almacenes)
                {
                    if (almacen is AlmacenElixirOscuro)
                    {
                        ElixirNegroMaximo += almacen.CapacidadMaxima;
                    }
                }
            }
            if (!(this.CastilloClan == null))
            {
                ElixirNegroMaximo += this.CastilloClan.CapacidadElixirNegro;
            }

            return ElixirNegroMaximo;
        }
    
        /// <summary>
        /// Obtiene la cantidad de elixir oscuro actual en c/u de los edificios
        /// </summary>
        /// <returns> Elixir oscuro actual </returns>
        public Int32 ObtenerElixirOscuroActual()
        {
            Int32 ElixirOActual = 0;
            if (!(Almacenes == null))
            {
                foreach (Almacen almacen in this.Almacenes)
                {
                    if (almacen is AlmacenElixirOscuro)
                    {
                        ElixirOActual = ElixirOActual+ almacen.CantidadActual;
                    }
                }
            }
            if (!(this.CastilloClan == null))
            {
                ElixirOActual = ElixirOActual + this.CastilloClan.CantidadElixirNegroActual;
            }
            return ElixirOActual;
        }
        /// <summary>
        /// Obtiene la cantidad maxima de tropas almacenables
        /// </summary>
        /// <returns>Cantidad maxima de tropas almacenables</returns>
        public Int32 ObtenerCapacidadMaximaTropas()
        {
            Int32 TropasMaximo = 0;
            TropasMaximo += Ayuntamiento.MaximoDeTropas;

            if (!(Campamento == null))
            {
                foreach (Campamento campamento in this.Campamento)
                {
                    TropasMaximo += campamento.CapacidadMaxima;
                }
            }
            if (!(this.CastilloClan == null))
            {
                TropasMaximo += this.CastilloClan.CapacidadMaximaTropas;
            }
            return TropasMaximo;
        }
        /// <summary>
        /// Obtiene la capacidad de espacio actual de tropas en la aldea
        /// </summary>
        /// <returns>espacio ocupado por tropas</returns>
        public Int32 ObtenerCapacidadActualTropas()
        {
            Int32 TropasActual = 0;
            foreach (Tropa tropa in Tropas)
            {
                TropasActual += tropa.EspacioEnCampamento;

            }
            return TropasActual;
        }


        /// <summary>
        /// ordena el oro recibido por parametro, distribuyendolo primero en ayuntamiento, luego en castillo y en almacenes
        /// </summary>
        /// <param name="Oro"> oro a ordenar</param>
        /// <returns>Oro total de la aldea</returns>
        public Int32 RestructurarOro(Int32 Oro)
        {
            Int32 OroAldea = 0;
            OroAldea = this.OroActual + Oro;
            this.Ayuntamiento.CantidadOroActual = 0;
            if (OroAldea <= this.Ayuntamiento.CapacidadMaximaOro)
            {
                this.Ayuntamiento.CantidadOroActual = OroAldea;
                return OroAldea;
            }
            else
            {
                Int32 OroRestante = OroAldea - this.Ayuntamiento.CapacidadMaximaOro;
                this.Ayuntamiento.CantidadOroActual = this.Ayuntamiento.CapacidadMaximaOro;

                if (!(this.CastilloClan == null))
                {
                    this.CastilloClan.CantidadOroActual = 0;
                    if (this.CastilloClan.CapacidadOro >= OroRestante)
                    {
                        this.CastilloClan.CantidadOroActual = OroRestante;
                        return OroAldea;
                    }
                    else
                    {
                        Int32 OroRestante2 = OroRestante - this.CastilloClan.CapacidadOro;
                        this.CastilloClan.CantidadOroActual = this.CastilloClan.CapacidadOro;

                        if (!(this.Almacenes == null))
                        {
                            Int32 contador = 0;
                            foreach (Almacen al in this.Almacenes)
                            {
                                if (al is AlmacenOro)
                                {
                                    contador += 1;
                                }
                            }
                            if (contador >= 1)
                            {
                                Int32 OroDividido = OroRestante2 / contador;
                                foreach (Almacen almO in this.Almacenes)
                                {
                                    if (almO is AlmacenOro)
                                    {
                                        almO.CantidadActual = 0;
                                        if (OroDividido <= almO.CapacidadMaxima)
                                        {
                                            almO.Almacenar(OroDividido);
                                            
                                        }
                                        else
                                        {
                                            foreach (Almacen almO2 in this.Almacenes)
                                            {
                                                if (almO2 is AlmacenOro)
                                                {
                                                    almO2.CantidadActual = almO.CapacidadMaxima;
                                                    
                                                }
                                            }
                                            return this.ObtenerOroMaximo();
                                        }
                                    }

                                }
                                return OroAldea;
                            }

                        }
                        else
                        {
                            return this.ObtenerOroMaximo();
                            //No posee más espacio para guardar Oro
                        }
                    return this.ObtenerOroMaximo();
                    }
                }
                else
                {
                    if (!(this.Almacenes == null))
                    {
                        Int32 contador = 0;
                        foreach (Almacen al in this.Almacenes)
                        {
                            if (al is AlmacenOro)
                            {
                                contador += 1;
                            }
                        }
                        if (contador >= 1)
                        {
                            Int32 OroDividido = OroRestante / contador;
                            foreach (Almacen almO in this.Almacenes)
                            {
                                if (almO is AlmacenOro)
                                {
                                    almO.CantidadActual = 0;
                                    if (OroDividido <= almO.CapacidadMaxima)
                                    {
                                        almO.Almacenar(OroDividido);
                                        
                                    }
                                    else
                                    {
                                        foreach (Almacen almO2 in this.Almacenes)
                                        {
                                            if (almO2 is AlmacenOro)
                                            {
                                                almO2.CantidadActual = almO.CapacidadMaxima;
                                                
                                            }
                                        }
                                        return this.ObtenerOroMaximo();
                                    }
                                }

                            }
                            return OroAldea;
                        }

                    }
                    else
                    {
                        return this.ObtenerOroMaximo();
                        //No posee más espacio para guardar Oro
                    }
                return this.ObtenerOroMaximo();
                }
            }
        }
        /// <summary>
        /// ordena el Elixir rojo recibido por parametro, distribuyendolo primero en ayuntamiento, luego en castillo y en almacenes
        /// </summary>
        /// <param name="Elixir"> oro a ordenar</param>
        /// <returns>Elixir total de la aldea</returns>
        public Int32 RestructurarElixirRojo(Int32 Elixir)
        {
            Int32 ElixirAldea = 0;
            ElixirAldea = this.ElixirRojoActual + Elixir;
            this.Ayuntamiento.CantidadElixirRojoActual = 0;
            if (ElixirAldea <= this.Ayuntamiento.CapacidadMaximaElixirRojo)
            {
                this.Ayuntamiento.CantidadElixirRojoActual = ElixirAldea;
                return ElixirAldea;
            }
            else
            {
                Int32 ElixirRestante = ElixirAldea - this.Ayuntamiento.CapacidadMaximaElixirRojo;
                this.Ayuntamiento.CantidadElixirRojoActual = this.Ayuntamiento.CapacidadMaximaElixirRojo;

                if (!(this.CastilloClan == null))
                {
                    this.CastilloClan.CantidadElixirActual = 0;
                    if (this.CastilloClan.CapacidadElixirRojo >= ElixirRestante)
                    {
                        this.CastilloClan.CantidadElixirActual = ElixirRestante;
                        return ElixirAldea;
                    }
                    else
                    {
                        Int32 ElixirRestante2 = ElixirRestante - this.CastilloClan.CapacidadElixirRojo;
                        this.CastilloClan.CantidadElixirActual = this.CastilloClan.CapacidadElixirRojo;

                        if (!(this.Almacenes == null))
                        {
                            Int32 contador = 0;
                            foreach (Almacen al in this.Almacenes)
                            {
                                if (al is AlmacenElixirRojo)
                                {
                                    contador += 1;
                                }
                            }
                            if (contador >= 1)
                            {
                                Int32 ElixirDividido = ElixirRestante2 / contador;
                                foreach (Almacen almER in this.Almacenes)
                                {
                                    if (almER is AlmacenElixirRojo)
                                    {
                                        almER.CantidadActual = 0;
                                        if (ElixirDividido <= almER.CapacidadMaxima)
                                        {
                                            almER.Almacenar(ElixirDividido);
                                            
                                        }
                                        else
                                        {
                                            foreach (Almacen almER2 in this.Almacenes)
                                            {
                                                if (almER2 is AlmacenElixirRojo)
                                                {
                                                    almER2.CantidadActual = 0;
                                                    almER2.CantidadActual = almER.CapacidadMaxima;
                                                    
                                                }
                                            }
                                            return this.ObtenerElixirRojoMaximo();
                                        }
                                    }

                                }
                                return ElixirAldea;
                            }

                        }
                        else
                        {
                            return this.ObtenerElixirRojoMaximo();
                            //No posee más espacio para guardar Elixir
                        }
                    return this.ObtenerElixirRojoMaximo();
                    }
                }
                else
                {
                    if (!(this.Almacenes == null))
                    {
                        Int32 contador = 0;
                        foreach (Almacen al in this.Almacenes)
                        {
                            if (al is AlmacenElixirRojo)
                            {
                                contador += 1;
                            }
                        }
                        if (contador >= 1)
                        {
                            Int32 ElixirDividido = ElixirRestante / contador;
                            foreach (Almacen almER in this.Almacenes)
                            {
                                
                                if (almER is AlmacenElixirRojo)
                                {
                                    almER.CantidadActual = 0;
                                    if (ElixirDividido <= almER.CapacidadMaxima)
                                    {
                                        almER.Almacenar(ElixirDividido);
                                        
                                    }
                                    else
                                    {
                                        foreach (Almacen almER2 in this.Almacenes)
                                        {
                                            if (almER2 is AlmacenElixirRojo)
                                            {
                                                almER2.CantidadActual = almER.CapacidadMaxima;
                                                
                                            }
                                        }
                                        return this.ObtenerElixirRojoMaximo();
                                        
                                    }
                                }

                            }
                            return ElixirAldea;
                        }

                    }
                    else
                    {
                        return this.ObtenerElixirRojoMaximo();
                        //No posee más espacio para guardar Elixir
                    }
                return this.ObtenerElixirRojoMaximo();
                }
            }
        }
        /// <summary>
        /// ordena el Elixir Negro recibido por parametro, distribuyendolo primero en el castillo y luego en almacenes
        /// </summary>
        /// <param name="ElixirNegro"> Elixir negro a ordenar</param>
        /// <returns>Elixir Negro total de la aldea</returns>
        public Int32 RestructurarElixirNegro(Int32 ElixirNegro)
        {
            Int32 ElixirNegroAldea = 0;
            ElixirNegroAldea = this.ElixirNegroActual + ElixirNegro;
            
            if (!(this.CastilloClan == null))
            {
                this.CastilloClan.CantidadElixirNegroActual = 0;
                if (this.CastilloClan.CapacidadElixirNegro >= ElixirNegroAldea)
                {
                    this.CastilloClan.CantidadElixirNegroActual = ElixirNegroAldea;
                    this.ElixirNegroActual = ElixirNegroAldea;
                    return ElixirNegroAldea;

                }
                else
                {
                    Int32 ElixirNegroRestante = ElixirNegroAldea - this.CastilloClan.CapacidadElixirNegro;
                    this.CastilloClan.CantidadElixirNegroActual = this.CastilloClan.CapacidadElixirNegro;
                    

                    if (!(this.Almacenes == null))
                    {
                        Int32 contador = 0;
                        foreach (Almacen al in this.Almacenes)
                        {
                            if (al is AlmacenElixirOscuro)
                            {
                                contador += 1;
                            }
                        }
                        if (contador >= 1)
                        {
                            Int32 ElixirNegroDividido = ElixirNegroRestante / contador;
                            foreach (Almacen almEN in this.Almacenes)
                            {
                                
                                if (almEN is AlmacenElixirOscuro)
                                {
                                    almEN.CantidadActual = 0;
                                    if (ElixirNegroDividido <= almEN.CapacidadMaxima)
                                    {
                                        almEN.Almacenar(ElixirNegroDividido);
                                        
                                    }
                                    else
                                    {
                                        foreach (Almacen almEN2 in this.Almacenes)
                                        {
                                            if (almEN2 is AlmacenElixirOscuro)
                                            {
                                                almEN2.CantidadActual = almEN.CapacidadMaxima;
                                                
                                            }
                                        }
                                        return this.ObtenerElixirOscuroMaximo();
                                    }
                                }

                            }
                            return ElixirNegroAldea;
                        }

                    }
                    else
                    {
                        return this.ObtenerElixirOscuroMaximo();
                        //No posee más espacio para guardar Elixir Negro
                    }
                    return this.ObtenerElixirOscuroMaximo();
                }
            }
            else
            {
                if (!(this.Almacenes == null))
                {
                    Int32 contador = 0;
                    foreach (Almacen al in this.Almacenes)
                    {
                        if (al is AlmacenElixirOscuro)
                        {
                            contador += 1;
                        }
                    }
                    if (contador >= 1)
                    {
                        Int32 ElixirNegroDividido = ElixirNegroAldea / contador;
                        foreach (Almacen almEN in this.Almacenes)
                        {
                            if (almEN is AlmacenElixirOscuro)
                            {
                                almEN.CantidadActual = 0;
                                if (ElixirNegroDividido <= almEN.CapacidadMaxima)
                                {
                                    almEN.Almacenar(ElixirNegroDividido);
                                    
                                }
                                else
                                {
                                    foreach (Almacen almEN2 in this.Almacenes)
                                    {
                                        if (almEN2 is AlmacenElixirOscuro)
                                        {
                                            almEN2.CantidadActual = almEN.CapacidadMaxima;
                                            
                                        }
                                    }
                                    return this.ObtenerElixirOscuroMaximo();
                                }
                            }

                        }
                        return ElixirNegroAldea;
                    }

                }
                else
                {
                    //No posee más espacio para guardar Elixir Negro
                    return this.ObtenerElixirOscuroMaximo();
                }
            }
            return this.ObtenerElixirOscuroMaximo();
        }


       }


    }

