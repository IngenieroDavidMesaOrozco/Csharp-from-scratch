using System;

public static class Exercise07_RemainderFinder
{
    public static void Run()
    {
        Console.Write("Ingrese el primer número: ");
        string input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número: ");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double a) &&
            double.TryParse(input2, out double b))
        {
            if (b == 0)
                Console.WriteLine("No se puede dividir entre 0.");
            else
                Console.WriteLine($"Residuo: {a % b}");
        }
        else
            Console.WriteLine("Entrada inválida.");
    }
}
