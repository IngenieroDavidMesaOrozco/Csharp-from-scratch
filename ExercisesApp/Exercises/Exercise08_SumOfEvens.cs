using System;

public static class Exercise08_SumOfEvens
{
    public static void Run()
    {
        int sum = 0;
        for (int i = 2; i <= 50; i += 2)
            sum += i;

        Console.WriteLine($"Suma de pares entre 1 y 50: {sum}");
    }
}
