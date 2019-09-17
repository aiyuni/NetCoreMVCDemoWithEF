using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    /**
        * This class is an Entity class. It represents the Employee table in the database. 
        */
    public class Employee
    {
        //Primary Key -- the variable name should be in the form of ClassNameID, or just ID. Otherwise we must tag it using [Key] or EF won't know.
        public int EmployeeID { get; set; }

        //Other columns of this table
        [MaxLength(256)]
        public string Name { get; set; }

        public int Salary { get; set; }

        public List<EmployeeAssignment> EmployeeAssignments { get; set; }
    }
}

