using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int añoFin;
            int añoComienzo;
            Console.Write("ingrese año comienzo");
            int.TryParse(Console.ReadLine(), out añoComienzo);
            Console.Write("ingrese año fin");
            int.TryParse(Console.ReadLine(), out añoFin);
            for (int i = añoComienzo; i < añoFin; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    
                    }
                    else
                        Console.WriteLine(i);
                }
                
            }
            Console.ReadKey();
        }
    }
}
