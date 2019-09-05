using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
  public class Conversor
  {
    public static string BinarioDecimal(string binario)
    {
      string stringNumero = "";
      int cantidadDeCifras;
      bool numeroValido;
      numeroValido = double.TryParse(binario, out double numeroDecimal);

      if (numeroValido)
      {
        cantidadDeCifras = binario.Length;
        numeroDecimal = 0;
        for (int i = 0; i < cantidadDeCifras; i++)
        {
          if (binario.ElementAt(i) == '1')
          {
            numeroDecimal = numeroDecimal + Math.Pow(2, cantidadDeCifras - i - 1);
          }
          else if (binario.ElementAt(i) != '0')
          {
            return "Numero invalido";
          }
        }

        stringNumero = numeroDecimal + "";
      }
      else
        stringNumero = "Numero invalido";

      return stringNumero;
    }

    public static string DecimalBinario(double numero)
    {
      string numeroBinario = "";
      if (numero > 0)
      {
        while (numero > 0)
        {
          if (numero % 2 == 0)
          {
            numeroBinario = "0" + numeroBinario;
          }
          else
          {
            numeroBinario = "1" + numeroBinario;
          }
          numero = (int)numero / 2;
        }
      }
      else if (numero == 0)
      {
        numeroBinario = "0";
      }
      else
      {
        numeroBinario = "No se pudo convertir a binario";
      }

      return numeroBinario;
    }
  }
}
