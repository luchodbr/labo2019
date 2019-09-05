using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Ejercicio
{
    public class Dolar
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



        public Dolar(double d)
        {
            this.SetCantidad(d);
        }

        public static Dolar operator +(Dolar d1, Pesos p1)
        {
            return new Dolar(d1.cantidad + (p1.GetCantidad() / 38.33));
        }
        public static Dolar operator +(Dolar d1, Euro e1)
        {
            return new Dolar(d1.cantidad + (e1.GetCantidad() / 1.16));
        }
        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.cantidad + d2.cantidad);
        }
    }
}
