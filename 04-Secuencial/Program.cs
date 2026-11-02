//Nombre: Nicole Jazmín Encarnación Padilla
 //Fecha: 02/11/2026
//Descripción: Conversor de unidades que solicita un peso en libras 
 // y una temperatura en °F, convirtiéndolos a kilogramos 
 // y grados Celsius respectivamente



namespace _04_Secuencial;

class Program
{
    static void Main(string[] args)
    {
        // Constante de conversión de libras a kilogramos
        const double LIBRA_A_KG = 0.453592;

        Console.WriteLine("=== CONVERSOR DE UNIDADES (SEMANA 4) ===");

        // Solicitar peso en libras
        Console.Write("Ingresa el peso en libras (lb): ");
        double libras = Convert.ToDouble(Console.ReadLine());

        // Solicitar temperatura en grados Fahrenheit
        Console.Write("Ingresa la temperatura en grados Fahrenheit (°F): ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Procesos de conversión
        double kilogramos = libras * LIBRA_A_KG;
        double celsius = (fahrenheit - 32) * 5.0 / 9.0;

        // Mostrar resultados con formato de 2 decimales ({valor:F2} y Math.Round)
        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("          RESULTADOS             ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Peso ingresado: {libras} lb");
        Console.WriteLine($"Equivalente en kilogramos: {kilogramos:F2} kg");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Temperatura ingresada: {fahrenheit} °F");
        Console.WriteLine($"Equivalente en Celsius: {Math.Round(celsius, 2)} °C");
        Console.WriteLine("----------------------------------");
    }
}
