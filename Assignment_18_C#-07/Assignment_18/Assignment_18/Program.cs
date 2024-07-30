/*using System;

class InPlacePositiveSquareFinder
{
    public int FindSmallestPositiveSquare(int[] array)
    {
        int n = array.Length;

        // Step 1: Normalize the array
        for (int i = 0; i < n; i++)
        {
            // Perform the swap using arithmetic operations if needed
            while (array[i] > 0 && array[i] <= n && array[i] != array[array[i] - 1])
            {
                // Calculate the correct index
                int correctIndex = array[i] - 1;

                // Swap without using a temporary variable
                if (array[i] != array[correctIndex])
                {
                    // Swap values
                    array[i] = array[i] + array[correctIndex];
                    array[correctIndex] = array[i] - array[correctIndex];
                    array[i] = array[i] - array[correctIndex];
                }
            }
        }

        // Step 2: Find the smallest missing positive integer
        for (int i = 0; i < n; i++)
        {
            if (array[i] != i + 1)
            {
                return (i + 1) * (i + 1);
            }
        }

        // Step 3: If all numbers from 1 to N are present, return (N + 1) squared
        return (n + 1) * (n + 1);
    }

    static void Main()
    {
        // Create an instance of the InPlacePositiveSquareFinder class
        InPlacePositiveSquareFinder finder = new InPlacePositiveSquareFinder();

        // Prompt the user for input
        

        Console.WriteLine("Please enter the number of elements in the array:");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        // Initialize the array
        int[] array = new int[n];

        // Read array elements from the user
        Console.WriteLine("Please enter the elements of the array separated by spaces (e.g., 5 3 -6 -4 10 2):");
        string[] input = Console.ReadLine().Split();
        while (input.Length != n)
        {
            Console.WriteLine($"You must enter exactly {n} integers. Please try again:");
            input = Console.ReadLine().Split();
        }

        // Parse the input and fill the array
        for (int i = 0; i < n; i++)
        {
            if (!int.TryParse(input[i], out array[i]))
            {
                Console.WriteLine($"Invalid integer at position {i + 1}. Please restart and enter valid integers.");
                return;
            }
        }

        // Find the smallest positive square
        int result = finder.FindSmallestPositiveSquare(array);

        // Print the result
        Console.WriteLine("The square of the smallest missing positive integer is: " + result);
    }
}
*/

using System;

public class SmallestPositiveSquare
{
    public int Solution(int[] inputArray)
    {
        // Find the smallest positive integer in the array
        int smallestPositive = int.MaxValue;
        bool positiveFound = false;

        foreach (int number in inputArray)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
                positiveFound = true;
            }
        }

        // If no positive integer is found, return 0
        if (!positiveFound)
        {
            return 0;
        }

        // Return the square of the smallest positive integer found
        return smallestPositive * smallestPositive;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());

        int[] inputArray = new int[n];
        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        SmallestPositiveSquare solution = new SmallestPositiveSquare();
        int result = solution.Solution(inputArray);
        Console.WriteLine("The square of the smallest positive integer in the array is: " + result);
    }
}
