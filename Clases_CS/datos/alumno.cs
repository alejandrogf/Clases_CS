using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Para organizar código:
Se seleccionan las lineas que se quieren y en la parte izquierda, en la brocha->surround with->region.
A la region se le puede dar nombre y así agrupa el código.*/
namespace Clases_CS.datos
{
    public class Alumno : Persona //Si no se pone publica, no se puede acceder desde fuera de este fichero.
    {
        #region Fields & Properties

        //private string _nombre; //Esto es un field. Generalmente se pone un _ por delante.

        //public string Nombre //Property. Tienen get y/o set. Se utilizan para modificar un campo.
        //{
        //    set //Se comporta como una función, sin serlo.
        //    { _nombre = value.ToUpper(); }
        //    get //Se comporta como una función, sin serlo.
        //    { return _nombre; }
        //}

        //Autoproperty. Versión simplificada de lo anterior. Pero sólo cuando se quiere fijar y recuperar.
        //Es un atajo y combina field+property
        //Si se quiere hacer algo mas, hay que hacerlo a mano.
        //public int Edad { get; set; }
        public int Nota { set; get; }

        public string Curso { get; set; }

        #endregion

        #region Constructores

        /*Constructor. Son métodos que se definen sin tipo (int, string, etc) y se llaman IGUAL que la clase.
         Pueden existir varios constructores (que por tanto tienen el mismo nombre) siempre y cuando
         el numero de los argumentos que reciben sea diferente o su orden.*/
        //public Alumno()
        //{
        //    Nombre = "";
        //    Nota = 0;
        //    Edad = 0;
        //}

        public Alumno(string nombre, int nota, int edad) : base(nombre, edad)
        {
            Nombre = nombre;
            Nota = nota;
            Edad = edad;
        }

        //Si no se declara un constructor, por defecto todas las clases tienen un constructor "vacio",
        //que no recibe argumentos y los campos los inicializa a cero/vacio
        //public Alumno(){}
        #endregion

        #region Metodos

        public void ModificarNota(int cantidad) //VOID para indicar que no devuelve nada. 
            //que no tiene que terminar con un return.
        {
            Nota += cantidad;
        }

        public string GetNotaTexto()
        {
            if (Nota < 5)
            {
                return "Suspenso";
            }
            else if (Nota < 7)
            {
                return "Aprobado";
            }
            else if (Nota < 9)
            {
                return "Notable";
            }
            else
            {
                return "Sobresaliente";
            }

        }

        #endregion

        public override void Funciones()
        {
            throw new NotImplementedException();
        }
    }
}
