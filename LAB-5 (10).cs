using System;

class Program
{
    static void Main()
    {
        int[] shoppingCart = new int[100];
        int cartIndex = 0;

        Console.WriteLine("Welcome to the Simple E-Commerce Application");

        while (true)
        {
            try
            {
                Console.Write("Enter the price of the item (or 'done' to finish): ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "done")
                {
                    break;
                }

                int price = ValidateAndAddToCart(userInput);
                shoppingCart[cartIndex++] = price;
            }
            catch (NegativePriceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid price.");
            }
            catch (PriceTooHighException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        int totalPrice = CalculateTotalPrice(shoppingCart, cartIndex);
        Console.WriteLine($"Total Price of Items in the Cart: {totalPrice:C}");

        Console.WriteLine("Thank you for using the Simple E-Commerce Application!");
    }

    static int ValidateAndAddToCart(string userInput)
    {
        if (!int.TryParse(userInput, out int price))
        {
            throw new FormatException();
        }

        if (price < 0)
        {
            throw new NegativePriceException("Negative prices are not allowed.");
        }

        if (price > 10000)
        {
            throw new PriceTooHighException("Price exceeds the maximum allowed value.");
        }

        return price;
    }

    static int CalculateTotalPrice(int[] cart, int itemCount)
    {
        int totalPrice = 0;
        for (int i = 0; i < itemCount; i++)
        {
            totalPrice += cart[i];
        }
        return totalPrice;
    }
}

public class NegativePriceException : Exception
{
    public NegativePriceException(string message) : base(message)
    {
    }
}

public class PriceTooHighException : Exception
{
    public PriceTooHighException(string message) : base(message)
    {
    }
}
