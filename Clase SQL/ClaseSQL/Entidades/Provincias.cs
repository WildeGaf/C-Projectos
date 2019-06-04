using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Provincia
  {
    public string nombre;
    public int id;

    public int Id
    {
      get { return id; }
      set { id = value; }
    }

    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }

    public Provincia(string nombre, int id)
    {
      this.id = Id;
      this.nombre = Nombre;
    }

    public override string ToString()
    {
      return this.Nombre;
    }
  }
}
