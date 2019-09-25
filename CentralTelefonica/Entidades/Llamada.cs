using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Llamada
    {
        protected float duracion;
        public float Duracion { get { return this.duracion; } }
        protected string nroDestino;
        public string NroDestino { get { return this.nroDestino; } }
        protected string nroOrigen;
        public string NroOrigen { get { return this.nroOrigen; } }

        public Llamada(float dur, string nrDes, string nrOr)
        {
            this.duracion = dur;
            this.nroDestino = nrDes;
            this.nroOrigen = nrOr;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Duracion.ToString() + " - ");
            sb.Append("destino es " + " - ");
            sb.Append(this.NroDestino + " - ");
            sb.Append("origen es " + " - ");
            sb.Append(this.NroOrigen + " - ");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public abstract float CostoLlamada { get; }
        public static int OrdenarPorLlamada(Llamada l1, Llamada l2)
        {
            
            return l1.Duracion.CompareTo(l2.Duracion);
        }

        public enum TipoLlamada { Local,Provincial,Todas}


        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.Equals(l2) && l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.nroDestino);
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        



    }
}
