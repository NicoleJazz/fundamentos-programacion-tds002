/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Programa con un menú interactivo (do-while + switch) que incluye:
 *              1. Tablas de multiplicar del 1 al 10 en columnas alineadas con ciclos anidados.
 *              2. Triángulo de asteriscos de N filas ingresadas por el usuario.
 */


namespace _08_For_Menus;

class Program
{
    static void Main(string[] args)
    {
       string opcion = "";

        // 3. Menú interactivo con do-while + switch
        do
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("          SEMANA 8: MENÚ DE CICLOS Y FOR          ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Tablas de multiplicar (1 al 10) en columnas");
            Console.WriteLine("2. Dibujar triángulo de asteriscos (N filas)");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opción: ");
            
            opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("=== TABLAS DE MULTIPLICAR DEL 1 AL 10 (ALINEADAS) ===\n");
                    
                    // 1. Ciclos anidados para mostrar las tablas en columnas ({valor,4})
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            int resultado = i * j;
                            Console.Write($"{resultado,4}");
                        }
                        Console.WriteLine(); // Salto de línea por cada fila de la tabla
                    }
                    
                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("=== TRIÁNGULO DE ASTERISCOS ===");
                    Console.Write("Ingresa el número de filas (N) para el triángulo: ");
                    
                    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                    {
                        // 2. Dibuja un triángulo de asteriscos de N filas
                        for (int fila = 1; fila <= n; fila++)
                        {
                            for (int col = 1; col <= fila; col++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nError: Debes ingresar un número entero positivo válido.");
                    }

                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                    break;

                case "0":
                    Console.WriteLine("\n¡Saliendo del programa. ¡Hasta pronto!");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Presiona cualquier tecla para intentar de nuevo...");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != "0");
    }
}
