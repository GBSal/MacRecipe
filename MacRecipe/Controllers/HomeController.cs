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


        public ActionResult EmailTest(string Email)
        {



            List<string> recipients = new List<string>();

            if (!string.IsNullOrEmpty(Email))
            {

                var email = new SendGridEmailService();

                if (Email.Contains(';'))
                {
                    var emails = Email.Split(';');

                    foreach (var mail in emails)
                    {
                        recipients.Add(mail);
                    }


                }
                else
                {
                    recipients.Add(Email);

                }


                email.InviteFriends(recipients, "Email body here , Sorry guys, I'm testing emails..... ");
            }
            return View();

        }
    }



}