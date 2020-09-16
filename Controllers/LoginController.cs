using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TripTravel.Models.Classes;

namespace TripTravel.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var info = c.Admins.FirstOrDefault(x => x.Kullanici == admin.Kullanici && x.Sifre == admin.Sifre);
            if(info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Kullanici, false);
                Session["Kullanici"] = info.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}