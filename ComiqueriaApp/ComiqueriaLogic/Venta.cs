using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        DateTime fecha;
        static int procentajeIva;
        double precioFinal;
        Producto producto;
        internal DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }
        static Venta()
        {
            Venta.procentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);

        }
        void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            return ((precioUnidad * cantidad) * (float)(Venta.procentajeIva / 100));
        }
        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Fecha + " - " + this.producto.Descripcion + " - " + this.precioFinal);
            return sb.ToString();
        }
    }
}
