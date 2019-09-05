using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Ejercicio
{
    public class Euro
    {
        double cantidad;
        public double GetCantidad()
        {
            return cantidad;
        }
        public void SetCantidad(double value)
        {
            cantidad = value;
        }
        double cotizRespectoDolar;


        public Euro(double d)
        {
            this.SetCantidad(d);
        }

        public static Euro operator +(Euro e1, Pesos p1)
        {
            return new Euro(e1.cantidad + (p1.GetCantidad() / 44.46));
        }
        public static Euro operator +(Euro e1, Dolar d1)
        {
            return new Euro(e1.cantidad + (d1.GetCantidad() * 1.16));
        }
        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.cantidad + e2.cantidad);
        }
    }
}
