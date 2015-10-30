using EntityFrameworkTest.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(): base("DBConnectionString")
        {
            //If model change, It will re-create new database.
            Database.SetInitializer<DataBaseContext>(new CreateDatabaseIfNotExists<DataBaseContext>());
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }

    }
}
