using CST_356_Lab_2.Data;
using CST_356_Lab_2.Data.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CST_356_Lab_2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if (Database.Users == null)
            {
                Database.Users = new List<User>();
            }
            return View(Database.Users);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (!user.IsValid())
                return View(user);
            if (Database.Users == null)
            {
                Database.Users = new List<User>();
            }
            Database.Users.Add(user);
            return View("Index", Database.Users);
        }
    }
}