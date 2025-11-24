using System;

public static class Exercise09_FractionDifference
{
    public static void Run()
    {
        Console.Write("Ingrese la primera fracción (a/b): ");
        string f1 = Console.ReadLine();

        Console.Write("Ingrese la segunda fracción (c/d): ");
        string f2 = Console.ReadLine();

        try
        {
            var p1 = f1.Split('/');
            var p2 = f2.Split('/');

            double a = double.Parse(p1[0]);
            double b = double.Parse(p1[1]);
            double c = double.Parse(p2[0]);
            double d = double.Parse(p2[1]);

            double r1 = a / b;
            double r2 = c / d;

            Console.WriteLine($"Resultado: {r1 - r2}");
        }
        catch
        {
            Console.WriteLine("Formato inválido.");
        }
    }
}
