using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Outer try block - Start");

            try
            {
                Console.WriteLine("Inner try block - Start");
                throw new InvalidOperationException("Exception in inner try block");
            }
            catch (InvalidOperationException innerException)
            {
                Console.WriteLine($"Inner catch block: {innerException.Message}");
            }
            finally
            {
                Console.WriteLine("Inner finally block");
            }

            Console.WriteLine("Outer try block - End");
        }
        catch (Exception outerException)
        {
            Console.WriteLine($"Outer catch block: {outerException.Message}");
        }
        finally
        {
            Console.WriteLine("Outer finally block");
        }

        Console.WriteLine("Program continues after exception handling.");
    }
}
