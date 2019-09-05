using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        Producto[] productos;
        int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad1, int ubicacion) : this(capacidad1)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProducto()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e1)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto p in e1.GetProducto())
            {
                sb.AppendLine(Producto.MostrarProducto(p));
                sb.AppendLine(" ");
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e1, Producto p1)
        {
            foreach (Producto p in e1.GetProducto())
            {
                if (p == p1)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e1, Producto p1)
        {
            return !(e1 == p1);
        }
        public static bool operator +(Estante e1, Producto p1)
        {
            if (e1 != p1)
            {
                for (int i = 0; i < e1.productos.Length; i++)
                {
                    if (e1.productos[i] is null)
                    {
                        e1.productos[i] = p1;
                        return true;
                    }

                }
            }
            return false;

        }
        public static bool operator -(Estante e1, Producto p1)
        {

            for (int i = 0; i < e1.productos.Length; i++)
            {
                if(e1.productos[i] == p1)
                {
                    e1.productos[i] = null;
                    return true;
                }
            }
            return false;

        }

    }
}
