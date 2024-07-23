//1.Print sum and average of elements of an Array

namespace Assignment_2
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int iSum = 0, iAvg = 0;
            for (int iCnt = 0; iCnt < arr.Length; iCnt++)
            {
                iSum += arr[iCnt];
            }
            Console.WriteLine("Summation of number is:" + iSum);
            iAvg = iSum / arr.Length;
            Console.WriteLine("Average of number is:" + iAvg);
        }
    }
}
