// The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.

// In the Main method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.

// You will define the employee type.

using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company SmellsFunny = new Company("Smells Funny, INC.", new DateTime(2018, 08, 27));

            // Create three employees
            Employee aaron = new Employee()
            {
                firstName = "Aaron",
                lastName = "Miller",
                title = "CEO",
                startDate = new DateTime(2018, 8, 24),
            };
            Employee michael = new Employee()
            {
                firstName = "Michael",
                lastName = "Roberts",
                title = "CFO",
                startDate = new DateTime(2018, 8, 24),
            };
            Employee shu = new Employee()
            {
                firstName = "Shu",
                lastName = "Sajid",
                title = "Vice President",
                startDate = new DateTime(2018, 8, 24),
            };

            // Assign the employees to the company
            SmellsFunny.NewHire(aaron);
            SmellsFunny.NewHire(michael);
            SmellsFunny.NewHire(shu);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            SmellsFunny.DisplayEmployees();
        }
    }
}
