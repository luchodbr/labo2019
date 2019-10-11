using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        const int MEDIDA = 400;

        public Agua(int capacidad,int contenido, string marca):base(marca,capacidad,contenido)
        {

        }

        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);

        }
        public int ServirMedida(int cantidad)
        {
            if (cantidad <= this.Contenido)
            {
                 this.contenidoML = this.contenidoML - cantidad;
                return cantidad;
            }
            else
            {
                int retorno= this.contenidoML;
                this.Contenido = 0;
                return retorno;
            }
        }
        public new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GenerarInforme());
            sb.AppendLine("La Medida es :" + Agua.MEDIDA);
            return sb.ToString();
        }
    }
}
