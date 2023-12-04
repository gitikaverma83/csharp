using System;

class Program
{
    static void Main()
    {
        try
        {
            
            int result = DivideByZeroExample(10, 0);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("Program continues after exception handling.");
    }

    static int DivideByZeroExample(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return numerator / denominator;
    }
}
