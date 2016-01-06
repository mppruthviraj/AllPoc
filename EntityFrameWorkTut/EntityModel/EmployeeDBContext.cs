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
        public DbSet<Customer> Customer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<TestTable> TestTable { get; set; }


        public EmployeeDBContext():base("EmployeeDBContext")
        {
            Database.SetInitializer<EmployeeDBContext>(new DropCreateDatabaseAlways<EmployeeDBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().MapToStoredProcedures();
            
            base.OnModelCreating(modelBuilder);
        }

    }
}