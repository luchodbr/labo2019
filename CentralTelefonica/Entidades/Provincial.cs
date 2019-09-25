using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja mifranja, Llamada llamada) : this(llamada.NroOrigen, mifranja,
            llamada.Duracion, llamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja mifranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = mifranja;
        }
        public override float CostoLlamada
        {
            get
            { return this.CalcularCosto(); }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append("\n");
            sb.Append(franjaHoraria.ToString() + " - ");
            sb.Append("costo llamada \n");
            sb.Append(this.CostoLlamada);

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float res;
            if (this.franjaHoraria == Franja.Franja_1)
                res = this.Duracion * 0.99f;
            else if (this.franjaHoraria == Franja.Franja_2)
                res = this.Duracion * 1.25f;
            else
                res = this.Duracion * 0.66f;

            return res;
        }
        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }
        public override string ToString()
        {
            return this.Mostrar(); 
        }

        public enum Franja { Franja_1, Franja_2, Franja_3 }
    }
}
