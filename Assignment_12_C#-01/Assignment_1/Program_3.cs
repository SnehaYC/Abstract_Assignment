//3. Display result of Addition , subtraction , product , quotient of two numbers depending upon choice (using if else / switch)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program_3
    {
        public static void Main(string[] args)
        {
            int iNo1 = 10, iNo2 = 11;
            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine($"Addition of {iNo1} and {iNo2} is: {iNo1 + iNo2}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Subtraction of {iNo1} and {iNo2} is: {iNo1 - iNo2}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Multiplication of {iNo1} and {iNo2} is: {iNo1 * iNo2}");
                        break;

                    }
                case 4:
                    {

                        Console.WriteLine($"Division of {iNo1} and {iNo2} is: {iNo1 / iNo2}");
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Please enter valid Choice");
                        break;
                    }
            }
        }
    }
}
