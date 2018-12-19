using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class Attendance
    {
        public Int64 TimesheetID { get; set; }
        public DateTime AttendanceDate { get; set; }
        public DateTime TimeIN { get; set; }
        public DateTime TimeOUT { get; set; }
        public DateTime OverTimeIN { get; set; }
        public DateTime OverTimeOUT { get; set; }
        public Int32 Late { get; set; }
        public Int32 UnderTime { get; set; }
        public Int32 OverTime { get; set; }
        public Int32 GrandTotal { get; set; }
    }
}