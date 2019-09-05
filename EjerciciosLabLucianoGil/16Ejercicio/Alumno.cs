using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Ejercicio
{
  public class Alumno
  {
    private byte nota1;
    private byte nota2;
    private float notaFinal;
    public string apellido;
    public string nombre;
    public int legajo;

    public void CalcularFinal()
    {
      if (this.nota2 >= 4 && this.nota1 >= 4)
      {
        Random numeroA = new Random();
        this.notaFinal = numeroA.Next(4, 10);
      }
      else
        this.notaFinal = -1;
     }
    public void Estudiar(byte notaUno,byte notaDos)
    {
      this.nota1 = notaUno;
      this.nota2 = notaDos;
    }
    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("nombre es \n");
      sb.Append(this.nombre + "\n");
      sb.Append("apellido es \n");
      sb.Append(this.apellido + "\n");
      sb.Append("leagjo es \n");
      sb.Append(this.legajo+"\n");
      sb.Append("nota1 \n");
      sb.Append(this.nota1 + "\n");
      sb.Append("nota2 \n");
      sb.Append(this.nota2 + "\n");
      sb.Append("notaFinal es \n");
      sb.Append(this.notaFinal + "\n");

      return sb.ToString();
    }

  }
}
