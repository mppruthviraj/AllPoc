﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkTut
{
    public class Departments
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Employees> Employees { get; set; }

        public string Locaiton { get; set; }
    }
}