/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Programa que calcula el área y circunferencia de un círculo 
 *              usando Math.PI y Math.Pow, y la hipotenusa de un triángulo 
 *              rectángulo usando Math.Sqrt, con resultados a 2 decimales.
 */


namespace Geometria;

class Program
{
    static void Main(string[] args)
    {
       
    {
        Console.WriteLine("=== CÁLCULOS GEOMÉTRICOS ===");

        // --- PARTE 1: CÍRCULO ---
        Console.Write("Ingresa el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine() ?? "0");

        // Fórmulas de círculo usando Math.PI y Math.Pow
        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        double circunferenciaCirculo = 2 * Math.PI * radio;

        // --- PARTE 2: TRIÁNGULO RECTÁNGULO ---
        Console.WriteLine("\n--- Triángulo Rectángulo ---");
        Console.Write("Ingresa el valor del cateto A: ");
        double catetoA = Convert.ToDouble(Console.ReadLine() ?? "0");

        Console.Write("Ingresa el valor del cateto B: ");
        double catetoB = Convert.ToDouble(Console.ReadLine() ?? "0");

        // Teorema de Pitágoras para la hipotenusa usando Math.Pow y Math.Sqrt
        double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

        // Salida de resultados con formato de 2 decimales (:F2)
        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("              RESULTADOS GEOMÉTRICOS             ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"[Círculo] Radio ingresado: {radio:F2}");
        Console.WriteLine($"[Círculo] Área: {areaCirculo:F2}");
        Console.WriteLine($"[Círculo] Circunferencia: {circunferenciaCirculo:F2}");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"[Triángulo] Cateto A: {catetoA:F2} | Cateto B: {catetoB:F2}");
        Console.WriteLine($"[Triángulo] Hipotenusa calculada: {hipotenusa:F2}");
        Console.WriteLine("--------------------------------------------------");
    }
}

}
