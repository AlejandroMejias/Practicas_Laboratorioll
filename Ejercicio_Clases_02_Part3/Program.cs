using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases_02_Part3
{
    class Program
    {
        //_Parte 3:

        //clase Sello
        //(+) mensaje : string
        //(+) color : ConsoleColor
        //(+) Imprimir() : string -> ArmarFormatoMensaje
        //(+) Borrar() : void
        //(+) ImprimirEnColor() : void --> Imprimir
        //(-) ArmarFormatoMensaje() : string
        //Main()
        //Sello.mensaje = "hola mundo"
        //Sello.color = ConsoleColor.Red;
        //Sello.ImprimirEnColor();
        //Sello.Imprimir();
        //************
        //*hola mundo*            
        //************
        static void Main(string[] args)
        {
            const string titulo = "Ejercicio clase 02 Parte 3";
            Console.Title = titulo;

            //Sello original
            Console.WriteLine("1) Sello sin tinta\n");
            string mensaje = "Hola Mundo";
            Sello.mensaje = mensaje;
            Console.WriteLine(Sello.Imprimir());
            Console.WriteLine("=====================================");

            // Sello formateado
            Console.WriteLine("2) Sello con tinta\n");
            mensaje = "Me llamo Alejandro y soy Programador";
            Sello.mensaje = mensaje;
            Sello.color = ConsoleColor.DarkMagenta;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
            Console.WriteLine("=====================================");

            //Sello original
            Sello.color = ConsoleColor.Gray;
            Sello.ImprimirEnColor();
            Console.WriteLine("3) Sello original\n");
            mensaje = "Hola Mundo";
            Sello.mensaje = mensaje;
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
        }
    }
}
