//3. WAP to find the maximum element of an integer Array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program3
    {
        public static void Main() {
            int[] arr = [55, 212, 4, 57, 23, 49, 10,24];
            int iMax = arr[0];
            for (int iCnt = 0; iCnt < arr.Length; iCnt++)
            {
                if (arr[iCnt] > iMax)
                {
                    iMax = arr[iCnt];
                }
            }
            Console.WriteLine("Maximum number is:" + iMax);
        }
    }
}
