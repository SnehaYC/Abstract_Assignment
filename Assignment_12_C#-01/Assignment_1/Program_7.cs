// 7.Display table of a number using all loops

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program_7
    {
        public static void Main()
        {
            int iNo = 2;
            Console.WriteLine("using while loop");
            int iCnt = 1;
            while (iCnt <= 10)
            {

                Console.WriteLine(iCnt * iNo);
                iCnt++;
            }

            Console.WriteLine();
            Console.WriteLine("using Do while loop");

            int iCnt2 = 1;
            do
            {
                Console.WriteLine(iCnt2 * iNo);
                iCnt2++;
            }
            while (iCnt2 <= 10);


            Console.WriteLine();
            Console.WriteLine("using for loop");
            for (int iNo1 = 1; iNo1 <= 10; iNo1++)
            {
                Console.WriteLine(iCnt2 * iNo1);
            }

        }
    }
}
