using System;

/// <summary>

/// </summary>
public static class Exercise03_RootOrSquare
{
    public static void Run()
    {
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            if (number > 0)
            {
                double result = Math.Sqrt(number);
                Console.WriteLine($"Resultado (raíz cuadrada): {result}");
            }
            else if (number < 0)
            {
                double result = Math.Pow(number, 2);
                Console.WriteLine($"Resultado (cuadrado): {result}");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número válido.");
        }
    }
}
