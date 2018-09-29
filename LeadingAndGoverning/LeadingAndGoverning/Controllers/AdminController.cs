using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeadingAndGoverning.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                RedirectToAction("Index", "Home");
            }

            // TODO: Manage Home Page Tiles

            // TODO: Manage Client Details

            return View();
        }

        public ActionResult ContentManagement()
        {
            return View();
        }
    }
}