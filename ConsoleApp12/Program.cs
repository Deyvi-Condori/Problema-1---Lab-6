using System;

namespace TienditaDeDonMariano
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximoPersonas, contadorActual = 0, opcion, personas;

            Console.Write("Ingrese un número máximo de personas: ");
            maximoPersonas = int.Parse(Console.ReadLine());

            Console.WriteLine("========================================");
            Console.WriteLine($"El número máximo establecido es de {maximoPersonas} personas,");
            Console.WriteLine("presione una tecla para comenzar a contar.");
            Console.ReadKey();

            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine($"Personas actualmente en la tienda: {contadorActual}");
                Console.WriteLine("1. Registrar entrada de personas.");
                Console.WriteLine("2. Registrar salida de personas.");
                Console.WriteLine("3. Salir.");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese número de personas que entran: ");
                        personas = Convert.ToInt32(Console.ReadLine());
                        if (contadorActual + personas <= maximoPersonas)
                        {
                            contadorActual += personas;
                        }
                        else
                        {
                            Console.WriteLine("Superará el límite. No se puede ingresar esa cantidad de personas.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese número de personas que salen: ");
                        personas = Convert.ToInt32(Console.ReadLine());
                        if (contadorActual - personas >= 0)
                        {
                            contadorActual -= personas;
                        }
                        else
                        {
                            Console.WriteLine("No puede salir más gente de la que está dentro.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Finalizando programa.");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}


