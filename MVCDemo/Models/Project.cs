using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public List<EmployeeAssignment> EmployeeAssignments { get; set; }
    }
}
