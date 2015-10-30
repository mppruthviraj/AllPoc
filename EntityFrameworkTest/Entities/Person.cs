using EntityFrameworkTest.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }
        public string surname { get; set; }

        
        public virtual Address Address { get; set; }

    }
}
