using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base (duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja franja, Llamada llamada) : this (llamada.NroOrigen,franja, llamada.Duracion,llamada.NroDestino)
        {

        }

        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        public enum Franja
        {
           Franja_1 = 99,
           Franja_2 = 125,
           Franja_3 = 66
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.mostrar() + $" Costo de llamada: {this.CostoLlamada} " +
                $"Franja: {this.franjaHoraria}\n");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private float CalcularCosto()
        {
            float aux = (float) this.franjaHoraria / 100;
            return aux * this.Duracion;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
