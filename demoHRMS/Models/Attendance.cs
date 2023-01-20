using System;
using System.Collections.Generic;

namespace demoHRMS.Models
{
    public partial class Attendance
    {
        public decimal IdEmployee { get; set; }
        public decimal IdAttendance { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Clockin { get; set; }
        public decimal? Clockout { get; set; }
        public int? Absences { get; set; }

        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
