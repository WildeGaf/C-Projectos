using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;
        public static string colegio;
        static Random rnd;

        public Alumno(string apellido, string nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        static Alumno()
        {
            colegio = "UTN";
            rnd = new Random();
        }

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4){
                this.notaFinal = rnd.Next(1, 6);
            } 
            else
            {
                this.notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            //CONDICION ? VERDADERO:FALSO


            return this.legajo.ToString() + "-" + this.apellido + " " +
                this.nombre + " " + colegio + " " + this.nota1 + " " + this.nota2 + " "+
            (this.notaFinal == -1 ? "DESAPROBADO" : this.notaFinal.ToString());
        }
    }
}
//Usar siempre this cuando se quiere acceder a un atributo de la misma clase.