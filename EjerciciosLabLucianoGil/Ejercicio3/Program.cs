using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int numero;
            int.TryParse(Console.ReadLine(), out numero);
            bool EsPrimo =true;
            for (int i = 1; i <= numero; i++)
            {
                
                for (int j = 2; j < numero-1; j++)
                {
                    if (numero % j == 0)
                    {
                        EsPrimo = false;
                    }

                   
                }
            }
               if(EsPrimo)
                { 
                     Console.WriteLine("es primo");
                }
               else
                Console.WriteLine("NO es primo");
            Console.ReadKey();
        }
    }
}
