using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo) : base (duracion, destino, origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo) : this (llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public override float  CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }        
        protected string Mostrar()
        {            
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.mostrar() + $" Costo de llamada: {this.CostoLlamada}\n");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }

    
}   
