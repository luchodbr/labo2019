using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Ejerrcicio
{
    public class Sumador
    {
        int cantidadSumas;
        public Sumador(int num)
        {
            this.cantidadSumas = num;
        }
        public Sumador() : this(0)
        {
        }

        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + b;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas == s2.cantidadSumas)
                return true;
            else
                return false;
        }
        public static implicit operator int(Sumador s1)
        {
            return s1.cantidadSumas;
        }
        /// un casteo implicito no necesita un casteo, en cambio un explicito si necesita un casteo como por ej: (string)
        /// 
    }
}
