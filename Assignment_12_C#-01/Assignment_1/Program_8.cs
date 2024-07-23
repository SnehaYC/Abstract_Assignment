// 8.Display numbers from 100 to 5 with a gap of 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program_8
    {
        public static void Main()
        {
            int iNo = 100;
            while (iNo >= 5)
            {
                Console.WriteLine(iNo);
                iNo -= 3;
            }
        }
    }
}
