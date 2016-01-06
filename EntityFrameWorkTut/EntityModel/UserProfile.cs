using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWorkTut.EntityModel
{
    public class UserProfile
    {
        public int UserProfileID { get; set; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        
        [Required]
        public virtual User User { get; set; }
    }
}