//2. WAP to display sum of 3 by 3 matrices

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program2
    {
        public static void Main()
        {
            int[,] arr1 =
            {
                {1,2,3},
                {3,4,5},
                {4,5,6}
            };

            int[,] arr2 =
            {
                {1,2,3},
                {3,4,5},
                {4,5,6}
            };
            int iRow = arr1.GetLength(0);
            int iCol = arr2.GetLength(1);
            int[,] ans = new int[iRow, iCol];

            for (int iCnt1 = 0; iCnt1 < iRow; iCnt1++)
            {
                for (int iCnt2 = 0; iCnt2 < iCol; iCnt2++)
                {

                    ans[iCnt1, iCnt2] = arr1[iCnt1,iCnt2] + arr2[iCnt1, iCnt2];
                }
            }

            for (int iCnt1 = 0; iCnt1 < iRow; iCnt1++)
            {
                for (int iCnt2 = 0; iCnt2 < iCol; iCnt2++)
                {
                    Console.Write(ans[iCnt1, iCnt2] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
