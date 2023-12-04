using System;

class Program
{
    static void Main()
    {
        try
        {
            GenerateException();
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Caught and handled in Main: {ex.Message}");
        }

        Console.WriteLine("Program continues after exception handling.");
    }

    static void GenerateException()
    {
        try
        {
            throw new CustomException("Original exception in GenerateException");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Caught and rethrown in GenerateException: {ex.Message}");
            throw;
        }
    }
}

public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}
