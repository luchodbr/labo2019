using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
  public static class CalculoDeArea
  {
    public static double CalcularArea(double lado)
    {
      return (Math.Pow(lado, 2));

    }
    public static double CalcularCubo(double base1, double altura)
    {
      return (base1 * altura) / 2;

    }
    public static double CalcularCirculo(double rad)
    {
      return 3.14 * (Math.Pow(rad, 2));
    }
  }
}
