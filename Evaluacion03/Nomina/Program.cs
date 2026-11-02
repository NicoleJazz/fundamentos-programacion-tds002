/*
 * Nombre: Nicole Jazmín Encarnación Padilla
 * Fecha: 02/11/2026
 * Descripción: Programa de nómina que calcula salario bruto, deducciones 
 *              de ley (AFP y SFS) y salario neto a partir de las horas 
 *              trabajadas y la tarifa por hora.
 */


namespace Nomina;

class Program
{
    static void Main(string[] args)
    {
       // Constantes de porcentaje para deducciones legales (AFP 2.87% y SFS 3.04%)
        const double PORCENTAJE_AFP = 0.0287;
        const double PORCENTAJE_SFS = 0.0304;

        Console.WriteLine("=== CÁLCULO DE NÓMINA EMPLEADO ===");

        // Entrada de datos
        Console.Write("Ingresa el nombre del empleado: ");
        string nombreEmpleado = Console.ReadLine() ?? "";

        Console.Write("Ingresa las horas trabajadas: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine() ?? "0");

        Console.Write("Ingresa el pago por hora: ");
        double pagoPorHora = Convert.ToDouble(Console.ReadLine() ?? "0");

        // Proceso de cálculos
        double salarioBruto = horasTrabajadas * pagoPorHora;
        double montoAfp = salarioBruto * PORCENTAJE_AFP;
        double montoSfs = salarioBruto * PORCENTAJE_SFS;
        double totalDeducciones = montoAfp + montoSfs;
        double salarioNeto = salarioBruto - totalDeducciones;

        // Salida de resultados (nombre en MAYÚSCULAS y montos con formato {valor:N2})
        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("                VOLANTE DE PAGO                  ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Empleado: {nombreEmpleado.ToUpper()}");
        Console.WriteLine($"Salario Bruto:      RD$ {salarioBruto:N2}");
        Console.WriteLine($"Descuento AFP (2.87%): RD$ {montoAfp:N2}");
        Console.WriteLine($"Descuento SFS (3.04%): RD$ {montoSfs:N2}");
        Console.WriteLine($"Total Deducciones:  RD$ {totalDeducciones:N2}");
        Console.WriteLine($"Salario Neto:       RD$ {salarioNeto:N2}");
        Console.WriteLine("--------------------------------------------------");
    }
}
