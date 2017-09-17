using LearningAndGoverning.Services;
using LearningAndGoverning.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningAndGoverning.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ContactViewModel vm = new ContactViewModel();

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            else
            {
                using (MessagingService messenger = new MessagingService())
                {
                    bool response = messenger.SendMessage(vm);

                    if (response)
                    {
                        vm = new ContactViewModel();

                        TempData["SuccessTitle"] = "Thank you!";
                        TempData["Success"] = "Your message has been successfully sent to a member of our team.";

                        return RedirectToAction("Index", "Contact");

                    }
                    else
                    {
                        TempData["ErrorTitle"] = "Oops!";
                        TempData["Error"] = "There was an error on our end  and we were unable to process your request. Please verify you email address and try again.";

                        return View(vm);
                    }
                }
            }
        }
    }
}