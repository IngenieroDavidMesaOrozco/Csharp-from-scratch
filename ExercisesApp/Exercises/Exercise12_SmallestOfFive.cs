using System;

public static class Exercise12_SmallestOfFive
{
    public static void Run()
    {
        double smallest = double.MaxValue;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese número {i}: ");
            double num = double.Parse(Console.ReadLine());

            if (num < smallest)
                smallest = num;
        }

        Console.WriteLine($"El menor número es: {smallest}");
    }
}
