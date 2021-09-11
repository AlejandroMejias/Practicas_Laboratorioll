using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia_3
{
   // Mostrar por pantalla todos los números primos que haya hasta el número que ingrese
   //el usuario por consola. Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).

    class Program
    {
        private const string title = "Ejercicio de la guia: 3";
        static void Main(string[] args)
        {
            Console.Title = title;

            int primeNumber = 0;
            string number;
            bool isValid;

            Console.WriteLine("Ingrese el número hasta donde se contaran los numeros primos:");
            number = Console.ReadLine();
            isValid = Int32.TryParse( number , out int validatedNumber);

            while( !(isValid) && validatedNumber < 1)
            {
                Console.Clear();
                Console.WriteLine("ERROR! Ingrese correctamente el número hasta donde se contaran los numeros primos:");
                number = Console.ReadLine();
                isValid = Int32.TryParse(number, out validatedNumber);
            }
            Console.Clear();

            for(int i = 2; i < validatedNumber + 1; i++)
            {
                for( int k = 1; k <= validatedNumber; k++)
                {
                    if( i % k == 0)
                    {
                        primeNumber++;
                    }
                }
                if( primeNumber == 2)
                {
                    Console.WriteLine("{0} Es un numero primo", i);
                }
                primeNumber = 0;
            }


            Console.ReadKey();
        }
    }
}
