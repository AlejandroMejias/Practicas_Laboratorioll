using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases_02_Part2
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public Sello(string mensaje , ConsoleColor color)
        {
            Sello.mensaje = mensaje;
            Sello.color = color;
        }
        //Imprimir

        public static string Imprimir() => Sello.mensaje;
        //Borrar
        public static void Borrar() => Console.WriteLine(Sello.mensaje = "");

        //ImprimirEnColor
        public static void ImprimirEnColor() => Console.ForegroundColor = Sello.color;

    }
}
