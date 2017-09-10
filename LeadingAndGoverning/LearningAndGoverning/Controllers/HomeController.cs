using LearningAndGoverning.Services;
using LearningAndGoverning.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningAndGoverning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Clients()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ContactViewModel vm = new ContactViewModel();

            TempData["Success"] = string.Empty;
            TempData["Error"] = string.Empty;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            else
            {
                using (MessagingService messenger = new MessagingService())
                {
                    string success = "success";
                    bool response = messenger.SendMessage(vm);

                    if (response)
                    {
                        TempData["Success"] = success;
                    }
                    else
                    {
                        TempData["Error"] = "There was an error processing your request. Please try again. " + response;
                    }
                }
            }

            return View(vm);
        }
    }
}