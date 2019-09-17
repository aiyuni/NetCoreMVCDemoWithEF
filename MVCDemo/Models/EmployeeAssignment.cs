using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class EmployeeAssignment
    {
        public int EmployeeAssignmentID { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeID { get; set; }
        public Project Project { get; set; }
        public int ProjectID { get; set; }


    }
}
