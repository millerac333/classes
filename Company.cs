// Create a custom type for Company. A company has the following properties.
// Date founded (DateTime)
// Company name (string)
// Employees (List<Employee>)
using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public HashSet<string> EmployeeList = new HashSet<string>();

        public Company(string NameOfComapany, DateTime creationDate)
        {
            Name = NameOfComapany;
            CreatedOn = creationDate;
        }
    }
}