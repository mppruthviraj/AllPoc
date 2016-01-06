using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameWorkTut.EntityModel
{
    public class Customer
    {
        [Key]
        public int CustomerID{get;set;}

        public string CustomerName { get; set; }

        public string CustomerLocation { get; set; }

        public string CustomerMoney { get; set; }
    }
}