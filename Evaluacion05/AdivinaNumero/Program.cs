
/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Juego de adivinar un número secreto generado aleatoriamente 
 *              entre 1 y 101, indicando pistas ("mayor" o "menor") 
 *              y contando los intentos realizados.
 */

namespace AdivinaNumero;

class Program
{
    static void Main(string[] args)
    {
        // Generar número secreto aleatorio entre 1 y 100 (limite superior exclusivo en 101)
        int numeroSecreto = Random.Shared.Next(1, 101);
        int intentoUsuario = 0;
        int contadorIntentos = 0;

        Console.WriteLine("==================================================");
        Console.WriteLine("            JUEGO: ADIVINA EL NÚMERO              ");
        Console.WriteLine("==================================================");
        Console.WriteLine("He pensado en un número secreto entre 1 y 100.");
        Console.WriteLine("¡Intenta adivinar cuál es!\n");

        // Ciclo para evaluar los intentos hasta acertar
        while (intentoUsuario != numeroSecreto)
        {
            Console.Write("Ingresa tu suposición: ");
            string entrada = Console.ReadLine() ?? "";

            if (int.TryParse(entrada, out intentoUsuario))
            {
                contadorIntentos++;

                if (intentoUsuario < numeroSecreto)
                {
                    Console.WriteLine("Pista: El número secreto es MAYOR.\n");
                }
                else if (intentoUsuario > numeroSecreto)
                {
                    Console.WriteLine("Pista: El número secreto es MENOR.\n");
                }
                else
                {
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.WriteLine(" ¡FELICIDADES! ¡Has adivinado el número secreto! ");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine($" Total de intentos realizados: {contadorIntentos}");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Ingresa un número entero.\n");
            }
        }
    }
}
