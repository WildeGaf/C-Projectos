using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
  public class Persona
  {
    public string nombre;
    public string apellido;
    public string dni;

    public Persona (string nombre, string apellido, string dni)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.dni = dni;
    }

    public Persona() {
      this.nombre = " ";
      this.apellido = " ";
      this.dni = " ";
    }


    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(" Nombre: "+this.nombre);
      sb.AppendLine(" Apellido: " + this.apellido);
      sb.AppendLine(" Dni: " + this.dni);
      sb.AppendLine(" ");

      return sb.ToString();
    }

  }
}
