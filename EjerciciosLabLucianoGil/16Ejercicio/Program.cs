using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Ejercicio
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno alumno1 = new Alumno();
      Alumno alumno2 = new Alumno();
      Alumno alumno3 = new Alumno();
      alumno1.nombre = "luciano";
      alumno1.apellido = "gil";
      alumno1.legajo = 40901;
      alumno1.Estudiar(4, 5);
      Console.WriteLine(alumno1.Mostrar());
      Console.ReadKey();
      alumno1.CalcularFinal();
      Console.WriteLine(alumno1.Mostrar());
      Console.ReadKey();
      
     }
  }
}
