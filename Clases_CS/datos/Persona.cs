using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_CS.datos
{
    public abstract class Persona
    {
        private string _nombre; 
        public string Nombre 
        {
            set 
            { _nombre = value.ToUpper(); }
            get 
            { return _nombre; }
        }

        public int Edad { get; set; }

        public void Detalles()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}",Nombre,Edad);

        }

        public abstract void Funciones();


        protected Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
