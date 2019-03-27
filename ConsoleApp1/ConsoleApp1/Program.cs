using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      string color,cantidadAux;
      bool Validar;
      int cantidadTinta = 0;
      string dibujo;
      Boligrafo BoligrafoBlue = new Boligrafo(100,ConsoleColor.Blue);
      Boligrafo BoligrafoRed = new Boligrafo(50,ConsoleColor.Red);
      Console.Write("Indique Azul o Rojo");
      color = Console.ReadLine();
     
      Console.Write("Indique la tinta a gastar");
      cantidadAux = Console.ReadLine();
      int.TryParse (cantidadAux,out cantidadTinta);
      if (color == "Azul")
      {
        Validar = BoligrafoBlue.Pintar(cantidadTinta,out dibujo);
        if (Validar == true)
        {
          Console.ForegroundColor = BoligrafoBlue.GetColor();
          Console.WriteLine(dibujo+"\n");
          Console.WriteLine("La cantidad de tinta es de: " + BoligrafoBlue.GetTinta());
        }
        else
        {
          Console.ForegroundColor = BoligrafoBlue.GetColor();
          Console.WriteLine(dibujo + "\n");
          Console.WriteLine("La cantidad es insuficiente");
          BoligrafoBlue.Recargar();
        }
      }
      else if (color == "Rojo")
      {
        Validar = BoligrafoRed.Pintar(cantidadTinta, out dibujo);
        if (Validar == true)
        {
          Console.ForegroundColor = BoligrafoRed.GetColor();
          Console.WriteLine(dibujo + "\n");
          Console.WriteLine("La cantidad de tinta es de: " + BoligrafoRed.GetTinta());
        }
        else
        {
          Console.ForegroundColor = BoligrafoRed.GetColor();
          Console.WriteLine(dibujo + "\n");
          Console.WriteLine("La cantidad es insuficiente");
          BoligrafoRed.Recargar();
        }
      }
      Console.ReadKey();
    } 
  }
}
