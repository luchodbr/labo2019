using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Llamada
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
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Duracion.ToString() + " - ");
            sb.Append("destino es " + " - ");
            sb.Append(this.NroDestino + " - ");
            sb.Append("origen es " + " - ");
            sb.Append(this.NroOrigen + " - ");
            return sb.ToString();
        }

        //protected int OrdenarPorLlamada(Llamada l1, Llamada l2)
        //{
        //    if (l1.duracion > l2.duracion)
        //        return true;
        //    return false;
        //}

        public enum TipoLlamada { Local,Provincial,Todas}

    }
}
