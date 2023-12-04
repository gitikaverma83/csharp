using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.Write("Enter an index to access an array element: ");
            int index = int.Parse(Console.ReadLine());

            int value = numbers[index];
            Console.WriteLine($"Value at index {index}: {value}");

            Console.Write("Enter a non-integer string: ");
            string userInput = Console.ReadLine();

            int parsedValue = int.Parse(userInput);
            Console.WriteLine($"Parsed value: {parsedValue}");

            throw new InvalidOperationException("Simulated InvalidOperationException");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"InvalidOperationException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unhandled Exception: {ex.GetType().Name} - {ex.Message}");
        }

        Console.WriteLine("Program continues after exception handling.");
    }
}
