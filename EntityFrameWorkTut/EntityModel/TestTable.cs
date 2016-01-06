using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWorkTut.EntityModel
{
    public class TestTable
    {
        [Key, Column(Order = 0)]
        public string TestProp1 { get; set; }
        [Key, Column(Order = 1)]
        public string TestProp2 { get; set; }

    }
}