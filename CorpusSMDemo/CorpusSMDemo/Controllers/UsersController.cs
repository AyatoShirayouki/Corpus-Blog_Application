using CorpusSMDemo.ActionFilters;
using CorpusSMDemo.DataAccess;
using CorpusSMDemo.Entities;
using CorpusSMDemo.ViewModels.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.Controllers
{
    [UserAuthenticationFilter]
    public class UsersController : Controller
    {
       public IActionResult Index(IndexVM model)
        {
            UsersRepository repo = new UsersRepository();
            //MyDbContext context = new MyDbContext();
            User item = repo.GetFirstOrDefault(u => u.Id == int.Parse(this.HttpContext.Session.GetString("loggedUserId")));
            if (item == null)
            {
                return RedirectToAction("Index", "Users");
            }
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            model.Email = item.Email;

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            int id = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            UsersRepository repo = new UsersRepository();
            User item = repo.GetFirstOrDefault(u => u.Id == int.Parse(this.HttpContext.Session.GetString("loggedUserId")));
            if (item == null)
            {
                return RedirectToAction("Index", "Users");
            }
            EditVM model = new EditVM();

            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            model.Email = item.Email;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            UsersRepository repo = new UsersRepository();
            User item = new User();

            item.Id = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;

            repo.Save(item);
            
            return RedirectToAction("Index", "Users");
        }
    }
}
