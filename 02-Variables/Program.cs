namespace _02_Variables;

class Program
{
    static void Main(string[] args)
    {
       // Definición de constante para el año actual
        const int ANIO_ACTUAL = 2026;

        // Mensaje de bienvenida
        Console.WriteLine("=== REGISTRO DE DATOS PERSONALES ===");

        // Solicitud y lectura de datos (string, int, double)
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingresa tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa tu estatura en metros (ej. 1.65): ");
        double estatura = Convert.ToDouble(Console.ReadLine());

        // Cálculo del año de nacimiento
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Resultados usando interpolación de cadenas ($"...")
        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("          RESULTADOS             ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} m");
        Console.WriteLine($"Año aproximado de nacimiento: {anioNacimiento}");
        Console.WriteLine("----------------------------------");
       
    }
}
