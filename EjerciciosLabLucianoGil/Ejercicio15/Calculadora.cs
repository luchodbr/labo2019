using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
  public class Calculadora
  {
    public static double Calcular(double numero1, double numero2, char c)
    {
      double resultado=0;


      switch (c)
      {
        case '+':
          resultado = numero1 + numero2;
          break;
        case '-':
          resultado = numero1 - numero2;
          break;
        case '*':
          resultado = numero1 * numero2;
          break;
        case '/':
          if (Validar(numero2))
          {
            resultado = numero1 / numero2;
          }
          else
            resultado = 888888888888;
          break;
        default:
          break;
          
      }
      return resultado;
    }
    private static bool Validar(double num2)
    {
      if (num2 == 0)
      {
        return false;
      }
      return true;
    }
  }
}
