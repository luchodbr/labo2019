using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Bibl
{
    public class Jugador
    {
        int dni;
        string nombre;
        int partidosJugados;
        float promedioGoles;
        int totalGoles;

        public float GetPromedioGoles()
        {
            
          return this.promedioGoles = this.partidosJugados / this.totalGoles;
        }

        Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dn, string nombr):this()
        {
            this.dni = dn;
            this.nombre = nombr;
        }

        public Jugador(int dn, string nombr, int totalgol, int totalPart) :this(dn,nombr)
        {
            this.partidosJugados = totalPart;
            this.totalGoles = totalgol;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("el nombre es " +this.nombre);
            sb.AppendLine("el dni es " + this.dni.ToString());
            sb.AppendLine("partidosJugados es " + this.partidosJugados.ToString());
            sb.AppendLine("el promedio es " + this.promedioGoles.ToString());
            sb.AppendLine("el totalGoles es " + this.totalGoles.ToString());
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.dni == j2.dni)
                return true;
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
