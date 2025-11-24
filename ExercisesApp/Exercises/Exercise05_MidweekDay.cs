using System;

public static class Exercise05_MidweekDay
{
    public static void Run()
    {
        Console.Write("Ingrese un número entre 1 y 7: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int day))
        {
            if (day >= 1 && day <= 5)
            {
                string[] days = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
                Console.WriteLine(days[day - 1]);
            }
            else
                Console.WriteLine("Número fuera del rango laboral.");
        }
        else
            Console.WriteLine("Entrada inválida.");
    }
}
