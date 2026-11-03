/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Programa que pide notas válidas (0-100) validadas con 
 *              do-while y TryParse hasta que el usuario escriba -1, 
 *              mostrando el promedio, la nota mayor y la nota menor.
 */

namespace PromedioValidado;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("          REGISTRO Y PROMEDIO DE NOTAS            ");
        Console.WriteLine("==================================================");
        Console.WriteLine("Ingresa notas válidas entre 0 y 100.");
        Console.WriteLine("Escribe '-1' para finalizar y calcular resultados.\n");

        double sumaNotas = 0;
        int contadorNotas = 0;
        double notaMayor = -1;
        double notaMenor = 101;
        double nota = 0;

        // Ciclo para solicitar notas de forma validada
        do
        {
            bool entradaValida = false;

            do
            {
                Console.Write($"Ingresa la nota #{contadorNotas + 1} (0-100, o -1 para terminar): ");
                string entrada = Console.ReadLine() ?? "";

                if (double.TryParse(entrada, out nota))
                {
                    // Verificar si es la señal de salida (-1) o una nota válida en rango
                    if (nota == -1)
                    {
                        entradaValida = true;
                    }
                    else if (nota >= 0 && nota <= 100)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: La nota debe estar entre 0 y 100. Inténtalo de nuevo.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada no válida. Debes ingresar un número.\n");
                }

            } while (!entradaValida);

            // Si no es la señal de salida, procesamos la nota
            if (nota != -1)
            {
                sumaNotas += nota;
                contadorNotas++;

                // Evaluar nota mayor y menor
                if (contadorNotas == 1)
                {
                    notaMayor = nota;
                    notaMenor = nota;
                }
                else
                {
                    if (nota > notaMayor) notaMayor = nota;
                    if (nota < notaMenor) notaMenor = nota;
                }
                Console.WriteLine("-> Nota registrada correctamente.\n");
            }

        } while (nota != -1);

        // Mostrar resultados si se ingresó al menos una nota
        Console.WriteLine("\n==================================================");
        Console.WriteLine("                RESULTADOS FINALES                ");
        Console.WriteLine("==================================================");
        if (contadorNotas > 0)
        {
            double promedio = sumaNotas / contadorNotas;
            Console.WriteLine($" Total de notas evaluadas: {contadorNotas}");
            Console.WriteLine($" Promedio general:         {promedio:F2}");
            Console.WriteLine($" Nota más alta:            {notaMayor:F2}");
            Console.WriteLine($" Nota más baja:            {notaMenor:F2}");
        }
        else
        {
            Console.WriteLine(" No se ingresó ninguna nota para calcular.");
        }
        Console.WriteLine("==================================================");
    }
}
