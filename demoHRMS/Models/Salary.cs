using System;
using System.Collections.Generic;

namespace demoHRMS.Models
{
    public partial class Salary
    {
        public decimal IdEmployee { get; set; }
        public decimal IdSalary { get; set; }
        public int? TypeSalary { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Taxes { get; set; }
        public bool? Validation { get; set; }
        public int? HoursWorked { get; set; }
        public int? Month { get; set; }

        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
