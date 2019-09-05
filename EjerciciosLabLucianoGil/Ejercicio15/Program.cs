using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
  class Program
  {
    static void Main(string[] args)
   {
      Console.WriteLine(Calculadora.Calcular(12, 2, '+'));
      Console.ReadKey();
      Console.WriteLine(Calculadora.Calcular(12, 2, '-'));
      Console.ReadKey();
      Console.WriteLine(Calculadora.Calcular(12, 2, '*'));
      Console.ReadKey();
      Console.WriteLine(Calculadora.Calcular(10, 0, '/'));
      Console.ReadKey();
    }
  }
}
