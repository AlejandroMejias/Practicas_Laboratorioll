using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia_4
{
    //Un número perfecto es un entero positivo, que es igual a la suma de
    //todos los enteros positivos(excluido el mismo) que son divisores del
    //número.El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
    //Escribir una aplicación que encuentre los 4 primeros números perfectos.Nota: Utilizar estructuras
    //repetitivas y selectivas.
    class Program
    {
        private const string title = "Ejercicio de la guia: 4";
        static void Main(string[] args)
        {
            Console.Title = title;

            const int iterations = 8;
            const int baseNumber = 2;
            int countPrime = 0;
            int primeNumber;
            int perfectNumber;
            Console.WriteLine("Los primeros cuatro numeros perfectos son :");
            for (int i = 2; i < iterations; i++)
            {
                for(int k = 1; k < iterations; k++)
                {
                    if(i % k == 0)
                    {
                        countPrime++;
                    }
                }
                if(countPrime == 2)
                {
                    primeNumber = i;
                    perfectNumber = ((int)Math.Pow(baseNumber, primeNumber - 1)) * ((int)Math.Pow(baseNumber, primeNumber) - 1);
                    Console.WriteLine("{0}", perfectNumber);
                }
                countPrime = 0;
            }
            Console.ReadKey();
        }
    }
}
