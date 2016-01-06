using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkTut.EntityModel
{
    public class EntityMethods
    {
        EmployeeDBContext empContext = new EmployeeDBContext();
        public List<Departments> GetDepartMents()
        {
            //return empContext.Departments.Include("Employees").ToList();
            return null;
        }

        public void Insert(Employees employee)
        {
            empContext.Employees.Add(employee);
            empContext.SaveChanges();
        }

        public void InsertListOFEmployees(List<Employees> employees)
        {
            empContext.Employees.AddRange(employees); ;
        }

        public void InsertCustomer(List<Customer> customerList)
        {
            empContext.Customer.AddRange(customerList);
        }

        public void SaveData()
        {
            empContext.SaveChanges();
        }


        public void Update(Employees employee)
        {
            Employees empToUpdate = empContext.Employees.FirstOrDefault(emp => emp.ID == employee.ID);
            empToUpdate.FirstName = employee.FirstName;
            empToUpdate.LastName = employee.LastName;
            empToUpdate.Gender = employee.Gender;
            empToUpdate.JobTitle = employee.JobTitle;
            empToUpdate.Salary = employee.Salary;
            empContext.SaveChanges();
        }
        public void Delete(Employees employee)
        {
            Employees empToDelete = empContext.Employees.FirstOrDefault(emp => emp.ID == employee.ID);
            empContext.Employees.Remove(empToDelete);
            empContext.SaveChanges();
        }

    }
}