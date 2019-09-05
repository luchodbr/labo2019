using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("ingrese un numero");
            int.TryParse(Console.ReadLine(), out numero);
            double cuadrado =Math.Pow(numero, 2);
            double cubo = Math.Pow(numero, 3);
            Console.WriteLine("el cuadrado es {0} y el cubo {1} ", cuadrado, cubo);
            Console.ReadKey();
        }
    }
}
