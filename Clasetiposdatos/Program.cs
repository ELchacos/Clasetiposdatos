using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Clasetiposdatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a single-line comment
            int num1 = 10;
            int num3, num4;
            float flotanteno = 3.14f;
            char caracter = 'A';
            string cadena = "Hola, mundo!";
            bool boleano = true;



            cadena.ToUpper();


            var variable = 42; // The type of 'variable' is inferred as int

            dynamic dinamica = 30; //tipo de dato dinamico
            dinamica = "Ahora soy una cadena"; // Now 'dinamica' is a string
            dinamica = 3.14; // Now 'dinamica' is a double
            dinamica = true; // Now 'dinamica' is a bool

            string nombre = "ismael";
            Console.WriteLine("yo me llamo: " + nombre);

            string apellido;
            Console.Write("ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("su nombre completo es: " + nombre + " " + apellido); //cocatenacion de cadenas 
            Console.WriteLine($"su nombre completo es: {nombre} {apellido}"); //interpolacion de cadenas
            Console.WriteLine("su nombre completo es: {0} {1}", nombre, apellido); //formato de cadenas

            byte edad;
            float salario;
            double estatura;

            Console.WriteLine("ingrese su edad: ");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("Su nombre completo y edad es " + nombre + " " + apellido + " y su edad es: " + edad);

            Console.WriteLine("dijite un numero flotante: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("dijite otro numero flotante: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num3) //si el numero 1 es mayor que el numero 3
            {
                Console.WriteLine($"el numero mayor es: {num1}");
            }
            else if (num1 < num3) // numer 2 es mayor que el numero 1
            {
                Console.WriteLine($"el numero mayor es: {num3}");
            }
            else
            {
                Console.WriteLine($"El numero {num1} es igual al numero {num3}");


                float resultado = num1 + num3;
                Console.WriteLine($"la suma es: {resultado}");
                resultado -= num1 - num3;
                Console.WriteLine($"la resta es: {resultado}");









            }
        }
    }
}





