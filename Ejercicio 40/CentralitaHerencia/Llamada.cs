using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }

        protected virtual string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Duracion llamada:{this.Duracion}" +
                $" Numero de Origen:{this.NroOrigen} Destinatario:{this.NroDestino}");
            return sb.ToString();
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            return (llamada1.Equals(llamada2) && 
                        llamada1.NroDestino.Equals(llamada2.NroDestino) &&
                            llamada1.nroOrigen.Equals(llamada2.NroOrigen));
        }
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
       
    }
}
