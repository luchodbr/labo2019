using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Ejerrcicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s = new Sumador(3);
            Sumador s2 = new Sumador(5);
            Console.WriteLine(s.Sumar(1, 2));
            Console.WriteLine(s.Sumar("hola"," que tal"));
            Console.WriteLine(s + s2);
            int numero = s2;
            Console.WriteLine(s|s2);

            Console.WriteLine("la var numero es {0}",numero);
            Console.ReadKey();
        }
    }
}
