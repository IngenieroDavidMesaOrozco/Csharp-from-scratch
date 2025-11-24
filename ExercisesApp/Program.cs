using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n=== MENÚ DE EJERCICIOS ===");
            Console.WriteLine("1. Positive Power");
            Console.WriteLine("2. Double or Triple");
            Console.WriteLine("3. Root or Square");
            Console.WriteLine("4. Circle Perimeter");
            Console.WriteLine("5. Midweek Day");
            Console.WriteLine("6. Tax Calculator");
            Console.WriteLine("7. Remainder Finder");
            Console.WriteLine("8. Sum of Evens");
            Console.WriteLine("9. Fraction Difference");
            Console.WriteLine("10. String Length");
            Console.WriteLine("11. Average of Four");
            Console.WriteLine("12. Smallest of Five");
            Console.WriteLine("13. Vowel Counter");
            Console.WriteLine("14. Factorial Finder");
            Console.WriteLine("15. InRange Validator");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1": Exercise01_PositivePower.Run(); break;
                case "2": Exercise02_DoubleOrTriple.Run(); break;
                case "3": Exercise03_RootOrSquare.Run(); break;
                case "4": Exercise04_CirclePerimeter.Run(); break;
                case "5": Exercise05_MidweekDay.Run(); break;
                case "6": Exercise06_TaxCalculator.Run(); break;
                case "7": Exercise07_RemainderFinder.Run(); break;
                case "8": Exercise08_SumOfEvens.Run(); break;
                case "9": Exercise09_FractionDifference.Run(); break;
                case "10": Exercise10_StringLength.Run(); break;
                case "11": Exercise11_AverageOfFour.Run(); break;
                case "12": Exercise12_SmallestOfFive.Run(); break;
                case "13": Exercise13_VowelCounter.Run(); break;
                case "14": Exercise14_FactorialFinder.Run(); break;
                case "15": Exercise15_InRangeValidator.Run(); break;

                case "0":
                    Console.WriteLine("Saliendo...");
                    return;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
