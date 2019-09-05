using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumNum = 0;
            int acum = 0;
            int numero = 6;
            do
            {
                acum = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                        acum += i;
                }
                if (numero == acum)
                {
                    Console.WriteLine(numero);
                    Console.ReadKey();
                    acumNum++;
                }
                numero++;
            }while (acumNum <= 4);
        }
    }
}
