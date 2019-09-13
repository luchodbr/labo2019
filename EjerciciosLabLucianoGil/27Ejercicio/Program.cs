using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lis = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Random r = new Random();
                lis.Add(r.Next(-10, 10));
                Console.ReadKey();
            }
            foreach (int i in lis)
            {
                Console.WriteLine(i);
                Console.ReadKey(); 
            }
        }
    }
}
