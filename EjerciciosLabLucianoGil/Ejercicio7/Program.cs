using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int año;
            Console.Write("ingrese dia");
            int.TryParse(Console.ReadLine(), out dia);
            Console.Write("ingrese mes");
            int.TryParse(Console.ReadLine(), out mes);
            Console.Write("ingrese año");
            int.TryParse(Console.ReadLine(), out año);
            StringBuilder fecha = new StringBuilder();
            fecha.Append(dia);
            fecha.Append("/");
            fecha.Append(mes);
            fecha.Append("/");
            fecha.Append(año);
            DateTime fechaHoy = DateTime.Now; 
            DateTime fechaD = DateTime.Parse(fecha.ToString());
            int i =DateTime.Compare(fechaD, fechaHoy);
        }
        
    }
}
