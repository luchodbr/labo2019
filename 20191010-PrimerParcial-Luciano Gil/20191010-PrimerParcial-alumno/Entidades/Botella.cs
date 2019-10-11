using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected string marca;
        protected int capaciddadML;
        protected int contenidoML;

        public int CapacidadLitros
        {
            get { return this.capaciddadML/1000; }
        }


        protected int Contenido
        {
            get { return this.contenidoML; }
            set { this.contenidoML = value; }
        }

        public Botella(string marca, int capacidad, int contenido)
        {
            this.marca = marca;
            if (capacidad < contenido)
            {
                this.contenidoML = capacidad;
            }
            this.capaciddadML = capacidad;
            this.contenidoML = contenido;
        }

        public float PorcentajeContenido
        {
            get { return (this.capaciddadML*100)/this.contenidoML; }
        }

        public abstract int ServirMedida();
        
        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("La marca es: {0} \n", this.marca);
            sb.AppendFormat("La capacidad es: {0} mililitros \n", this.capaciddadML);
            sb.AppendFormat("El contenido: {0} mililitros \n", this.contenidoML);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.GenerarInforme();
        }
        public enum Tipo
        {
           Plastico,Vidrio
        }
    }
}
