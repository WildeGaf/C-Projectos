using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Conversor
    {


        public static string BinarioEntero(int numero)
        {
            while (numero % 2 == 0 || numero % 2==1)
            {
                resto = numero % 2;
                numero = numero / 2;
                
                if (resto == 0)
                {
                    acumulador = 0 + acumulador;
                }
            }
        }


        public static double EnteroBinario(string numero)
        {


        }




    }
}
