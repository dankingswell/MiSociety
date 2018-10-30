using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SocietyInABox.Models;
using SocietyInABox.ViewModels;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace SocietyInABox.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = RoleName.CanManageMembers)]
        public ActionResult Members ()
        {
            var NonAdminMembers = _context.Members.ToList();
            var ViewModel = new MembersOnlyViewModel()
            {
                Members = NonAdminMembers
            };

            return View(ViewModel);
        }

        [Authorize(Roles = RoleName.CanManageContent)]
        public ActionResult CreatePost()
        {
            
            if (User.IsInRole(RoleName.CanManageContent))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
           
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageContent)]
        public ActionResult PostCreationRequest(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();

            return RedirectToAction("Index", "Posts");
        }

       [Authorize(Roles = RoleName.CanManageMembers)]
       public ActionResult RemoveMember(int Id)
        {
            var MemberById = _context.Members.SingleOrDefault(m => m.Id == Id);
            if (MemberById == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Members.Remove(MemberById);
            _context.SaveChanges();

            return RedirectToAction("Members", "Admin");
        }

        [Authorize(Roles = RoleName.CanManageMembers)]
        public ActionResult EditMember(int Id)
        {
            var MemberById = _context.Members.SingleOrDefault(m => m.Id == Id);

            return View(MemberById);
        }

        [HttpPost]
        public ActionResult EditRequest(Member member)
        {
            Console.WriteLine(member);
            var MemberById = _context.Members.SingleOrDefault(m => m.Id == member.Id);

            if (MemberById != null)
            {
                MemberById.UserName = member.UserName;
                MemberById.FirstName = member.FirstName;
                MemberById.LastName = member.LastName;
                MemberById.DateOfBirth = member.DateOfBirth;
            }

            _context.SaveChanges();

            return RedirectToAction("Members", "Admin");
        }
    }
}