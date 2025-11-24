using System;

public static class Exercise13_VowelCounter
{
    public static void Run()
    {
        Console.Write("Ingrese una palabra: ");
        string word = Console.ReadLine().ToLower();

        int count = 0;
        foreach (char c in word)
            if ("aeiou".Contains(c))
                count++;

        Console.WriteLine($"Número de vocales: {count}");
    }
}
