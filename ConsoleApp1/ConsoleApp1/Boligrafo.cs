using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Boligrafo
  {
    private ConsoleColor color;
    private short tinta;
    public const short CantidadTintaMaxima = 100;

    public  Boligrafo(short tinta, ConsoleColor color)
    {
      this.tinta = tinta;
      this.color = color;
    }


    public ConsoleColor GetColor()
    {
      return this.color;
    }

    public short GetTinta()
    {
      return this.tinta;
    }

    public bool Pintar(int gasto, out string dibujo)
    {
      bool Validar = false;
      short tinta;
      int i, tot;
      dibujo = " ";
      tinta = this.GetTinta();
      if (gasto < tinta){
        Validar = true;
        tot = this.GetTinta() - (short)gasto;
        this.SetTinta((short)tot);
      }
      else
      {
        tot = (short)gasto - tinta;
        this.SetTinta(0);
      }
      for (i = 0; i < gasto; i++)
      {
        dibujo += '*';
      }
      return Validar;
    }



  public void Recargar()
  {
    this.SetTinta(CantidadTintaMaxima);
  }

  private void SetTinta(short tinta)
  {
    if (tinta > 0 && tinta <= CantidadTintaMaxima)
    {
      this.tinta = tinta;
    }
  }

}

}
