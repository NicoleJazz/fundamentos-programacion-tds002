/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 03/11/2026
 * Descripción: Simulador de caja registradora que lee precios de productos 
 *              usando un ciclo do-while hasta que el usuario ingresa 0, 
 *              calculando la cantidad de productos, subtotal, ITBIS (18%) y total.
 */


namespace CajaRegistradora;

class Program
{
    static void Main(string[] args)
    {
        // Constante del ITBIS (18%)
        const double TASA_ITBIS = 0.18;

        double precio = 0;
        double subtotal = 0;
        int cantidadProductos = 0;

        Console.WriteLine("==================================================");
        Console.WriteLine("          CAJA REGISTRADORA COMERCIAL            ");
        Console.WriteLine("==================================================");
        Console.WriteLine("Instrucción: Ingresa el precio de cada producto.");
        Console.WriteLine("Escribe '0' (cero) para terminar y facturar.\n");

        // Ciclo do-while para leer precios hasta que sea 0
        do
        {
            Console.Write($"Ingresa el precio del producto #{cantidadProductos + 1} (o 0 para salir): ");
            string entrada = Console.ReadLine() ?? "0";

            if (double.TryParse(entrada, out precio))
            {
                if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }
                else if (precio < 0)
                {
                    Console.WriteLine("Error: El precio no puede ser negativo. Inténtalo de nuevo.\n");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Debes ingresar un número.\n");
            }

        } while (precio != 0);

        // Cálculos finales
        double montoItbis = subtotal * TASA_ITBIS;
        double totalPagar = subtotal + montoItbis;

        // Salida de resultados con formato {valor:N2}
        Console.WriteLine("\n==================================================");
        Console.WriteLine("                  FACTURA FINAL                   ");
        Console.WriteLine("==================================================");
        Console.WriteLine($" Total de productos procesados: {cantidadProductos}");
        Console.WriteLine($" Subtotal:               RD$ {subtotal,10:N2}");
        Console.WriteLine($" ITBIS (18%):            RD$ {montoItbis,10:N2}");
        Console.WriteLine("==================================================");
        Console.WriteLine($" TOTAL A PAGAR:          RD$ {totalPagar,10:N2}");
        Console.WriteLine("==================================================");
    }
}
