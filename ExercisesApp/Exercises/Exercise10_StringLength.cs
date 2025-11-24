using System;

public static class Exercise10_StringLength
{
    public static void Run()
    {
        Console.Write("Ingrese una palabra: ");
        string word = Console.ReadLine();

        Console.WriteLine($"Longitud: {word.Length}");
    }
}
