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

            Console.WriteLine("Este es un mensaje del main");
            
            Console.WriteLine("el resultado de la suma es: "+sumaNumeros(1,2));

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

    }
}
