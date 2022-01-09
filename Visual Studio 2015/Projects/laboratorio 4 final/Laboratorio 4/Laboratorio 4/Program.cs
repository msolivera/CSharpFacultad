using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Laboratorio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 contadorArchivoCorrupto = 0;
            Int32 contadorFueraDeRango = 0;
            Int32 contadorNoExisteA = 0;
            Int32 contadorArchInvalido = 0;
            Int32 contadorNroLineaIncorrecto = 0;
            Int32 contadorRutaInvalida = 0;
            StreamWriter log = File.AppendText("log.txt"); // Crea archivo log



            ArrayList a = new ArrayList();
            ManejadorDeArchivos m1 = new ManejadorDeArchivos();
            foreach (String i in a)
            {
                Console.WriteLine(i);
            }

            Program.Menu();
            string opcion = "r";
            while (!(opcion.Equals("s")))
            {
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case ("1"):
                        try
                        {

                            Console.WriteLine("Ingrese una direccion para el archivo");
                            string direccion1 = Console.ReadLine();
                            ArrayList lista = new ArrayList();
                            for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine("Escriba una palabra");
                                lista.Add(Console.ReadLine());
                            }
                            m1.Escribir(direccion1, lista);
                            
                            
                        }
                        catch (RutaInvalidaException)
                        {
                            contadorRutaInvalida++;
                            log.WriteLine(DateTime.Today + "La excepcion Ruta invalida se ejecuto:" + contadorRutaInvalida + "veces");
                            new RutaInvalidaException("La ruta es invalida");
                            
                        }
                        catch (NoExisteArchivoException)
                        {
                            contadorNoExisteA++;
                            log.WriteLine(DateTime.Today + "La excepcion No existe archivo se ejecuto:" + contadorNoExisteA + "veces");
                            new NoExisteArchivoException("No existe ese archivo");
                        }
                        catch (NombreArchivoInvalidoException)
                        {
                            contadorArchInvalido++;
                            log.WriteLine(DateTime.Today + "La excepcion Nombre archivo invalido se ejecuto:" + contadorArchInvalido + "veces");
                            new NombreArchivoInvalidoException("El nombre del archivo contiene caracteres invalidos");
                        }
                        catch (ArchivoCorruptoException)
                        {
                            contadorArchivoCorrupto++;
                            log.WriteLine(DateTime.Today + "La excepcion Archivo corrupto se ejecuto:" + contadorArchivoCorrupto+ "veces");
                            new ArchivoCorruptoException("El archivo esta corrupto");
                        }
                        finally
                        {
                            log.Close();
                        }
                        
                        break;
                    case ("2"):
                        try
                        {
                            Console.WriteLine("Ingrese una direccion para el archivo");
                            string direccion = Console.ReadLine();
                            string[] vector = new string[15];
                            m1.Leer(direccion, vector);
                            Program.Menu();
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error, ingrese un numero");
                            Program.Menu();
                        }
                        catch (RutaInvalidaException)
                        {
                            contadorRutaInvalida++;
                            log.WriteLine(DateTime.Today + "La excepcion Ruta invalida se ejecuto:" + contadorRutaInvalida + "veces");
                            new RutaInvalidaException("La ruta es invalida");
                        }
                        catch (NoExisteArchivoException)
                        {
                            contadorNoExisteA++;
                            log.WriteLine(DateTime.Today + "La excepcion No existe Archivo se ejecuto:" + contadorNoExisteA + "veces");
                            new NoExisteArchivoException("No existe ese archivo");
                        }
                        catch (NombreArchivoInvalidoException)
                        {
                            contadorArchInvalido++;
                            log.WriteLine(DateTime.Today + "La excepcion Archivo invalido se ejecuto:" + contadorArchInvalido + "veces");
                            new NombreArchivoInvalidoException("El nombre del archivo contiene caracteres invalidos");
                        }
                        catch (ArchivoCorruptoException)
                        {
                            contadorArchivoCorrupto++;
                            log.WriteLine(DateTime.Today + "La excepcion Archivo corrupto se ejecuto:" + contadorArchivoCorrupto + "veces");
                            new ArchivoCorruptoException("El archivo esta corrupto");
                        }
                        catch (NumeroDeLineaIncorrectaException)
                        {
                            contadorNroLineaIncorrecto++;
                            log.WriteLine(DateTime.Today + "La excepcion Numero linea incorrecta se ejecuto:" + contadorNroLineaIncorrecto + "veces");
                            new NumeroDeLineaIncorrectaException("El numero de linea no es valido");
                        }
                        catch (FueraDeRangoException)
                        {
                            contadorFueraDeRango++;
                            log.WriteLine(DateTime.Today + "La excepcion Fuera de rango se ejecuto:" + contadorFueraDeRango+ "veces");
                            new FueraDeRangoException("Fuera de rango");
                        }
                        finally
                        {
                            log.Close();
                        }
                        Program.Menu();
                        break;
                    case ("3"):
                        Console.WriteLine("Ingrese una direccion para el archivo");
                        string direccion2 = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad de lineas a saltar");
                        try
                        {
                            int clinea = Convert.ToInt32(Console.ReadLine());
                            m1.Leer(direccion2, clinea);
                            Program.Menu();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error, ingrese un numero");
                            Program.Menu();
                        }
                        catch (RutaInvalidaException)
                        {
                            contadorRutaInvalida++;
                            log.WriteLine(DateTime.Today + "La excepcion Ruta invalida se ejecuto:" + contadorRutaInvalida + "veces");
                            new RutaInvalidaException("La ruta es invalida");
                        }
                        catch (NoExisteArchivoException)
                        {
                            contadorNoExisteA++;
                            log.WriteLine(DateTime.Today + "La excepcion No existe Archivo se ejecuto:" + contadorNoExisteA + "veces");
                            new NoExisteArchivoException("No existe ese archivo");
                        }
                        catch (NombreArchivoInvalidoException)
                        {
                            contadorArchInvalido++;
                            log.WriteLine(DateTime.Today + "La excepcion Archivo invalido se ejecuto:" + contadorArchInvalido + "veces");

                            new NombreArchivoInvalidoException("El nombre del archivo contiene caracteres invalidos");
                        }
                        catch (ArchivoCorruptoException)
                        {
                            contadorArchivoCorrupto++;
                            log.WriteLine(DateTime.Today + "La excepcion Archivo corrupto se ejecuto:" + contadorArchivoCorrupto + "veces");
                            new ArchivoCorruptoException("El archivo esta corrupto");
                        }
                        catch (NumeroDeLineaIncorrectaException)
                        {
                            contadorNroLineaIncorrecto++;
                            log.WriteLine(DateTime.Today + "La excepcion Numero linea incorrecta se ejecuto:" + contadorNroLineaIncorrecto + "veces");
                            new NumeroDeLineaIncorrectaException("El numero de linea no es valido");
                        }
                        finally
                        {
                            log.Close();
                        }
                        break;
                }
                break;

            }
        } 


                    
       static void Menu()
        {
           
                Console.WriteLine("Bienvenido al programa!");
                Console.WriteLine("1) Escribir en un archivo");
                Console.WriteLine("2) Leer un archivo");
                Console.WriteLine("3) Leer un archivo a partir de una linea");
                Console.WriteLine("Presione s para salir");
                Console.WriteLine("Por favor seleccione una opcion");
            


        }
            
        
    }
}
