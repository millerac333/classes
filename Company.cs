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
        public string name { get; }
        public DateTime createdOn { get; }

        // Create a public property for holding a list of current employees
        public HashSet<Employee> EmployeeList = new HashSet<Employee>();

        public Company(string NameOfComapany, DateTime CreationDate)
        {
            name = NameOfComapany;
            createdOn = CreationDate;
        }
        public void NewHire(Employee applicant)
        {
            EmployeeList.Add(applicant);
        }

        public void DisplayEmployees()
        {
            foreach (Employee representative in EmployeeList)
            {
                Console.WriteLine($"{representative.firstName} {representative.lastName} works for {name} as {representative.title} since {representative.startDate} ");
            }
        }

    }

}
