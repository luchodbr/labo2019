using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Ejercicio
{
    public class Recatangulo
    {
        float area;
        float perimetro;

        public float GetArea()
        {
            if (area > 0)
                return area;
            else
                return -1;
        }

        public void SetArea(float value)
        {
            area = value;
        }

        public float Perimetro { get => perimetro; set => perimetro = value; }
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        public Recatangulo(Punto ver1, Punto ver3)
        {
            this.vertice2 = new Punto(ver3.X, ver1.Y);
            this.vertice4 = new Punto(ver1.X, ver3.Y);

            this.vertice1 = new Punto(ver1.X, ver1.Y);
            this.vertice3 = new Punto(ver3.X, ver3.Y);

            this.SetArea(Math.Abs(vertice1.X - vertice3.X) * Math.Abs(vertice4.Y - vertice2.Y));
            this.Perimetro = (Math.Abs(Math.Abs(vertice1.X - vertice3.X) + Math.Abs(vertice4.Y - vertice2.Y)) * 2);
            Console.WriteLine(GetArea());
            Console.WriteLine(Perimetro);
            Console.ReadKey();
        }

    }
}
