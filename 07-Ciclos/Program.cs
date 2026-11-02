/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Programa que valida un número entre 1 y 12 usando do-while, 
 *              muestra su tabla de multiplicar con un ciclo while y 
 *              calcula la suma acumulada de todos los resultados.
 */




namespace _07_Ciclos;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("==================================================");
        Console.WriteLine("          SEMANA 7: CICLOS WHILE Y DO-WHILE       ");
        Console.WriteLine("==================================================\n");

        int numero = 0;
        bool esValido = false;

        // 1. Pide un número entre 1 y 12 y valídalo con do-while
        do
        {
            Console.Write("Ingresa un número entero entre 1 y 12: ");
            string entrada = Console.ReadLine() ?? "";

            if (int.TryParse(entrada, out numero))
            {
                if (numero >= 1 && numero <= 12)
                {
                    esValido = true; // El número es correcto, salimos del do-while
                }
                else
                {
                    Console.WriteLine("Error: El número debe estar estrictamente entre 1 y 12. Inténtalo de nuevo.\n");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Debes ingresar un número entero.\n");
            }

        } while (!esValido);

        Console.WriteLine($"\n¡Número válido aceptado: {numero}!\n");
        Console.WriteLine($"--- TABLA DE MULTIPLICAR DEL {numero} (DEL 1 AL 12) ---");

        // 2. Muestra su tabla de multiplicar del 1 al 12 con while (usando un contador)
        int contador = 1;
        int sumaAcumulada = 0; // 3. Acumulador para sumar todos los resultados

        while (contador <= 12)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");

            // Acumulamos el resultado en la suma total
            sumaAcumulada += resultado;

            // Incrementamos el contador para evitar un ciclo infinito
            contador++;
        }

        // 3. Al final, muestra la suma de todos los resultados
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Suma total de todos los resultados: {sumaAcumulada}");
        Console.WriteLine("--------------------------------------------------");
    }
}
