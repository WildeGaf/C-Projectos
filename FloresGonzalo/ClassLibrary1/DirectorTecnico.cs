using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class DirectorTecnico : Persona
  {
    private int añosExperiencia;

    public int AñosExperiencia
    {
      get { return añosExperiencia; }
      set { añosExperiencia = value; }
    }

    public DirectorTecnico(string apellido, string nombre, int edad, int dni, int añosDeExperiencia) : base(apellido, nombre, edad, dni)
    {
      this.añosExperiencia = añosDeExperiencia;
    }

    public override string Mostrar()
    {
      StringBuilder dtBuilder = new StringBuilder(base.Mostrar());
      dtBuilder.Append(" Años de experiencia: " + this.AñosExperiencia);
      return dtBuilder.ToString();
    }

    public override bool ValidarAptitud()
    {
      return this.Edad < 65 && this.añosExperiencia >= 2;
    }

  }
}
