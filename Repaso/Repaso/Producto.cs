using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        string codigoDeBarras;
        string marca;
        float precio;

        public Producto(string marc, string cod,  float pre)
        {
            this.codigoDeBarras = cod;
            this.marca = marc;
            this.precio = pre;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("el codigo de barras es " + p.codigoDeBarras);
            sb.AppendLine("la marca es " + p.marca);
            sb.AppendLine("el precio es " + p.precio.ToString());
            return sb.ToString();

        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarras;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null) && !(p2 is null))
            {
                if (p1.codigoDeBarras == p2.codigoDeBarras)
                    if (p1.marca == p2.marca)
                    {
                        return true;
                    }
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, string s)
        {
            if (!(p1 is null))
            {
                if (p1.marca == s)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Producto p1, string s)
        {
            return !(p1 == s);
        }
    }
}
