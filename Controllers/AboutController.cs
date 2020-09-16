using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripTravel.Models.Classes;

namespace TripTravel.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        // GET: About
        public ActionResult Index()
        {
            var deger = c.Abouts.ToList();
            return View(deger);
        }
    }
}