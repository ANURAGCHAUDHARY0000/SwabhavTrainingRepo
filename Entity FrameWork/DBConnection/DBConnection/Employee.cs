﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace DBConnection
{
    //change table name
  // [Table("tblEmployess")]
    public class Employee
    {
        // Scalar Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

       public int DepartmentId { get; set; }
       [ForeignKey("DepartmentId")]

       // Navigation Property
        public Department Department { get; set; }

        public string JobTitle { get; set; }
    }
}