using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia_2
{
    //Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar 
    //que el número sea mayor que cero, caso contrario, mostrar el mensaje: 
    //"ERROR. ¡Reingresar número!". Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title= "Ejercicio de la guia:2";

            bool isValid;
            int squaredNumber;
            int cubedNumber;
            string number;

            Console.WriteLine("Ingrese que número desea mostrar:");
            number = Console.ReadLine();
            isValid = Int32.TryParse(number, out int validatedNumber);

            while ( !(isValid) && validatedNumber < 1)
            {
                Console.Clear();
                Console.WriteLine("ERROR! Ingrese correctamente el numero que desea mostrar:");
                number = Console.ReadLine();
                isValid = Int32.TryParse(number, out validatedNumber);
            }
            squaredNumber = (int)Math.Pow(validatedNumber, 2);
            cubedNumber = (int)Math.Pow(validatedNumber, 3);
            Console.Clear();
            Console.WriteLine(
                "El numero ingresado fue {0}\n" +
                "{0} al cuadrado es: {1}\n" +
                "{0} al cubo es: {2}", validatedNumber,squaredNumber,cubedNumber
            );
            Console.ReadKey();
        }
    }
}
