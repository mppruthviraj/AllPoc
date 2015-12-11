using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameWorkTut.EntityModel
{
    public class EmployeeDBContext:DbContext
    {

        public DbSet<Departments> Departments { get; set; }
        public DbSet<Employees> Employees{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }

    }
}