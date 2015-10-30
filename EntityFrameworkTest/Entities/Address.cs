using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Entities
{
    public class Address
    {
        [Key]
        public int personAdressId { get; set; }
        public string address { get; set; }
        public string pin { get; set; }

        //[InverseProperty("Person")]
        public virtual ICollection<Person> Person { get; set; }
    }
}
