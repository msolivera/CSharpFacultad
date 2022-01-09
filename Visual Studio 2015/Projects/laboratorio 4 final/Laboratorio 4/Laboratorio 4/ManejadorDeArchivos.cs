using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Laboratorio_4
{
    public class ManejadorDeArchivos
    {
        public ManejadorDeArchivos()
        {

        }

        public void VerificarRuta(string ruta)
        {
            if (!(Directory.Exists(ruta)))
            {
                throw new RutaInvalidaException("No existe la ruta");
            }

            if (!(File.Exists(ruta)))
            {
                throw new NoExisteArchivoException("No existe el archivo");
            }

            string[] rutavector = ruta.Split(new string[] { "\\" }, StringSplitOptions.None);
            Array.Reverse(rutavector);
            if ((rutavector[1].Contains('/') || (rutavector[1].Contains('>') || (rutavector[1].Contains('<') || (rutavector[1].Contains(':') || (rutavector[1].Contains('|')))))))
            {
                throw new NombreArchivoInvalidoException("El archivo contiene caracteres inválidos en su nombre");
            }

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(ruta);
            }
            catch (IOException)
            {
                throw new ArchivoCorruptoException("El archivo esta corrupto");
            }
            finally
            {
                sr.Close();
            }
        }
        public void Escribir (String nomArchivo, ArrayList elementos)
        {
            VerificarRuta(nomArchivo);
            StreamWriter Ar = new StreamWriter(nomArchivo);
            foreach (String elem in elementos)
            {                
                Ar.WriteLine(elem);
            }
            Ar.Close();
        }
        public void Leer(String nomArchivo, String[] contenedor)
        {
            VerificarRuta(nomArchivo);
            String line;
            StreamReader Ar = new StreamReader(nomArchivo);
            Int32 contLineas = File.ReadAllLines(nomArchivo).Count();
            line = Ar.ReadLine();
            Int32 contador = 0;

                if (!(contLineas > contenedor.Length))
                {
                    while (line != null)
                    {
                        contenedor[contador] = line;
                        line = Ar.ReadLine();
                        contador++;
                    }
                    Ar.Close();
                }
                else
                {
                    throw new FueraDeRangoException("Su archivo excede el máximo de lineas del contenedor");
                }
            
        }

        public ArrayList Leer(String nomArchivo, Int32 lineaNro)
        {
            if (lineaNro < 0 || lineaNro > File.ReadAllLines(nomArchivo).Count())
            {
                throw new NumeroDeLineaIncorrectaException("El numero de linea es incorrecto");
            }
            VerificarRuta(nomArchivo);
            ArrayList Lista = new ArrayList();
            String line;
            StreamReader Ar = new StreamReader(nomArchivo);
            line = Ar.ReadLine();
            Int32 contador = 0;

            while(contador != lineaNro)
            {
                contador++;
                line = Ar.ReadLine();
            }
            while( line != null)
            {
                Lista.Add(line);
                line = Ar.ReadLine();
               
            }
            return Lista;


        }


    }
}
