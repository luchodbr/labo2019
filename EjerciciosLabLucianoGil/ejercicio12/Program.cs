using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
  class Program
  {
    static void Main(string[] args)
    {
      int numeroFinal=0;
      string resp1 ="";
      Console.Write("ingrese un numero");
      int.TryParse(Console.ReadLine(), out int numero1);
      do
      {
        Console.Write("ingrese otro numero");
        int.TryParse(Console.ReadLine(), out int numero2);
        if (resp1 == "s")
          numeroFinal = numeroFinal + numero2;
        else
          numeroFinal = numero1 + numero2;

        Console.WriteLine("su resultado hasta ahora es {0} Desea seguir sumando?, ingrese 's' o 'n'", numeroFinal);
        resp1 = Console.ReadLine();
        while (resp1.Length > 1 || resp1 == "")
        {
          Console.WriteLine("ingrese 's' o 'n'");
          resp1 = Console.ReadLine();
        }
      } while (ValidarRespuesta.ValidaS_N(char.Parse(resp1)));
      Console.WriteLine("su resultado final es {0}", numeroFinal);
      Console.ReadKey();
    }
  }
}
