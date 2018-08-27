// Create a custom type for Company. A company has the following properties.
// Date founded (DateTime)
// Company name (string)
// Employees (List<Employee>)
using System;
using System.Collections.Generic;

// namespace classes
// {
public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; set }
    public DateTime CreatedOn { get; set }
    public List CurrentEmployees { get; set }

    // Create a public property for holding a list of current employees
    public HashSet<string> EmployeeList = new HashSet<string>();
}