using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                if (denominator == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                int result = DivideNumbers(numerator, denominator);
                Console.WriteLine($"Result of division: {result}");

                break; // Exit the loop if division is successful
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        Console.WriteLine("Program continues after division.");
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}
