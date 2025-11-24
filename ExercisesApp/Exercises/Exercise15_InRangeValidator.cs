

using System;

public static class Exercise15_InRangeValidator
{
    public static void Run()
    {
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            if (number >= 10 && number <= 20)
                Console.WriteLine("Está en el rango.");
            else
                Console.WriteLine("Fuera del rango.");
        }
        else
            Console.WriteLine("Entrada inválida.");
    }
}
