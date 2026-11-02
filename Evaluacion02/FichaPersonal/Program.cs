/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Programa que recopila datos personales (nombre, edad, 
 *              estatura, situación laboral) y calcula el año en que 
 *              la persona cumplirá 30 años.
 */


namespace FichaPersonal;

class Program
{
    static void Main(string[] args)
    {
        const int ANIO_ACTUAL = 2026;

        Console.WriteLine("=== FICHA PERSONAL ===");

        // Solicitud de datos utilizando variables en camelCase
        Console.Write("Ingresa tu nombre completo: ");
        string nombreUsuario = Console.ReadLine() ?? "";

        Console.Write("Ingresa tu edad: ");
        int edadUsuario = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa tu estatura en metros (ej. 1.65): ");
        double estaturaUsuario = Convert.ToDouble(Console.ReadLine());

        Console.Write("¿Trabajas actualmente? (true/false): ");
        bool estaTrabajando = Convert.ToBoolean(Console.ReadLine());

        // Cálculo del año en que cumplirá 30 años
        int aniosFaltantes = 30 - edadUsuario;
        int anioCumple30 = ANIO_ACTUAL + aniosFaltantes;

        // Salida clara con interpolación de cadenas
        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("        RESUMEN DE FICHA         ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Nombre: {nombreUsuario}");
        Console.WriteLine($"Edad actual: {edadUsuario} años");
        Console.WriteLine($"Estatura: {estaturaUsuario} m");
        Console.WriteLine($"¿Trabaja?: {(estaTrabajando ? "Sí" : "No")}");
        Console.WriteLine($"Año en el que cumplirás 30 años: {anioCumple30}");
        Console.WriteLine("----------------------------------");
    }
}
