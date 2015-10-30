using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVCApplication.Models
{
    public class Users
    {
        public List<UserModel> _userList = new List<UserModel>();
        public Users()
        {
            
            _userList.Add(new UserModel { 
            
                FirstName="RAJ",
                LastName = "Kashyap",
                Address="Karnataka",
                Email="raj@raj.com",
                DOB=Convert.ToDateTime("6/22/1976"),
                Salary=40000
            
            });
            _userList.Add(new UserModel
            {

                FirstName = "RAJ2",
                LastName = "Kashyap2",
                Address = "Karnataka2",
                Email = "raj2@raj.com",
                DOB = Convert.ToDateTime("6/22/1986"),
                Salary = 50000

            });
            _userList.Add(new UserModel
            {

                FirstName = "RAJ3",
                LastName = "Kashyap3",
                Address = "Karnataka3",
                Email = "raj3@raj.com",
                DOB = Convert.ToDateTime("6/22/1996"),
                Salary = 60000

            });
        }

        public void CreateUser(UserModel userModel)
        {
            _userList.Add(userModel);
        }

        public void UpdateUser(UserModel userModel)
        {
            foreach(UserModel userLst in _userList)
            {
                if(userLst.Email == userModel.Email)
                {
                    _userList.Remove(userLst);
                    _userList.Add(userModel);
                    break;
                }
            }
        }
    }
}