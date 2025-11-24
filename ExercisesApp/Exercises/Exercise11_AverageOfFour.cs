using System;

public static class Exercise11_AverageOfFour
{
    public static void Run()
    {
        double[] numbers = new double[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Ingrese número {i + 1}: ");
            numbers[i] = double.Parse(Console.ReadLine());
        }

        double average = (numbers[0] + numbers[1] + numbers[2] + numbers[3]) / 4;
        Console.WriteLine($"Promedio: {average}");
    }
}
