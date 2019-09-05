using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write(Conversor.BinarioDecimal(Console.ReadLine()));
      Console.ReadKey();
      Console.WriteLine("////////////");
      double.TryParse(Console.ReadLine(), out double num);
      Console.WriteLine(Conversor.DecimalBinario(num));
      Console.ReadKey();
    }
  }
}
