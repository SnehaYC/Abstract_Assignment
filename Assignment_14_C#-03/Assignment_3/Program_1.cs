// 1. Write a program in C# Sharp to count a total number of duplicate elements in an array

namespace Assignment_3
{
    internal class Program_1
    {
        static void Main(string[] args)
        {
            int[] arr = [3, 23, 2, 2, 5, 4, 5, 5, 6, 2, 2, 2];

            for (int iNo1 = 0; iNo1 < arr.Length; iNo1++)
            {
                int iCnt = 1;
                for (int iNo2 = iNo1 + 1; iNo2 < arr.Length; iNo2++)
                {
                    if (arr[iNo1] == arr[iNo2])
                    {
                        iCnt++;
                        arr[iNo2] = -1;
                    }

                }
                if (arr[iNo1] != -1)
                {
                    Console.WriteLine($"{arr[iNo1]} is repeated {iCnt} times..");
                }
            }
        }
    }
}
