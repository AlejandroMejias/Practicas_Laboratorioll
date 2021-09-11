using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia_1
{
    //Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular
    //y mostrar: el valor máximo, el valor mínimo y el promedio.
    class Program
    {
        static void Main(string[] args)
        {

            int number;
            int largestNumber = 0;
            int smallestNumber = 0;
            int sum = 0;
            bool isFirtEnter = true;

            Console.Title = "Ejercicio de la guia : 1";
            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero " + ( i + 1 ) +  ":");
                number = int.Parse(Console.ReadLine());
                if( isFirtEnter)
                {
                    largestNumber = number;
                    smallestNumber = number;
                    isFirtEnter = false;
                }
                else
                {
                    if(number > largestNumber)
                    {
                        largestNumber = number;
                    }else if(number < smallestNumber)
                    {
                        smallestNumber = number;
                    }

                }
                sum += number;
            }

            Console.Clear();
            Console.WriteLine("El numero mayor ingresado fue: " + largestNumber);
            Console.WriteLine("El numero menor ingresado fue: " + smallestNumber);
            Console.WriteLine("La suma total registrada fue:" + sum);
            Console.WriteLine("El promedio total es:" + (float)sum / 5  );

            Console.ReadKey();
        }
    }
}
