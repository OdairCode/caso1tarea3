using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso1tarea3
{
    internal class Program
    {
        // Variable para almacenar la nota final (0 a 100)
        static double notafinal = 0;

        // Evalúa la nota y devuelve si aprueba o reprueba
        static string evaluarcurso(double nota)
        {
            if (nota >= 70)
            {
                return "aprobado";
            }
            else
            {
                return "reprobado";
            }
        }

        //procesa la nota del estudiante y muestra el resultado
        static void procesarnota()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=======================================");
            Console.WriteLine("         Notas de Estudiantes          ");
            Console.WriteLine("=======================================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Ingrese la nota final del estudiante (0-100): ");

            // Validación de ingreso de texto / caracteres no numéricos
            if (!double.TryParse(Console.ReadLine(), out notafinal))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Debe ingresar un número válido, no texto o símbolos.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Validación de rango de 0 a 100
            else if (notafinal < 0 || notafinal > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: La nota ingresada esta fuera del rango permitido (0 a 100).");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                // Llamada a la función con retorno y parámetro
                string resultado = evaluarcurso(notafinal);

                Console.WriteLine("---------------------------------------");
                if (resultado == "aprobado")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"El estudiante ha {resultado} el curso con una nota de {notafinal}.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El estudiante ha {resultado} el curso con una nota de {notafinal}.");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------------");
            }
        }

        //Salida de programa
        static string mensajedesalida()
        {
            return "Saliendo del programa... ";
        }

        static void menu()
        {
            int opcion = 0;
            // Bucle para mostrar el menú hasta que el usuario decida salir
            do
            {
                Console.WriteLine("--- MENÚ ---");
                Console.WriteLine("1. Evaluar Nota de Estudiante");
                Console.WriteLine("2. Salir");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese una opción: ");

                // Validación de texto en la opción del menú
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción inválida, ingrese un número entero.");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case 1:
                        procesarnota();
                        break;
                    case 2:
                        string mensaje = mensajedesalida();
                        Console.WriteLine(mensaje);
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

            } while (opcion != 2);
        }

        static void Main(string[] args)
        {
            menu();
        }
    }
}