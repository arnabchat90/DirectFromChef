using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DirectFromChef.Models;

namespace DirectFromChef.Controllers
{
    
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var isChef = false;
            var currentUser = db.Users.Where(c => c.UserName == User.Identity.Name).FirstOrDefault();

            if(currentUser !=null)
                Session["CurrentUserId"] = currentUser.Id;
            if (currentUser != null)
            {
                isChef = db.ChefDetails.Where(cd => cd.AspNetUsersId == currentUser.Id).FirstOrDefault() != null ? true : false;
            }

            Session["IsChef"] = isChef;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}