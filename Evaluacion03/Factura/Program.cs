/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Sistema de facturación que calcula subtotal, ITBIS (18%) 
 *              y total a pagar, mostrando una factura con columnas alineadas.
 */


namespace Factura;

class Program
{
    static void Main(string[] args)
    {
        // Constante del ITBIS (18%)
        const double TASA_ITBIS = 0.18;

        Console.WriteLine("=== SISTEMA DE FACTURACIÓN ===");

        // Entrada de datos
        Console.Write("Ingresa el nombre del producto: ");
        string nombreProducto = Console.ReadLine() ?? "";

        Console.Write("Ingresa la cantidad comprada: ");
        int cantidad = Convert.ToInt32(Console.ReadLine() ?? "0");

        Console.Write("Ingresa el precio unitario del producto: ");
        double precioUnitario = Convert.ToDouble(Console.ReadLine() ?? "0");

        // Proceso de cálculos
        double subtotal = cantidad * precioUnitario;
        double montoItbis = subtotal * TASA_ITBIS;
        double totalPagar = subtotal + montoItbis;

        // Salida de resultados en columnas alineadas utilizando {valor,10:N2}
        Console.WriteLine("\n==================================================");
        Console.WriteLine("                  FACTURA COMERCIAL               ");
        Console.WriteLine("==================================================");
        Console.WriteLine($" Producto: {nombreProducto}");
        Console.WriteLine($" Cantidad: {cantidad}");
        Console.WriteLine($" Precio Unitario:              RD$ {precioUnitario,10:N2}");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($" Subtotal:                     RD$ {subtotal,10:N2}");
        Console.WriteLine($" ITBIS (18%):                  RD$ {montoItbis,10:N2}");
        Console.WriteLine("==================================================");
        Console.WriteLine($" TOTAL A PAGAR:                RD$ {totalPagar,10:N2}");
        Console.WriteLine("==================================================");
    }
}
