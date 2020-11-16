using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstructuraCondicionalSimple1
{
    class Program
    {
        //Ingresar el sueldo de una persona, si supera los 3000 pesos mostrar un mensaje en pantalla indicando que debe abonar impuestos.
        // Tarea: Preparar un ejercicio que dentro de una funcion use  un condicional
        static void Main(string[] args)
        {
            float sueldo;
            string linea;
            Console.Write("Ingrese el sueldo:");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            if (sueldo > 3000)
            {
                Console.Write("Esta persona debe abonar impuestos");
            }
            Console.ReadKey();
        }
    }
}
