using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        List<Botella> botellas;
        static int espaciosTotales;
        static Cantina singleton;

        public List<Botella> Botellas
        {
            get { return this.botellas; }
        }

        private Cantina(int espaciosTotales)
        {
            Cantina.espaciosTotales = espaciosTotales;
            botellas = new List<Botella>();
        }

         public static Cantina GetCantina(int espacios)
        {
            if(Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
                return Cantina.singleton;
            }
            else
            {
                Cantina.espaciosTotales = espacios;
                return Cantina.singleton;
            }
        }
        public static bool operator +(Cantina c, Botella b)
        {
            if (Cantina.espaciosTotales > c.botellas.Count)
            {
                c.botellas.Add(b);
                return true;
            }
            return false;
        }

    }
}
