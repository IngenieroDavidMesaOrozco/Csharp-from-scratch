using System;

/// <summary>

/// </summary>
public static class Exercise01_PositivePower
{
    public static void Run()
    {
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            if (number > 0)
            {
                double result = Math.Pow(number, 2);
                Console.WriteLine($"Resultado: {result}");
            }
            else if (number < 0)
            {
                Console.WriteLine("Número negativo.");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número.");
        }
    }
}
