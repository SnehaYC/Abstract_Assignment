using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class PayrollEmployee : Employee
    {
        public DateTime JoiningDate { get; set; }
        public int ExperienceInYears { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Da { get; set; }
        public decimal Hra { get; set; }
        public decimal Pf { get; set; }

        public PayrollEmployee(string uniqueId, string name, string reportingManager, DateTime joiningDate, int experienceInYears, decimal basicSalary)
            : base(uniqueId, name, reportingManager)
        {
            JoiningDate = joiningDate;
            ExperienceInYears = experienceInYears;
            BasicSalary = basicSalary;
            CalculateSalaryComponents();
        }

        private void CalculateSalaryComponents()
        {
            if (ExperienceInYears > 10)
            {
                Da = 0.10m * BasicSalary;
                Hra = 0.085m * BasicSalary;
                Pf = 6200;
            }
            else if (ExperienceInYears > 7)
            {
                Da = 0.07m * BasicSalary;
                Hra = 0.065m * BasicSalary;
                Pf = 4100;
            }
            else if (ExperienceInYears > 5)
            {
                Da = 0.041m * BasicSalary;
                Hra = 0.038m * BasicSalary;
                Pf = 1800;
            }
            else
            {
                Da = 0.019m * BasicSalary;
                Hra = 0.02m * BasicSalary;
                Pf = 1200;
            }
        }

        public decimal CalculateNetSalary()
        {
            return BasicSalary + Da + Hra - Pf;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Joining Date: {JoiningDate.ToShortDateString()}");
            Console.WriteLine($"Experience (Years): {ExperienceInYears}");
            Console.WriteLine($"Basic Salary: {BasicSalary:C}");
            Console.WriteLine($"DA: {Da:C}");
            Console.WriteLine($"HRA: {Hra:C}");
            Console.WriteLine($"PF: {Pf:C}");
            Console.WriteLine($"Net Salary: {CalculateNetSalary():C}");
        }
    }

}
