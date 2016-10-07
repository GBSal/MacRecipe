using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MacRecipe.Services;

namespace MacRecipe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Invites()
        {
            ViewBag.Message = "Send out invites";

            return View();
        }

        public ActionResult SelectRceipe ()
        {
            ViewBag.Message = "Select your recipe";

            return View();
        }


        public ActionResult EmailTest(string Email)
        {


            var email = new SendGridEmailService();

            email.SendEmail();

            return View();

        }
    }



}