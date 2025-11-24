using System;

public static class Exercise14_FactorialFinder
{
    public static void Run()
    {
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n) && n >= 0)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;

            Console.WriteLine($"Factorial: {factorial}");
        }
        else
            Console.WriteLine("Debe ingresar un entero positivo.");
    }
}




