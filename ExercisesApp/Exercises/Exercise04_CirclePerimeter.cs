using System;

/// <summary>
/// Fórmula: Perímetro = 2 * π * radio
/// </summary>
public static class Exercise04_CirclePerimeter
{
    public static void Run()
    {
        Console.Write("Ingrese el radio del círculo: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double radius))
        {
            if (radius >= 0)
            {
                double perimeter = 2 * Math.PI * radius;
                Console.WriteLine($"Perímetro: {perimeter:F2}");
            }
            else
            {
                Console.WriteLine("El radio no puede ser negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número.");
        }
    }
}
