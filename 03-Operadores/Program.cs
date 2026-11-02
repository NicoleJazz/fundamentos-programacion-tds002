namespace _03_Operadores;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("=== OPERACIONES ARITMÉTICAS CON DOS NÚMEROS ===");

        // Solicitud y lectura de los dos números enteros
        Console.Write("Ingresa el primer número entero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número entero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Operaciones
        int suma = num1 + num2;
        int resta = num1 - num2;
        int producto = num1 * num2;
        
        // División real (convertimos uno a double para ver decimales)
        double divisionReal = (num2 != 0) ? (double)num1 / num2 : 0;
        
        // División entera y residuo
        int divisionEntera = (num2 != 0) ? num1 / num2 : 0;
        int residuo = (num2 != 0) ? num1 % num2 : 0;

        // Evaluar si el primer número es par (true/false)
        bool esPar = (num1 % 2 == 0);

        // Mostrar resultados
        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("           RESULTADOS            ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Suma ({num1} + {num2}) = {suma}");
        Console.WriteLine($"Resta ({num1} - {num2}) = {resta}");
        Console.WriteLine($"Producto ({num1} * {num2}) = {producto}");
        
        if (num2 != 0)
        {
            Console.WriteLine($"División real ({num1} / {num2}) = {divisionReal}");
            Console.WriteLine($"División entera ({num1} / {num2}) = {divisionEntera}");
            Console.WriteLine($"Residuo / Módulo ({num1} % {num2}) = {residuo}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero.");
        }

        Console.WriteLine($"¿El primer número ({num1}) es par? -> {esPar}");
        Console.WriteLine("----------------------------------");
    }
}
