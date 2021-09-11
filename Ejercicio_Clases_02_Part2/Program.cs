using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases_02_Part2
{
    class Program
    {
        //_Parte 2:

        //clase Sello
        //(+) mensaje : string
        //(+) color : ConsoleColor
        //(+) Imprimir() : string
        //(+) Borrar() : void
        //(+) ImprimirEnColor() : void
        //Main()
        //Sello.mensaje = "hola mundo"
        //Sello.Imprimir();//retorna string
        //Sello.Borrar();
        //Sello.Imprimir();//retorna string
        //Sello.mensaje = "hola mundo C#"
        //Sello.color = ConsoleColor.Red;
        //Sello.ImprimirEnColor();
        //Sello.Imprimir();//retorna string
        static void Main(string[] args)
        {
            const string titulo = "Ejercicio de clases 02, parte 2";
            string mensaje = "Por ahora no tengo nombre";

            Console.Title = titulo;

            Sello.mensaje = "Hola " + mensaje;
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            mensaje = "HOLA!! Soy Alejandro Mejias";
            Sello.mensaje = mensaje;
            Sello.color = ConsoleColor.Blue;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            //Reseteo al color original
            mensaje = "Hola, volvi a mi color original y no tengo nombre";
            Sello.mensaje = mensaje;
            Sello.color = ConsoleColor.Gray;
            Sello.ImprimirEnColor();
            Console.Write(Sello.Imprimir());



            Console.ReadKey();
        }
    }
}
