using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningAndGoverning.Controllers
{
    public class PhilosophyController : Controller
    {
        // GET: Philosophy
        public ActionResult Index()
        {
            return View();
        }
    }
}