using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static int miEntero;
    static string miString;

    static void Main(string[] args)
    {
      //miEntero = miDouble; // no se puede ya que se perderian datos, al ser el double de mayor bites
      //miEntero = (int)miDouble; // Se castea para pasar la variable a int
      //miDouble = miEntero;
      //miString = miBoolean.toString(); //
      ///miEntero = int.Parse(miString); // pasar un string a un entero.
      //if (int.TryParse(miString, out miEntero)) //CONTROL K Y D TE ORDENA EL TAB 
      //{
      //} // este metodo retorna true o false. Verifica si es posible parsear
        // alt 124 para hacer la barra del o ||

      /* foreach (string auxNombre, in nombres) recorre un arreglo, pero no se pueden eliminar o agregar un valor
      se puede utilizar para mostrar un valor, modificar.. o guardar el indice para luego borrarlo */
      Console.WriteLine("Calculadora, 1-suma 2-resta 3-multiplicacion 4-division");
      //ConsoleKeyInfo var = Console.ReadKey();
      // Console.WriteLine(var.Key);
      miString =  Console.ReadLine();
      miEntero = int.Parse(miString); 
      calculadora(miEntero);
    }


    static void calculadora(int valor)
    {
      string numero;
      int valor1,valor2;
      int resultado;

      switch (valor)
      {
        case 1:
          System.Console.WriteLine("Indique el primer numero a sumar");
          numero = Console.ReadLine();
          int.TryParse(numero, out valor1);
          System.Console.WriteLine("Indique el segundo numero a sumar");
          numero = Console.ReadLine();
          int.TryParse(numero, out valor2);
          resultado = valor1 + valor2;
          Console.WriteLine("La suma es de "+ resultado);
          Console.ReadKey();
          break;
        case 2:
          System.Console.WriteLine("Indique el primer numero a sumar");
          numero = Console.ReadLine();
          int.TryParse(numero, out valor1);
          System.Console.WriteLine("Indique el segundo numero a sumar");
          numero = Console.ReadLine();
          int.TryParse(numero, out valor2);
          resultado = valor1 - valor2;
          Console.WriteLine("La resta es de "+ resultado);
          Console.ReadKey();
          break;
        case 3:
          System.Console.WriteLine("Indique el primer numero a sumar");
          numero = Console.ReadLine();
          int.TryParse(numero, out valor1);
          System.Console.WriteLine("Indique el segundo numero a sumar");
          numero = Console.ReadLine();
          int.TryParse(numero, out valor2);
          resultado = valor1 * valor2;
          Console.WriteLine("La suma es de " + resultado);
          Console.ReadKey();
          break;
        case 4:
          System.Console.WriteLine("Indique el primer numero a sumar");
          numero = Console.ReadLine();
          int.TryParse(numero, out valor1);
          System.Console.WriteLine("Indique el segundo numero a sumar");
          numero = Console.ReadLine();
          int.TryParse(numero, out valor2);
          resultado = valor1 / valor2;
          Console.WriteLine("La suma es de " + resultado);
          Console.ReadKey();
          break;
        default :
          System.Console.WriteLine("No ha ingresado un numero valido");
         break;
      }
    }
  }
}
