using System;
using System.Collections.Generic;

namespace demoHRMS.Models
{
    public partial class Employee
    {
        
        public Employee()
        {
            Attendance = new HashSet<Attendance>();
            Salary = new HashSet<Salary>();
        }

        public decimal IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cin { get; set; }
        public string Department { get; set; }
        public string State { get; set; }

        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<Salary> Salary { get; set; }
    }
}
