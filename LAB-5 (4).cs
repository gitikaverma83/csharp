using System;


public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            
            int userInput = GetUserInput();

            if (userInput == 42)
            {
                
                throw new CustomException("The answer to everything is not allowed!");
            }

            Console.WriteLine($"User input: {userInput}");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }

        Console.WriteLine("Program continues after exception handling.");
    }

    // Simulate getting user input (you can replace this with actual user input logic)
    static int GetUserInput()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int userInput))
        {
            return userInput;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 0.");
            return 0;
        }
    }
}
