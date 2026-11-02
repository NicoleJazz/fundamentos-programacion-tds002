/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Programa que demuestra el uso de casting explícito 
 *              (de double a int) y casting implícito (de int a double).
 */


namespace Casting;

class Program
{
    static void Main(string[] args)
    {
       
    {
        Console.WriteLine("=== DEMOSTRACIÓN DE CASTING DE TIPOS ===");

        // 1. Casting Explícito (de double a int)
        Console.Write("Ingresa un número con decimales (ej. 45.78): ");
        double numeroDecimal = Convert.ToDouble(Console.ReadLine() ?? "0");

        // Conversión explícita usando (int)
        int parteEntera = (int)numeroDecimal;

        // 2. Casting Implícito (de int a double)
        int edadEntera = 18;
        double edadComoDoble = edadEntera; // Conversión automática de int a double

        // Mostrar resultados de ambas conversiones
        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("             RESULTADOS DE CASTING                ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"[Explícito] Número decimal original: {numeroDecimal}");
        Console.WriteLine($"[Explícito] Parte entera obtenida con (int): {parteEntera}");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"[Implícito] Entero original (int): {edadEntera}");
        Console.WriteLine($"[Implícito] Convertido a double automáticamente: {edadComoDoble}");
        Console.WriteLine("--------------------------------------------------");
    }
}


}
