using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_CS.datos;

namespace Clases_CS
{
    class Program
    {
        static void Main(string[] args)
        {
        //Cuando una clase no tiene definido el constructor, se puede llamar igualmente.
        //Símplemente se llama pasando los valores iniciales de las properties.
            var alum=new Alumno()
            {
                Curso = "C#",
                Edad = 22,
                Nota = 8,
                Nombre = "Luis"
            };
            alum.Detalles();
            Console.WriteLine(alum.GetNotaTexto());
            Console.ReadLine();
        }
    }
}
