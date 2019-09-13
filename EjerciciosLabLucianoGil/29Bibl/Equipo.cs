using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Bibl
{
    public class Equipo
    {
        short cantidadJugadores;
        List<Jugador> jugadores;
        string nombre;


        Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) :this()
        {
            this.nombre = nombre;
            this.cantidadJugadores = cantidad;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            foreach (Jugador p in e.jugadores)
            {
                if (j == p)
                    return false;
            }

            if (e.jugadores.Count < e.cantidadJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }
            else
                return false;
        }
    }
}
