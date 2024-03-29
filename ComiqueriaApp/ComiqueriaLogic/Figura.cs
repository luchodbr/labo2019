﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura :Producto
    {
        double altura;

        public Figura(int stock, double precio, double altura):this(("Altura"+altura+"cm"),stock,precio,altura)
        {

        }
        public Figura(string descripcion,int stock, double precio, double altura):base(descripcion,stock,precio)
        {
            this.altura = altura;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Altura : " + this.altura);
            return base.ToString();
        }
    }
}
