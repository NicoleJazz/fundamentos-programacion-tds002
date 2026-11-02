/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Conversor de moneda que transforma un monto en pesos dominicanos 
 *              a dólares estadounidenses utilizando una constante de tasa de cambio.
 */



namespace ConversorMoneda;

class Program
{
    static void Main(string[] args)
    {
    // Declaración de constante con la tasa del día (DOP a USD)
        const double TASA_USD = 60.50;

        Console.WriteLine("=== CONVERSOR DE MONEDA (DOP a USD) ===");

        // Solicitar monto en pesos
        Console.Write("Ingresa el monto en pesos dominicanos (DOP): ");
        double montoPesos = Convert.ToDouble(Console.ReadLine() ?? "0");

        // Conversión a dólares
        double montoDolares = montoPesos / TASA_USD;

        // Mostrar resultados con interpolación y formato de 2 decimales
        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("          RESULTADO              ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Monto en Pesos: RD$ {montoPesos:F2}");
        Console.WriteLine($"Tasa de cambio aplicada: {TASA_USD} DOP/USD");
        Console.WriteLine($"Equivalente en Dólares: US$ {montoDolares:F2}");
        Console.WriteLine("----------------------------------");
    }
}
