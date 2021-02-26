using CorpusSMDemo.ActionFilters;
using CorpusSMDemo.DataAccess;
using CorpusSMDemo.Entities;
using CorpusSMDemo.ViewModels.Admin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.Controllers
{
    [AdminAuthenticationFilter]
    public class AdminController : Controller
    {
        public IActionResult Index(AdminIndexVM model)
        {
 
            UsersRepository repo = new UsersRepository();
            model.Items =repo.GetAll();
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            UsersRepository repo = new UsersRepository();
            User item = new User();
            
            item.Id = id;

            PostsRepository Prepo = new PostsRepository();
            List<Post> list = Prepo.GetAll(u => u.UserId == id);
            if (list != null)
            {
                foreach (Post u in list)
                {
                    Prepo.Delete(u);
                }
            }

            repo.Delete(item);

            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            UsersRepository repo = new UsersRepository();
            User item = repo.GetFirstOrDefault(u => u.Id == id);
            if (item == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            AdminEditVM model = new AdminEditVM();

            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            model.Email = item.Email;

            return View(model);
        }

        public IActionResult Logout()
        {
            this.HttpContext.Session.Remove("loggedUser");
            this.HttpContext.Session.Remove("loggedUserId");
            this.HttpContext.Session.Remove("LoggedUserUsername");
            this.HttpContext.Session.Remove("loggedAdmin");
            this.HttpContext.Session.Remove("loggedAdminId");
            this.HttpContext.Session.Remove("loggedAdminUsername");

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Edit(AdminEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            UsersRepository repo = new UsersRepository();

            User item = new User();

            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;

            repo.Save(item);
            return RedirectToAction("Index", "Admin");
        }
    }
}
