using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPersonas;
            int aforoActual = 0;
            int entradas = 0;
            int salidas = 0;
            int vLleno = 0;
            int vVacio = 0;

            Console.Write("Ingrese un número máximo de personas: ");
            while (!int.TryParse(Console.ReadLine(), out maxPersonas) || maxPersonas <=0)
            {
                Console.WriteLine("Ingrese un número valido mayor que cero. ");
                Console.Write("Numero maximos de asistentes permitidos: ");
            }
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine($"| Asistentes actuales | {aforoActual}\n" +
                              $"| Aforo               | {aforoActual}%" + 
                              $"| Máximo              | {maxPersonas}\n"+"personas");
            Console.WriteLine("======================================");


            while (true)
            {
                Console.WriteLine("\nPresione ");
                Console.WriteLine("[i] si ingresa una persona");
                Console.WriteLine("[s] si sale una persona");
                Console.WriteLine("[x] para terminar");
                ConsoleKeyInfo opcion = Console.ReadKey();

                switch (opcion.KeyChar)
                {
                    case 'i':
                    case 'I':
                        if (aforoActual < maxPersonas)
                        {
                            aforoActual++;
                            entradas++;
                            Console.Clear();
                            Console.WriteLine("======================================");
                            Console.WriteLine($"| Asistentes Actuales | {aforoActual}\n" +
                                              $"| Aforo               | {aforoActual} ({(double)aforoActual / maxPersonas * 100:F2}%)" +
                                              $"| Máximo              | {maxPersonas}" + "personas");
                            Console.WriteLine("======================================");

                            Console.WriteLine("\nEntrada registrada.");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"| Asistentes Actuales | {aforoActual}\n" +
                                              $"| Aforo | {aforoActual} ({(double)aforoActual / maxPersonas * 100:F2}%) " +
                                              $"| Máximo | {maxPersonas}" + "personas");
                            Console.WriteLine("\nLa tiendita ha alcanzado su capacidad máxima. No se permite la entrada.");
                        }
                        break;
                    case 's':
                    case 'S':
                        if (aforoActual > 0)
                        {
                            aforoActual--;
                            salidas++;
                            Console.Clear();
                            Console.WriteLine($"| Asistentes Actuales | {aforoActual}\n" +
                                              $"| Aforo               | {aforoActual} ({(double)aforoActual / maxPersonas * 100:F2}%)  " +
                                              $"| Máximo              | {maxPersonas}" + "personas");
                            Console.WriteLine("\nSalida registrada.");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"| Asistentes Actuales | {aforoActual}\n" +
                                              $"| Aforo               | {aforoActual} ({(double)aforoActual / maxPersonas * 100:F2}%) " +
                                              $"| Máximo              | {maxPersonas}" + "personas");
                            Console.WriteLine("\nNo hay personas en la tiendita para registrar salida.");
                        }
                        break;
                    case 'x':
                    case 'X':
                        Console.Clear();
                        Console.WriteLine("======================================");
                        Console.WriteLine("El programa a terminado ");
                        Console.WriteLine("======================================");
                        Console.WriteLine("Estadíscticas: ");

                        Console.WriteLine($"personas ingresaron: {entradas}");
                        Console.WriteLine($"personas salieron: {salidas}");
                        Console.WriteLine($"Veces que el local se llenó: {vLleno}");
                        Console.WriteLine($"Veces que el local estuvo vacío: {vVacio}");
                        Console.WriteLine("\n¡Gracias por usar el sistema de control de aforo!");
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine($"| Asistentes Actuales | {aforoActual}\n" +
                                          $"| Aforo | {aforoActual} ({(double)aforoActual / maxPersonas * 100:F2}%) " +
                                          $"| Máximo | {maxPersonas}" + "personas");
                        Console.WriteLine("\nOpción no válida. Por favor, presione [i], [s] o [x].");
                        break;
                }
                if (aforoActual == maxPersonas)
                {
                    vLleno++;
                }
                else if (aforoActual == 0)
                {
                    vVacio++;
                }
            } 
        }
    }  
}  