using System;

/// <summary>

/// </summary>
public static class Exercise02_DoubleOrTriple
{
    public static void Run()
    {
        Console.Write("Ingrese el primer número: ");
        string input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número: ");
        string input2 = Console.ReadLine();

        // Validamos ambos valores
        if (double.TryParse(input1, out double num1) &&
            double.TryParse(input2, out double num2))
        {
            if (num1 > num2)
            {
                double result = num1 * 2;
                Console.WriteLine($"Resultado: {result}");
            }
            else
            {
                double result = num2 * 3;
                Console.WriteLine($"Resultado: {result}");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Solo se permiten números.");
        }
    }
}
