/*  2. WAP to find the eligibility of admission for a professional course based on the following criteria:
Marks in Maths >=65
Marks in Phy >=55
Marks in Chem>=50
Total in all three subject >=180
or
Total in Math and Phy>=140

Test Data :
Input the marks obtained in Physics :65
Input the marks obtained in Chemistry :51
Input the marks obtained in Mathematics :72
Expected Output :
The candidate is eligible for admission.
 
 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program_2
    {
        public static void Main()
        {
            int iPhyMarks = 65;
            int iChemMarks = 51;
            int iMathMarks = 72;

            int iTotal = iMathMarks + iPhyMarks + iChemMarks;

            int iMathPhyTotal = iMathMarks + iPhyMarks;

            if ((iMathMarks >= 65 && iPhyMarks >= 55 && iChemMarks >= 50) && (iTotal >= 180 || iMathPhyTotal >= 180))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
