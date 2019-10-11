using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        const int MEDIDA = 330;
        Tipo tipo;
        public Cerveza(string marca, int capacidad, int contenido, Tipo tipo) : base(marca, capacidad, contenido)
        {
            this.tipo = tipo;
        }
        public Cerveza(string marca, int capacidad, int contenido) : this(marca, capacidad, contenido, Tipo.Vidrio)
        {

        }
        public override int ServirMedida()
        {
            int med = 264;
            int retorno = med;
            if (med <= this.contenidoML)
            {
                this.Contenido = (int)(this.contenidoML - med);
                retorno = med;
            }
            else if (med > this.contenidoML)
            {
                retorno = this.contenidoML;
                this.Contenido = 0;
            }
            return retorno;
        }
        public new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GenerarInforme());
            sb.AppendLine("La Medida es :" + Cerveza.MEDIDA);
            sb.AppendLine("La botella para cerveza es :" + this.tipo);

            return sb.ToString();
        }
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
