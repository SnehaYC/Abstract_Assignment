// 2. Display result of Addition , subtraction , product , quotient of two numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program_2
    {
        public static void Main()
        {
            int iNo1 = 10, iNo2 = 11;
            Console.WriteLine($"Addition of {iNo1} and {iNo2} is: {iNo1 + iNo2}");
            Console.WriteLine($"Subtraction of {iNo1} and {iNo2} is: {iNo1 - iNo2}");
            Console.WriteLine($"Multiplication of {iNo1} and {iNo2} is: {iNo1 * iNo2}");
            Console.WriteLine($"Division of {iNo1} and {iNo2} is: {iNo1 / iNo2}");

        }
    }
}
