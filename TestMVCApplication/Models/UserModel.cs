using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVCApplication.Models
{
    public class UserModel
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage="First Name Required")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage="Email address required")]
        [StringLength(50)]
        public string Email { get; set; }

        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Range(100,1000000)]
        public decimal Salary { get; set; }
    }
}