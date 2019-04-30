using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  class Equipo
  {
    private List<Jugador> jugadores;
    private static int cantidadMaximajugadores = 6;
    private DirectorTecnico directorTecnico;
    private string nombre;


    public string Nombre
    {
      get { return nombre; }
    }

    public DirectorTecnico DirectorTecnico
    {
      set { directorTecnico = value; }
    }

    public Equipo()
    {
      this.jugadores = new List<Jugador>();
    }

    public Equipo(string nombre) : this()
    {
      this.nombre = nombre;
    }

    public static explicit operator string(Equipo A)
    {
      StringBuilder cadenaEquipo = new StringBuilder();
      cadenaEquipo.AppendFormat("Nombre: {0}, Lista jugadores: {1}, Director Tecnico: {2}", A.Nombre , A.jugadores, A.directorTecnico);
      return cadenaEquipo.ToString();
    }

  }
}
