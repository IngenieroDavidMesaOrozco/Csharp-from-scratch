using System;

public static class Exercise06_TaxCalculator
{
    public static void Run()
    {
        Console.Write("Ingrese su salario anual: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double salary))
        {
            if (salary > 12000)
                Console.WriteLine($"Impuesto a pagar: {(salary - 12000) * 0.15}");
            else
                Console.WriteLine("No debe impuestos.");
        }
        else
            Console.WriteLine("Entrada inválida.");
    }
}
