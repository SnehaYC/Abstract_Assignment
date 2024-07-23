//4. WAP to print column wise sum of elements of 2 D Array


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program_4
    {
        public static void Main()
        {
            int[,] arr = {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9 }
            };

            int iRow = arr.GetLength(0);
            int iCol = arr.GetLength(1);

            int[] iAns = new int[iCol];

            for (int iCnt = 0; iCnt < iCol; iCnt++)
            {
                for (int iCnt1 = 0; iCnt1 < iRow; iCnt1++)
                {
                    iAns[iCnt] = iAns[iCnt] + arr[iCnt1, iCnt];
                }
            }

            for (int iCnt = 0; iCnt < iAns.Length; iCnt++)
            {
                Console.WriteLine(iAns[iCnt]);
            }
        }
    }
}
