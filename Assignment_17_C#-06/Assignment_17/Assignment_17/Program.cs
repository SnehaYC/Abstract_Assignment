using System;
using System.Collections.Generic;

public class PizzaOrder
{
    // Private instance variables
    private string pizzaSize;
    private int cheeseToppings;
    private int pepperoniToppings;
    private int hamToppings;

    // Constructor
    public PizzaOrder(string size, int cheese, int pepperoni, int ham)
    {
        pizzaSize = size;
        cheeseToppings = cheese;
        pepperoniToppings = pepperoni;
        hamToppings = ham;
    }

    // Getter and Setter for pizzaSize
    public string PizzaSize
    {
        get { return pizzaSize; }
        set { pizzaSize = value; }
    }

    // Getter and Setter for cheeseToppings
    public int CheeseToppings
    {
        get { return cheeseToppings; }
        set { cheeseToppings = value; }
    }

    // Getter and Setter for pepperoniToppings
    public int PepperoniToppings
    {
        get { return pepperoniToppings; }
        set { pepperoniToppings = value; }
    }

    // Getter and Setter for hamToppings
    public int HamToppings
    {
        get { return hamToppings; }
        set { hamToppings = value; }
    }

    // Method to calculate the cost of the pizza
    public double CalculateCost()
    {
        double baseCost;
        switch (pizzaSize.ToLower())
        {
            case "small":
                baseCost = 10.0;
                break;
            case "medium":
                baseCost = 12.0;
                break;
            case "large":
                baseCost = 14.0;
                break;
            default:
                throw new ArgumentException("Invalid pizza size");
        }
        return baseCost + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
    }

    // Method to get the description of the pizza
    public string GetDescription()
    {
        return $"{pizzaSize} Pizza with {cheeseToppings} cheese, {pepperoniToppings} pepperoni, and {hamToppings} ham toppings";
    }
}

// Example usage
public class Program
{
    public static void Main()
    {
        List<PizzaOrder> pizzaOrders = new List<PizzaOrder>();

        // Ask the user how many pizzas they want to order
        Console.WriteLine("Welcome to the Abstract's Pizza Ordering System!");
        Console.WriteLine("----------------------------------------------------");
        Console.Write("How many pizzas do you want to order? ");
        int numberOfPizzas;
        while (!int.TryParse(Console.ReadLine(), out numberOfPizzas) || numberOfPizzas <= 0)
        {
            Console.Write("Please enter a valid number greater than 0: ");
        }

        // Get details for each pizza
        for (int i = 0; i < numberOfPizzas; i++)
        {
            Console.WriteLine($"\nPizza {i + 1}:");

            // Choose the pizza size from numeric options
            Console.WriteLine("Choose the pizza size:");
            Console.WriteLine("1. Small");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Large");
            Console.Write("Enter the number corresponding to the pizza size (1, 2, or 3): ");
            int sizeChoice = GetNumericChoice(1, 3);
            string size = sizeChoice switch
            {
                1 => "small",
                2 => "medium",
                3 => "large",
                _ => throw new InvalidOperationException("Invalid size choice")
            };

            // Get the number of cheese toppings
            Console.Write("Enter the number of cheese toppings (0 or more): ");
            int cheese = GetToppingCount();

            // Get the number of pepperoni toppings
            Console.Write("Enter the number of pepperoni toppings (0 or more): ");
            int pepperoni = GetToppingCount();

            // Get the number of ham toppings
            Console.Write("Enter the number of ham toppings (0 or more): ");
            int ham = GetToppingCount();

            // Create a new PizzaOrder object and add it to the list
            pizzaOrders.Add(new PizzaOrder(size, cheese, pepperoni, ham));
        }

        // Display the records
        Console.WriteLine();
        Console.WriteLine("----------------------Thanks for Shopping with us----------------------");
        Console.WriteLine("\nOrder Summary:");
        foreach (PizzaOrder pizzaOrder in pizzaOrders)
        {
            
            Console.WriteLine(pizzaOrder.GetDescription());
            Console.WriteLine($"Cost: ${pizzaOrder.CalculateCost():0.00}");
            Console.WriteLine();
        }
    }

    // Method to get a valid numeric choice within a given range
    private static int GetNumericChoice(int min, int max)
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max)
        {
            Console.Write($"Please enter a valid number between {min} and {max}: ");
        }
        return choice;
    }

    // Method to get valid topping count from user
    private static int GetToppingCount()
    {
        int toppingCount;
        while (!int.TryParse(Console.ReadLine(), out toppingCount) || toppingCount < 0)
        {
            Console.Write("Please enter a valid number (0 or greater): ");
        }
        return toppingCount;
    }
}
