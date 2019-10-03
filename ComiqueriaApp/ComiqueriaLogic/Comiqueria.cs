using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        List<Producto> productos;
        List<Venta> ventas;


        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();

        }
        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto p in this.productos)
                {
                    if ((Guid)p == codigo)
                        return p;
                }
                return null;
            }
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto p in comiqueria.productos)
            {
                if (p.Descripcion == producto.Descripcion)
                    return true;

            }
            return false;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
                return comiqueria;
            }
            return comiqueria;
        }

        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }
        public void Vender(Producto p)
        {
            this.Vender(p, 1);
        }
        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();
            List<Venta> lista = this.ventas;
            lista.Sort(Sort);
            foreach (Venta v in lista)
            {
                sb.AppendLine(v.ObtenerDescripcionBreve());
            }
            return sb.ToString();
        }
        private int Sort(Venta v1, Venta v2)
        {
            return v1.Fecha.CompareTo(v2.Fecha);
        }

        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario = new Dictionary<Guid, string>();
            foreach (Producto p in this.productos)
            {
                diccionario.Add((Guid)p, p.Descripcion);
            }
            return diccionario;
        }
    }
}
