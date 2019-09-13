using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Ejercicio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                array[i] = (int)r.Next(20);
                Console.WriteLine(array[i]);
                Console.ReadKey();
            }
            Array.Sort(array);
            for (int i = 0; i < 20; i++)
            {
               
                Console.WriteLine(array[i]);
            }

            Array.Sort(array, Ordenar);
            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine(array[i]);
            }
            int Ordenar(int numero1, int numero2)
            {
               return  -(numero1.CompareTo(numero2));
            }
            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine(array[i]);
                Console.ReadKey();
            }
        }
    }
}
