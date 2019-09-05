using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Ejercicio
{
    public class Pesos
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

        public Pesos(double d)
        {
            this.SetCantidad(d);
        }



        public static Pesos operator +(Pesos p1, Dolar d1)
        {
            return new Pesos(p1.cantidad + (d1.GetCantidad()*38.33));
        }
        public static Pesos operator +(Pesos p1, Euro e1)
        {
            return new Pesos(p1.cantidad + (e1.GetCantidad() * 44.46));
        }
        public static Pesos operator +(Pesos p1, Pesos p2)
        {
            return new Pesos(p1.cantidad + p2.cantidad);
        }
    }
}
