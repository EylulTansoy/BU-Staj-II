using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripTravel.Models.Classes;

namespace TripTravel.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        // GET: Blog
        public ActionResult Index()
        {
            var blog = c.Blogs.ToList();
            return View(blog);
        }
        public ActionResult BlogDetay(int id)
        {
            var blogBul = c.Blogs.Where(x => x.Id == id).ToList();
            return View(blogBul);
        }
    }
}