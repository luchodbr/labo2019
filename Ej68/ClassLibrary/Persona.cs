using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        public event DelegadoString EventoString;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value != Nombre)
                {
                    this.EventoString.Invoke("Se cambio el nombre");
                    nombre = value;
                }
            }

        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set {
                if (value != Apellido)
                {
                    this.EventoString.Invoke("Se cambio el nombre");
                    apellido = value;
                }
            }
        }
        public Persona()
        {

        }
        public string Mostrar()
        {
            return ("nombre es: " + this.Nombre + "apellido es: " + this.Apellido);
        }
    }
}
