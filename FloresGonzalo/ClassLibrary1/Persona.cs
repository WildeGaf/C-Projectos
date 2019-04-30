using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Persona
  {

    private string apellido;
    private int dni;
    private int edad;
    private string nombre;

    public string Apellido
    {
      get { return apellido; }
    }

    public int Dni
    {
      get { return dni; }
    }

    public int Edad
    {
      get { return edad; }
    }

    public string Nombre
    {
      get { return nombre; }
    }

    public virtual string Mostrar()
    {
      StringBuilder cadenaPersona = new StringBuilder();
      cadenaPersona.AppendFormat("Apellido: {0},Nombre: {1}, Edad: {2}, Dni: {3}", this.Apellido, this.Nombre, this.Edad, this.Dni);
      return cadenaPersona.ToString();
    }

    public Persona(string apellido, string nombre, int edad, int dni)
    {
      this.apellido = apellido;
      this.nombre = nombre;
      this.dni = dni;
      this.edad = edad;
    }

    public abstract bool ValidarAptitud();

  }
}
