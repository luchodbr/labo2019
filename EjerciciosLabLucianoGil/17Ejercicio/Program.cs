using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _17Ejercicio;

namespace _17EjercicioP
{
  class Program
  {
    static void Main(string[] args)
    {
      Boligrafo bol1 = new Boligrafo(ConsoleColor.Blue, 100);
      Boligrafo bol2 = new Boligrafo(ConsoleColor.Red, 0);

      string dib;
      Console.WriteLine(bol1.Tinta);
      Console.ReadKey();
      if(bol1.Pintar(10,out dib))
      {
        Console.ForegroundColor = bol1.Color;
        Console.WriteLine(dib);
        Console.ReadKey();
        Console.WriteLine(bol1.Tinta);
        Console.ReadKey();
        bol1.Recargar();
        Console.WriteLine(bol1.Tinta);
        Console.ReadKey();

      }
    }
  }
}
