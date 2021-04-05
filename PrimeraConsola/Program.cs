using System;
using LibreriaMatematicaNET48;

namespace PrimeraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaz de consola con opciones repetidas hasta interrupción voluntaria

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("* Bienvenido a la aplicación de consola! *");
            Console.WriteLine("------------------------------------------");

            while (true)
            {
                // Mensajes al usuario
                Console.WriteLine("Por favor elija una opción:\n");
                Console.WriteLine("a) Una opción prioritaria");
                Console.WriteLine("b) Una opción secundaria");
                Console.WriteLine("c) Convertir US$ a $CLP");
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
                    case "c":
                        // entrada
                        Console.WriteLine("Ingrese la cantidad de dólares a convertir a peso chileno:");
                        string dolares = Console.ReadLine();

                        // proceso                        
                        // int dolaresConvertidos = Convert.ToInt32(dolares); // Método desde clase convert
                        // Conversión en base a tipos (Int32, Double, String) Clases desde System
                        if (Int32.TryParse(dolares, out int dolaresConvertidos)) // Comprobación desde clase de tipo
                        {
                            string totalConvertidoAClp = ConversorDolarAPesoChileno.Convertir(dolaresConvertidos).ToString(); // Conversión directa a String

                            // salida
                            //Console.WriteLine("El total convertido a CLP es:" + totalConvertidoAClp); // Método antiguo de concatenación
                            Console.WriteLine($"El total convertido a CLP es: ${totalConvertidoAClp}.-");
                        }
                        else // En caso de no poder convertir, enviar mensaje a usuario
                        {
                            Console.WriteLine($"No se pudo convertir el valor {dolares}, por favor ingrese un valor válido");
                        }

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
