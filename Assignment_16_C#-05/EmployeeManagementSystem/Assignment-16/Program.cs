namespace Assignment_16
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            bool continueAdding = true;

            while (continueAdding)
            {
                Console.WriteLine("Enter employee type (Contract/Payroll): ");
                string employeeType = Console.ReadLine();

                Console.WriteLine("Enter unique ID: ");
                string uniqueId = Console.ReadLine();

                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter reporting manager: ");
                string reportingManager = Console.ReadLine();

                if (employeeType.Equals("Contract", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter contract date (yyyy-mm-dd): ");
                    DateTime contractDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Enter contract duration in months: ");
                    int durationInMonths = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter contract charges: ");
                    decimal charges = decimal.Parse(Console.ReadLine());

                    employees.Add(new ContractEmployee(uniqueId, name, reportingManager, contractDate, durationInMonths, charges));
                }
                else if (employeeType.Equals("Payroll", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter joining date (yyyy-mm-dd): ");
                    DateTime joiningDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Enter experience in years: ");
                    int experienceInYears = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter basic salary: ");
                    decimal basicSalary = decimal.Parse(Console.ReadLine());

                    employees.Add(new PayrollEmployee(uniqueId, name, reportingManager, joiningDate, experienceInYears, basicSalary));
                }
                else
                {
                    Console.WriteLine("Invalid employee type. Please enter 'Contract' or 'Payroll'.");
                }

                Console.WriteLine("Do you want to add another employee? (yes/no): ");
                continueAdding = Console.ReadLine().Trim().ToLower() == "yes";
            }

            // this will Display all employee details
            foreach (var employee in employees)
            {
                employee.DisplayDetails();
                Console.WriteLine(); 
            }

            // this will Print total number of employees
            Console.WriteLine($"Total number of Employees: {employees.Count}");
        }
    }

}
