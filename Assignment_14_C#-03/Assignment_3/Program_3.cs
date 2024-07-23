/* 
 * 3. Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. The charge are as follow : 

Unit	                               Charge/unit
upto 199	                        @1.20
200 and above but less than 400	        @1.50
400 and above but less than 600	        @1.80
600 and above	                        @2.00

If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-

Test Data :
1001
James
800
Expected Output :
Customer IDNO :1001
Customer Name :James
unit Consumed :800
Amount Charges @Rs. 2.00 per unit : 1600.00
Surchage Amount : 240.00
Net Amount Paid By the Customer : 1840.00
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program_3
    {
        public static void Main()
        {
            Console.WriteLine("Enter customer ID:");
            int iCust_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter customer Name:");
            String sCust_name = Console.ReadLine();

            Console.WriteLine("Enter customer Unit :");
            int iUnit = int.Parse(Console.ReadLine());

            double d_Charge = 0;
            double surcharge = 0;
            double NetAmount = 0;

            if (iUnit <= 199)
            {
                d_Charge = 1.20 * iUnit;


            }
            else if (iUnit >= 200 && iUnit < 400)
            {
                d_Charge = 1.50 * iUnit;

            }
            else if (iUnit >= 400 && iUnit < 600)
            {
                d_Charge = 1.80 * iUnit;

            }
            else if (iUnit >= 600)
            {
                d_Charge = 2.00 * iUnit;

            }

            if (d_Charge > 400)
            {
                surcharge = (d_Charge * 15) / 100;
            }

            NetAmount = d_Charge + surcharge;

            if (NetAmount < 100)
            {
                NetAmount = 100;
            }
            Console.WriteLine($"Customer IDNO : {iCust_id}");
            Console.WriteLine($"Customer Name :{sCust_name}");
            Console.WriteLine($"Unit Consumed : {iUnit}");
            Console.WriteLine($"Amount Charges @Rs. {iUnit} per unit : {d_Charge}");
            Console.WriteLine($"Surchage Amount : {surcharge}");
            Console.WriteLine($"Net Amount Paid By the Customer : {NetAmount}");

        }
    }
}
