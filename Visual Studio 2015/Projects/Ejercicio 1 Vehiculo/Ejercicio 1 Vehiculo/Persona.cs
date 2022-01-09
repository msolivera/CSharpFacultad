using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Vehiculo
{
    class Persona
    {
        public float peso;
        public float altura;
        private string nombre;
        public int edad;
        private readonly int ci;
        public string sexo;

        private int Ci
        {
            get { return this.ci; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public float Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }
        public float Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }
        public Persona(int c)
        {
            this.nombre = "";
            this.edad = 0;
            this.ci = c;
            this.sexo = "H";
            this.peso = 0;
            this.altura = 0;
        }

        float imc = 0;

        public int CalculaIMC()
        {

            imc = this.peso / (this.altura * this.altura);
            if (imc < 18) { return -1; }
            if (imc > 25) { return 1; }
            else { return 0; }
        }
     
        public bool EsMayorDeEdad()
        {
            if (this.edad >= 18) { return true; }
            else { return false; }
        }

    }
    

}