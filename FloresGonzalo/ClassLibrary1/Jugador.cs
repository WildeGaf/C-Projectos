using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  class Jugador : Persona
  {
    private float peso;
    private float altura;
    private Posicion posicion;

    public float Peso
    {
      get { return this.peso; }
      set { this.peso = value; }
    }

    public float Altura
    {
      get { return this.altura; }
      set { this.altura = value; }
    }

    public Posicion Posicion
    {
      get { return this.posicion; }
      set { this.posicion = value; }
    }

    public Jugador(string apellido, string nombre, int edad, int dni, float altura,float peso) : base(apellido, nombre, edad, dni)
    {
      this.Altura = altura;
      this.Peso = peso;
    }


    public override string Mostrar()
    {
      StringBuilder jgBuilder = new StringBuilder(base.Mostrar());
      jgBuilder.Append(" Altura: "+ this.Altura);
      jgBuilder.Append(" Peso: "+ this.Peso);
      return jgBuilder.ToString();
    }

    public override bool ValidarAptitud()
    {
      return this.Edad < 40 && EstadoFisico();
    }

    public bool EstadoFisico()
    {
      double mult, resultado;
      mult = Math.Pow(this.Altura, 2);
      resultado = this.Peso / mult;
      if (resultado > 18.5 && resultado <= 25)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
