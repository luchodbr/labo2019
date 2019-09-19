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

        public Provincial(Franja mifranja, Llamada llamada):this(llamada.NroOrigen,mifranja,
            llamada.Duracion,llamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja mifranja, float duracion, string destino): base(duracion, destino, origen)
        {
            this.franjaHoraria = mifranja;
        }
        public float CostoLlamada { get { return 1; } }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append("\n");
            sb.Append(franjaHoraria.ToString() + " - ");

            return sb.ToString();
        }


        public enum Franja { Franja_1, Franja_2, Franja_3 }
    }
}
