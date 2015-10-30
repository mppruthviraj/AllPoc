using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCApplication.Models;

namespace TestMVCApplication.Controllers
{
    public class UserActionController : Controller
    {
        //
        // GET: /UserAction/
        private static Users _users = new Users();
        public ActionResult Index()
        {
            return View(_users._userList);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create2(UserModel userModel)
        {
            _users.CreateUser(userModel);
            return View();
        }

    }
}
