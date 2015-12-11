using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWorkTut
{
    public class Employees
    {
        public int ID { get; set; }

        [Column("First_Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string JobTitle { get; set; }
        public int Department_ID { get; set; }
        [ForeignKey("Department_ID")]
        public Departments Deparment { get; set; }
    }
}