using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases_02_Part1
{
    class Sello
    {
        public static string mensaje;

        public Sello(string mensaje)
        {
            Sello.mensaje = mensaje;
        }
        //Imprimir

        public static string Imprimir() => Sello.mensaje;

        //Borrar

        public static void Borrar() => Console.WriteLine(Sello.mensaje = "");
    }
}
