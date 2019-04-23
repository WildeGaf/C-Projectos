using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Llamada
  {
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    protected float Duracion
    {
      get
      {
        return this.duracion;
      }
    }

    protected string NroDestino
    {
      get
      {
        return this.nroDestino;
      }
    }

    protected string NroOrigen
    {
      get
      {
        return this.nroOrigen;
      }
    }

    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }

    public string Mostrar()
    {
      string auxDuracion;
      StringBuilder sb = new StringBuilder();
      auxDuracion = Convert.ToString(this.duracion);
      sb.AppendFormat("Duracion: {0}, Nro Origen: {1}, Nro Destino: {2}", auxDuracion, this.nroOrigen, this.nroDestino);
      return sb.ToString();
    }

    public int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
    {
      List <Llamada> OrdenarDuracion = new List <Llamada>();
      OrdenarDuracion.add(llamada1(llamada1.duracion));
      OrdenarDuracion.add(llamada1(llamada2.duracion));
    }

  }
}
