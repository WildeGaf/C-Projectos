using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public Universitario()
        {

        }

        public Universitario(int legajo,string nombre, string apellido, string dni,ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }


    }



}
