﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        protected float costo;
        public override float CostoLlamada { get { return this.CalcularCosto(); } }
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append("\n");
            sb.Append("Costo llamada");
            sb.Append(this.CostoLlamada.ToString() + " - ");
            return sb.ToString();

        }
        public override string ToString()
        {
            return this.Mostrar(); 
        }
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }
        public override bool Equals(object obj)
        {
            return (obj is Local);    
        }

    }
}
