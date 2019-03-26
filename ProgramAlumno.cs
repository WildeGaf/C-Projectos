using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Flores","Gonzalo");
            Alumno alumno2 = new Alumno("asd", "qwe");
            Alumno alumno3 = new Alumno("zxc", "vbn");
            alumno1.Estudiar(5,8);
            alumno2.Estudiar(2,6);
            alumno3.Estudiar(10,7);
            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();
            Alumno.colegio = "UTN";
            // alumno1.apellido = "Perez";
            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            Console.ReadKey();
        }
    }

}

