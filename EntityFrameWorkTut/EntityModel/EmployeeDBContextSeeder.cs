using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkTut.EntityModel
{
    public class EmployeeDBContextSeeder : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            Departments department1 = new Departments()
            {

                Name = "IT",
                Location = "Bangalore",
                Employees = new List<Employees>() { 
                
                  new Employees(){

                      FirstName="Ram",LastName="K", Gender="M", Salary=90, JobTitle="Developer"
                    },
                   new Employees(){

                      FirstName="Kannaya",LastName="V", Gender="M", Salary=54, JobTitle="Support"
                    },
                   new Employees(){

                      FirstName="Teju",LastName="K", Gender="F", Salary=92, JobTitle="Admin"
                    },
                   new Employees(){

                      FirstName="Yashu",LastName="P", Gender="F", Salary=54, JobTitle="Developer"
                    }
                
                }

            };

            Departments department2 = new Departments()
            {

                Name = "Payroll",
                Location= "Chennai",
                Employees = new List<Employees>() { 
                
                  new Employees(){

                      FirstName="Kavitha",LastName="Y", Gender="F", Salary=65, JobTitle="Accounts"
                    },
                   new Employees(){

                      FirstName="Mahendar",LastName="P", Gender="M", Salary=78, JobTitle="Supervisor"
                    },
                   new Employees(){

                      FirstName="Sachin",LastName="T", Gender="M", Salary=98, JobTitle="Account"
                    }                
                }

            };

            Departments department3 = new Departments()
            {

                Name = "Admin",
                Location = "Delhi",
                Employees = new List<Employees>() { 
                
                  new Employees(){

                      FirstName="Ramcharan",LastName="C", Gender="M", Salary=67, JobTitle="Admin"
                    },
                   new Employees(){

                      FirstName="Sudeep",LastName="S", Gender="M", Salary=98, JobTitle="Admin"
                    },
                   new Employees(){

                      FirstName="Yograj",LastName="B", Gender="M", Salary=76, JobTitle="Admin"
                    },
                   new Employees(){

                      FirstName="Mohini",LastName="E", Gender="F", Salary=67, JobTitle="Admin"
                    }
                
                }

            };


            context.Departments.Add(department1);
            context.Departments.Add(department2);
            context.Departments.Add(department3);

            base.Seed(context);
        }

    }
}