using EntityFrameWorkTut.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameWorkTut
{
    public partial class DataShowPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EntityMethods em = new EntityMethods();
            //em.InsertCustomer(new List<Customer>() { new Customer() { CustomerName="Raju",CustomerLocation="New York" }, new Customer() {CustomerName="Pruthvi",CustomerLocation="Himalaya" } });
            //em.InsertListOFEmployees(new List<>);
            //Employees emp = new Employees();
            //emp.

            EmployeeDBContext ctx = new EmployeeDBContext();
            //ctx.Customer.Add(new Customer (){ CustomerLocation="asd",CustomerMoney="3000",CustomerName="ads" });
            ctx.User.Add(new User() { Email = "tt", Password = "ii", UserName = "pp", UserProfile = new UserProfile() { Address = "aa", LastName = "a", FirstName = "uu" } });
            ctx.SaveChanges();

            List<User> userList = ctx.User.Include("UserProfile").ToList();
        }
    }
}