// Create a custom type for Employee. An employee has the following properties.
// First name (string)
// Last name (string)
// Title (string)
// Start date (DateTime)

using System;
using System.Collections.Generic;

namespace Classes
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public DateTime startDate { get; set; }
    }
}