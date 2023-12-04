using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string userInput = Console.ReadLine();

        try
        {
            // Attempting to parse the string to an integer
            int parsedValue = int.Parse(userInput);
            Console.WriteLine($"Parsed value: {parsedValue}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Please enter a valid integer.");
        }

        Console.WriteLine("Program continues after exception handling.");
    }
}
