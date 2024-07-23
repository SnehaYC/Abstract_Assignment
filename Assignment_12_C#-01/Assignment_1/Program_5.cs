//5. Display all even numbers by using do while, while , for loop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program_5
    {
        public static void Main()
        {
            Console.WriteLine("Using while loop");
            int iNo = 1;
            while (iNo <= 10)
            {
                if (iNo % 2 == 0)
                {
                    Console.WriteLine(iNo);
                }
                iNo++;
            }
            Console.WriteLine();

            Console.WriteLine("using Do while loop");
            int iNo1 = 11;
            do
            {
                if (iNo1 % 2 == 0)
                {
                    Console.WriteLine(iNo1);
                }
                iNo1++;
            }
            while (iNo1 <= 20);

            Console.WriteLine();

            Console.WriteLine("Using FOR loop");

            for (int iNo2 = 21; iNo2 <= 30; iNo2++)
            {
                if (iNo2 % 2 == 0)
                {
                    Console.WriteLine(iNo2);
                }

            }
        }
    }
}
