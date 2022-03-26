using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mensajeEnPantalla();

          //  Console.WriteLine("Este es un mensaje del main");

            Console.WriteLine("ingresa el primer numero");

            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ingresa el segundo numero");

            int num2 = int.Parse(Console.ReadLine());  
            
            Console.WriteLine("el resultado de la suma es: "+sumaNumeros(num1,num2));

            Console.ReadKey();

        }
        
        //metodo mensajeEnPantalla() void no devuelve ningun valor
        static void mensajeEnPantalla()
        {


           Console.WriteLine( "Este es un mensaje desde el metodo mensajeEnPantalla" );
        }

         static int sumaNumeros(int num1,int num2)
        {
            int resultado = num1+num2;

            return resultado;

             
        }

        //static int otraformadehacermetodos (int numerouno,int numerodos) => numerouno + numerodos; 

    }
}
