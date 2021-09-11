using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases_02_Part1
{
    class Program
    {
        //_ Parte 1:

        //clase Sello
        //(+) mensaje : string

        //(+) Imprimir() : string ---> return Sello.mensaje;
        //(+) Borrar() : void -----> Sello.mensaje = "";
        //Main()
        //Sello.mensaje = "hola mundo"
        //Sello.Imprimir();//retorna string
        //Sello.Borrar();

        static void Main(string[] args)
        {
            const string titulo = "Ejercicio de la clase 2";
            const string nombre = "Alejandro Mejias";
            Console.Title = titulo;

            Sello.mensaje = "Hola, me llamo " + nombre;
            Console.WriteLine(Sello.Imprimir());

            //Borrar
            Sello.Borrar();
            Sello.mensaje = "Ya no me llamo asi, esta funcionando todo pa!!!";
            Console.WriteLine(Sello.Imprimir());


            Console.ReadKey();
        }
    }
}
