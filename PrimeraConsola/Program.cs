﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaz de consola con opciones repetidas hasta interrupción voluntaria

            Console.WriteLine("Bienvenido a la aplicación de consola!");
            Console.WriteLine("--------------------------------------");

            while (true)
            {
                // Mensajes al usuario
                Console.WriteLine("Por favor elija una opción:\n");
                Console.WriteLine("a) Una opción prioritaria");
                Console.WriteLine("b) Una opción secundaria");
                Console.WriteLine("x) salir");

                string opcion = Console.ReadLine(); // Lectura desde el teclado a variable opcion

                // Revisar las opciones y sus procesos
                switch (opcion) // opcion = c
                {
                    case "a":
                        // ejecutar alguna línea de código
                        Console.WriteLine("Eligió la opción a");
                        break;
                    case "b":
                        Console.WriteLine("Eligió la opción b");
                        break;
                    case "x":
                        Environment.Exit(0); // 0 = SIN ERRORES, SALIDA NORMAL
                        break;
                    default:
                        Console.WriteLine("No existe la opción seleccionada.");
                        break;

                }

                Console.ReadKey(); // Pedir al usuario que ingrese un caracter (pero no se guarda)
                Console.Clear();
            }            
        }
    }
}
