using CorpusSMDemo.DataAccess;
using CorpusSMDemo.Entities;
using CorpusSMDemo.ViewModels.Admin;
using CorpusSMDemo.ViewModels.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(AdminLoginVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            MyDbContext context = new MyDbContext();
            Admin item = context.Admins.Where(u => u.Username == model.Username && u.Password == model.Password)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("AuthenticationFailed", "Wrong username or password");
                return View(model);
            }

            this.HttpContext.Session.Remove("loggedUser");
            this.HttpContext.Session.Remove("loggedUserId");
            this.HttpContext.Session.Remove("LoggedUserUsername");

            this.HttpContext.Session.SetString("loggedAdmin", model.Username);
            this.HttpContext.Session.SetString("loggedAdminId", item.Id.ToString());
            this.HttpContext.Session.SetString("LoggedAdminUsername", item.Username);

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult Login()
        {
            if (this.HttpContext.Session.GetString("loggedUser") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (this.HttpContext.Session.GetString("loggedUser") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            UsersRepository repo = new UsersRepository();
            User item = repo.GetFirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);

            if (item == null)
            {
                ModelState.AddModelError("AuthenticationFailed", "Wrong username or password");
                return View(model);
            }

            this.HttpContext.Session.SetString("loggedUser", model.Username);
            this.HttpContext.Session.SetString("loggedUserId", item.Id.ToString());
            this.HttpContext.Session.SetString("LoggedUserUsername", item.Username);

            //ViewData["Username"] = model.Username;

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            if (this.HttpContext.Session.GetString("loggedUser") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            this.HttpContext.Session.Remove("loggedUser");
            this.HttpContext.Session.Remove("loggedUserId");
            this.HttpContext.Session.Remove("LoggedUserUsername");
            this.HttpContext.Session.Remove("loggedAdmin");
            this.HttpContext.Session.Remove("loggedAdminId");
            this.HttpContext.Session.Remove("loggedAdminUsername");

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            MyDbContext context = new MyDbContext();

            User item = new User();

            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;

            context.Users.Add(item);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
