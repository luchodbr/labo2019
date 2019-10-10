using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        #region Atributos y prop

        Guid codigo;
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
        }
        private int stock;

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                    this.stock = value;
            }
        }
        #endregion

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.Stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Descripcion : " + this.Descripcion);
            sb.AppendLine("Codigo : " + (Guid)this);
            sb.AppendLine("Precio : " + this.Precio);
            sb.AppendLine("Stock : " + this.Stock +" unidades");
            return sb.ToString();
        }


    }
}
