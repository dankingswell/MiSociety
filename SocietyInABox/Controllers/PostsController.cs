using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocietyInABox.Models;
using SocietyInABox.ViewModels;

namespace SocietyInABox.Controllers
{
    public class PostsController : Controller
    {
        private ApplicationDbContext _context;

        public PostsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Posts
        public ActionResult Index()
        {
            var First30 = _context.Posts.Take(30).ToList();


            var ViewModel = new PostsViewModel
            {
                Posts = First30
            };

            return View(ViewModel);
        }
    }
}