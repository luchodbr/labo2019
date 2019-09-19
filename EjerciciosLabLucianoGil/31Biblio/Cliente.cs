using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Biblio
{
    public class Cliente
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Cliente(int numero)
        {
            this.Numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.Nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1.Numero == c2.Numero)
                return true;
            return false;
        }
          public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
