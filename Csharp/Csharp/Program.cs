using System;

namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
              //Escribir en pantalla

            Console.WriteLine("Hola Mundo");
        



            //declarar una variable e inicializarla en una misma linea

            int edad=22;
            Console.WriteLine(edad);



            

            //operadores aritmeticos

            Console.WriteLine(7*5);
            Console.WriteLine(7-5);
            Console.WriteLine(7.0/5.0);
            Console.WriteLine(7+5);
            Console.WriteLine(7%5);



            
            //realizar una interpolacion de Strings

            int edad1=19;

            Console.WriteLine($"Tienes una edad de {edad1} años");






            //operador incremento y decremento
             Console.WriteLine($"Tienes una edad de {++edad1} años");
            
            edad1++;
            
            Console.WriteLine(edad1);
            
            edad +=8;

            Console.WriteLine(edad1);





            //operador "=" o asignacion 
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;
            
            edadPersona1=edadPersona2=edadPersona3=edadPersona4=27;

            Console.WriteLine(edadPersona3);





            //Declaración implicita de variables

            var edadpersona = 27;
            Console.WriteLine(edadpersona);
            //var edadpersona = 27.5 no se puede modificar valor








            //conversiones Explicita o Casting

            double temperatura = 34.5;

            int temperaturaMadrid;
            temperaturaMadrid=(int)temperatura;
            Console.WriteLine(temperaturaMadrid);






            //conversiones implicitas osea del mismo tipo de datos compatibles

            int habitantesCiudad=10000;

            long habitantesCiudad2022 = habitantesCiudad;

            float pesoMaterial = 5.78F;
            double persoMaterialPrec=pesoMaterial;




          
              
            //Convertir de texto a numeros
   
            Console.WriteLine("Ingresa el primer valor numerico");

            int num1 = int.Parse(Console.ReadLine());

          /*  int resultado = num1+8;
            Console.WriteLine(resultado);*/

            Console.WriteLine("Ingresa el segundo valor numerico");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("el resultado es "+(num1+num2));





            //constantes ·····OSEA VALORES QUE NO CAMBIAN·····

            const int VALOR = 5;

            const int VALOR2 = 7;

            //SE PUEDE PONER COMO SEGUNDO ARGUMENTO O PARAMETRO SIN NECESIDAD DE CONCATENAR

            Console.WriteLine("El valor de la constante es: {0},{1}", VALOR,VALOR2);  

         

            //Calcular el area en funcion del radio

            const double PI = 3.1416;
            Console.WriteLine("Introduce la medida del radio");
           double radio=double.Parse(Console.ReadLine());
            double area = Math.Pow(radio,2) * PI;
            Console.WriteLine($"el area del cirulo es {area}");
            
            //hacer una pausa en el programa

            Console.ReadKey();

        }
    }
}
