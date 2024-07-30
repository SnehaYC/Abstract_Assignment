using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class Employee
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string ReportingManager { get; set; }

        public Employee(string uniqueId, string name, string reportingManager)
        {
            UniqueId = uniqueId;
            Name = name;
            ReportingManager = reportingManager;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {UniqueId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Reporting Manager: {ReportingManager}");
        }
    }

}
