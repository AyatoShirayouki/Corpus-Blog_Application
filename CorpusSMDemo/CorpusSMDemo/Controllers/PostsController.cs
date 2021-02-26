using CorpusSMDemo.ActionFilters;
using CorpusSMDemo.DataAccess;
using CorpusSMDemo.Entities;
using CorpusSMDemo.ViewModels.Posts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.Controllers
{
    [UserAuthenticationFilter]
    public class PostsController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            PostsRepository repo = new PostsRepository();
            UsersRepository Urepo = new UsersRepository();
            model.User = Urepo.GetById(loggedUserId);
            model.Items = repo.GetAll(c => c.UserId == loggedUserId);
            return View(model);
        }

        public IActionResult SharedWithMe(SharedWithMeVM model)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            UserSharingRepository repo = new UserSharingRepository();
            MyDbContext context = new MyDbContext();
            model.Items = context.SharedPosts.Where(c => c.UserId == loggedUserId).Select(utp => utp.ParentPost).ToList();
            model.User = context.SharedPosts.Where(c => c.UserId != loggedUserId).Select(utp => utp.ParentUser).FirstOrDefault();
            return View(model);
        }

        [HttpGet]
        public IActionResult Share(int id)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));

            ShareVM model = new ShareVM();
            MyDbContext context = new MyDbContext();
            PostsRepository pRepo = new PostsRepository();
            model.Post = pRepo.GetFirstOrDefault(u => u.Id == id);

            model.SharedWith = context.SharedPosts
                .Include(c => c.ParentUser)
                .Include(c => c.ParentPost)
                .Where(u => u.PostId == model.Post.Id)
                .Select(u => u.ParentUser)
                .ToList();

            UserSharingRepository u = new UserSharingRepository();
            model.User = context.SharedPosts.Where(c => c.UserId == loggedUserId).Select(utp => utp.ParentUser).FirstOrDefault();

            model.Users = new List<User>();
            UsersRepository uRepo = new UsersRepository();
            foreach (User user in uRepo.GetAll())
            {
                if (model.SharedWith.Where(i => i.Id == user.Id).Count() > 0)
                {
                    continue;
                }
                model.Users.Add(user);
            }


            return View(model);
        }

        [HttpPost]
        public IActionResult Share(ShareVM model)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                uow.BeginTransaction();

                UserSharingRepository repo = new UserSharingRepository(uow);
                List<UserSharing> shares = repo.GetAll(i => i.PostId == model.PostId);

                foreach (int userId in model.UserIds)
                {

                    if (shares.Where(i => i.UserId == userId).Count() > 0)
                    {
                        continue;
                    }

                    UserSharing userToContact = new UserSharing();
                    userToContact.UserId = userId;
                    userToContact.PostId = model.PostId;

                    repo.Save(userToContact);
                }
                uow.Commit();
            }

            return RedirectToAction("Share", "Posts", new { id = model.PostId });
        }

        public IActionResult RevokeAccess(int UserId, int PostId)
        {
            MyDbContext context = new MyDbContext();
            UserSharing item = context.SharedPosts
                .Where(u => u.UserId == UserId && u.PostId == PostId)
                .FirstOrDefault();

            if (item != null)
            {
                context.SharedPosts.Remove(item);
                context.SaveChanges();
            }

            return RedirectToAction("Share", "Posts", new { id = PostId });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            PostsRepository repo = new PostsRepository();

            Post item = new Post();

            item.UserId = loggedUserId;
            item.Title = model.Title;
            item.Content = model.Content;

            repo.Save(item);
            return RedirectToAction("Index", "Posts");
        }

        public IActionResult Delete(int id)
        {
            PostsRepository repo = new PostsRepository();
            Post item = new Post();
            item.Id = id;

            UserSharingRepository USRrepo = new UserSharingRepository();
            List<UserSharing> list = USRrepo.GetAll(u => u.PostId == id);
            if (list != null)
            {
                foreach (UserSharing u in list)
                {
                    USRrepo.Delete(u);
                }
            }

           repo.Delete(item);

            return RedirectToAction("Index", "Posts");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            PostsRepository repo = new PostsRepository();
            Post item = repo.GetFirstOrDefault(u => u.Id == id);
            if (item == null)
            {
                return RedirectToAction("Index", "Posts");
            }
            EditVM model = new EditVM();

            model.Id = item.Id;
            model.UserId = item.UserId;
            model.Title = item.Title;
            model.Content = item.Content;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            PostsRepository repo = new PostsRepository();

            Post item = new Post();

            item.Id = model.Id;
            item.UserId = model.UserId;
            item.Title = model.Title;
            item.Content = model.Content;

            repo.Save(item);
            return RedirectToAction("Index", "Posts");
        }
    }
}
