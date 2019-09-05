using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Ejercicio
{
  public class Boligrafo
  {
    const short cantidadTintaMaxima = 100;
    ConsoleColor color;
    public ConsoleColor Color { get => color; set { color = value; } }

    short tinta;
    public short Tinta { get => tinta; set { tinta = value; } }

    public Boligrafo(ConsoleColor col, short tint)
    {
      this.Color = col;
      this.Tinta = tint;
    }
    private void SetTinta(short tinta)
    {
      if (tinta + this.tinta <= 0)
        this.tinta = 0;
      if (tinta + this.tinta >= 100)
      {
        this.tinta = 100;
      }
      else if (tinta + this.tinta > 0 && tinta + this.tinta < 100)
        this.tinta = (short)(tinta + this.tinta);
    }
    public void Recargar()
    {
      this.SetTinta(100);
    }

    public bool Pintar(short gast,out string dibujo)
    {
      bool retorno = false;
      dibujo = "";
      short tintAntes = this.tinta;
      this.SetTinta((short)-gast);
      if (this.tinta > 0)
      {
        
        for (int i = tintAntes; i > this.tinta; i--)
        {
          dibujo += "*";
        }
        retorno = true;
      }
      else if(this.tinta == 0 )
      { 
        for (int i = tintAntes; i > this.tinta; i--)
        {
          dibujo += "*";
        }
        retorno = false;
      }
      return retorno;
    }
  }

}

