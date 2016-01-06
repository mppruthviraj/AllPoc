using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkTut.EntityModel
{
    public class EmployeeDBContextSeeder : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        //protected override void seed(employeedbcontext context)
        //{
        //    departments department1 = new departments()
        //    {

        //        name = "it",
        //        location = "bangalore",
        //        employees = new list<employees>() { 
                
        //          new employees(){

        //              firstname="ram",lastname="k", gender="m", salary=90, jobtitle="developer"
        //            },
        //           new employees(){

        //              firstname="kannaya",lastname="v", gender="m", salary=54, jobtitle="support"
        //            },
        //           new employees(){

        //              firstname="teju",lastname="k", gender="f", salary=92, jobtitle="admin"
        //            },
        //           new employees(){

        //              firstname="yashu",lastname="p", gender="f", salary=54, jobtitle="developer"
        //            }
                
        //        }

        //    };

        //    departments department2 = new departments()
        //    {

        //        name = "payroll",
        //        location = "chennai",
        //        employees = new list<employees>() { 
                
        //          new employees(){

        //              firstname="kavitha",lastname="y", gender="f", salary=65, jobtitle="accounts"
        //            },
        //           new employees(){

        //              firstname="mahendar",lastname="p", gender="m", salary=78, jobtitle="supervisor"
        //            },
        //           new employees(){

        //              firstname="sachin",lastname="t", gender="m", salary=98, jobtitle="account"
        //            }                
        //        }

        //    };

        //    departments department3 = new departments()
        //    {

        //        name = "admin",
        //        location = "delhi",
        //        employees = new list<employees>() { 
                
        //          new employees(){

        //              firstname="ramcharan",lastname="c", gender="m", salary=67, jobtitle="admin"
        //            },
        //           new employees(){

        //              firstname="sudeep",lastname="s", gender="m", salary=98, jobtitle="admin"
        //            },
        //           new employees(){

        //              firstname="yograj",lastname="b", gender="m", salary=76, jobtitle="admin"
        //            },
        //           new employees(){

        //              firstname="mohini",lastname="e", gender="f", salary=67, jobtitle="admin"
        //            }
                
        //        }

        //    };


        //    context.departments.add(department1);
        //    context.departments.add(department2);
        //    context.departments.add(department3);

        //    base.seed(context);
        //}

    }
}