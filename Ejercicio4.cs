using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int acumulador = 0;
            int contador = 0, i, j;
            while (contador != 4)
            {
                numero++;
                for (i = numero; i != 0; i--)
                {
                    acumulador = 0;
                    if (i != 1)
                    {
                        for (j = i - 1; j != 0; j--)
                        {
                            if (i % j == 0)
                            {
                                acumulador = acumulador + j;
                            }

                        }
                        if (acumulador == numero)
                        {
                            contador++;
                            Console.WriteLine(i);
                        }

                    }



                }



            }
            Console.ReadKey();
        }
    }
}