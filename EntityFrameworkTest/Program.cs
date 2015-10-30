using EntityFrameworkTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var ctx = new DataBaseContext())
            {
                Address address = new Address { pin = "25",address="Bangalore5" };
                Person person = new Person { name="test5",surname="T5",Address=address};

                ctx.Person.Add(person);
                ctx.SaveChanges();

                Person per = ctx.Person.FirstOrDefault() ;
            }
        }
    }
}
