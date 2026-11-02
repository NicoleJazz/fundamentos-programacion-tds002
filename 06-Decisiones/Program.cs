/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Programa de dos partes: 
 *              1. Valida calificaciones con int.TryParse y clasifica con if-else.
 *              2. Calculadora con operaciones básicas utilizando switch.
 */




namespace _06_Decisiones;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("          SEMANA 6: ESTRUCTURAS DE DECISIÓN       ");
        Console.WriteLine("==================================================\n");

        // ==========================================
        // PARTE 1: CALIFICACIÓN
        // ==========================================
        Console.WriteLine("--- PARTE 1: EVALUACIÓN DE CALIFICACIÓN ---");
        Console.Write("Ingresa una nota (0-100): ");
        string entradaNota = Console.ReadLine() ?? "";

        // Validar con int.TryParse
        if (int.TryParse(entradaNota, out int nota))
        {
            if (nota >= 0 && nota <= 100)
            {
                // Estructura if - else if - else para las letras
                if (nota >= 90)
                {
                    Console.WriteLine($"Calificación: A ({nota} puntos)");
                }
                else if (nota >= 80)
                {
                    Console.WriteLine($"Calificación: B ({nota} puntos)");
                }
                else if (nota >= 70)
                {
                    Console.WriteLine($"Calificación: C ({nota} puntos)");
                }
                else
                {
                    Console.WriteLine($"Calificación: F ({nota} puntos) - Reprobado");
                }
            }
            else
            {
                Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Entrada no válida. Debes ingresar un número entero.");
        }

        Console.WriteLine("\n--------------------------------------------------\n");

        // ==========================================
        // PARTE 2: CALCULADORA CON SWITCH
        // ==========================================
        Console.WriteLine("--- PARTE 2: CALCULADORA BÁSICA ---");
        
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nElige una opción de operación:");
        Console.WriteLine("1. Sumar (+)");
        Console.WriteLine("2. Restar (-)");
        Console.WriteLine("3. Multiplicar (*)");
        Console.WriteLine("4. Dividir (/)");
        Console.Write("Selecciona una opción (1-4): ");
        
        string opcion = Console.ReadLine() ?? "";
        double resultado = 0;

        // Estructura switch para seleccionar la operación
        switch (opcion)
        {
            case "1":
                resultado = num1 + num2;
                Console.WriteLine($"\nResultado de la suma: {num1} + {num2} = {resultado}");
                break;
            case "2":
                resultado = num1 - num2;
                Console.WriteLine($"\nResultado de la resta: {num1} - {num2} = {resultado}");
                break;
            case "3":
                resultado = num1 * num2;
                Console.WriteLine($"\nResultado del producto: {num1} * {num2} = {resultado}");
                break;
            case "4":
                // Validación para división entre cero
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"\nResultado de la división: {num1} / {num2} = {resultado}");
                }
                else
                {
                    Console.WriteLine("\n¡Error! No se puede dividir entre cero.");
                }
                break;
            default:
                Console.WriteLine("\nOpción no válida. Debes elegir un número del 1 al 4.");
                break;
        }
    }
}
