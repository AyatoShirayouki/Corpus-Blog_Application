using CorpusSMDemo.DataAccess;
using CorpusSMDemo.Entities;
using CorpusSMDemo.ViewModels.Comments;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            PostsRepository Prepo = new PostsRepository();
            CommentsRepository Crepo = new CommentsRepository();

            model.Post = Prepo.GetById(model.ParentId);
            model.Items = Crepo.GetAll(c => c.PostId == model.ParentId);

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            CommentsRepository repo = new CommentsRepository();
            Comment item = repo.GetById(id);

            if (item == null)
            {
                return RedirectToAction("Index", "Posts");
            }

            int postId = item.PostId;

            repo.Delete(item);

            return RedirectToAction("Index", "Comments", new { ParentId = postId });
        }

        [HttpGet]
        public IActionResult Create(int parentId)
        {
            CreateVM model = new CreateVM();
            model.PostId = parentId;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            CommentsRepository repo = new CommentsRepository();

            Comment item = new Comment();

            item.PostId = model.PostId;
            item.Content = model.Content;

            repo.Save(item);
            return RedirectToAction("Index", "Comments", new { ParentId = model.PostId });
        }
    }
}
