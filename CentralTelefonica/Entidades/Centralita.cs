using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        List<Llamada> listaDeLlamadas;
        string razonSocial;

        public float GananciasPorLocal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTodas { get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float Ganancia = 0;
            foreach (Llamada l in this.listaDeLlamadas)
            {

                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (l is Local)
                        Ganancia += ((Local)l).CostoLlamada;
                }
                if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (l is Provincial)
                        Ganancia += ((Provincial)l).CostoLlamada;
                }
            }

            return Ganancia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("razon   " + this.razonSocial);
            sb.AppendLine("GananciaLoc   " + this.GananciasPorLocal);
            sb.AppendLine("GananciaProv   " + this.GananciasPorProvincial);
            sb.AppendLine("GananciaTod   " + this.GananciasPorTodas);

            foreach (Llamada l in this.Llamadas)
            {
                if (l is Local)
                    sb.AppendLine("Llamada Local \n " + ((Local)l).Mostrar());
                if (l is Provincial)
                    sb.AppendLine("Llamada Local \n " + ((Provincial)l).Mostrar());
            }

            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorLlamada);
        }
    }
}
