using OnlineShoppingStore.Models;
using OnlineShoppingStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public UserAuthenticationDBContext db = new UserAuthenticationDBContext(); // Replace "YourDbContext" with your actual database context class name

        // GET: Account

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAuthenticationModel user)
        {
            if (ModelState.IsValid)
            {
                // TODO: Check if the username is unique and other validations
                db.UserAuthentication.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(user);
        }

        [HttpGet]
        public ActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // TODO: Implement authentication logic, e.g., compare username and hashed password with the database
            var user = db.UserAuthentication.SingleOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Session["UserId"] = user.UserId;
                return RedirectToAction("Index", "Home"); // Redirect to the dashboard or any other authenticated page
            }

            ModelState.AddModelError("", "Invalid username or password.");
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}