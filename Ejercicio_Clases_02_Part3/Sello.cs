using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases_02_Part3
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        //Constructor
        public Sello( string mensaje , ConsoleColor color )
        {
            Sello.mensaje = mensaje;
            Sello.color = color;
        }

        //Metodos

        public static string Imprimir() => FormatoMensaje();
        public static void Borrar() => Console.WriteLine(Sello.mensaje = "");
        public static ConsoleColor ImprimirEnColor() => Console.ForegroundColor = Sello.color;
        //Formato mensaje 
        private static string FormatoMensaje()
        {
            string format = "*";
            int longitud = Sello.mensaje.Length;
            for (int i = 0; i < longitud + 1; i++)
            {
                format += "*";
            }
            return String.Format(
                "{0}\n"+
                "*{1}*\n"+
                "{2}\n",format,Sello.mensaje,format
                );
        }
    }
}
