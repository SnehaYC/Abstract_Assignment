using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class ContractEmployee : Employee
    {
        public DateTime ContractDate { get; set; }
        public int DurationInMonths { get; set; }
        public decimal Charges { get; set; }

        public ContractEmployee(string uniqueId, string name, string reportingManager, DateTime contractDate, int durationInMonths, decimal charges)
            : base(uniqueId, name, reportingManager)
        {
            ContractDate = contractDate;
            DurationInMonths = durationInMonths;
            Charges = charges;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Contract Date: {ContractDate.ToShortDateString()}");
            Console.WriteLine($"Duration (Months): {DurationInMonths}");
            Console.WriteLine($"Charges: {Charges:C}");
        }
    }

}
