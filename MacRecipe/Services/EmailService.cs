using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net;
using System.Net.Mail;
using SendGrid;
using System.IO;
using MacRecipe.Models;
using RazorEngine.Templating;

namespace MacRecipe.Services
{
    public class SendGridEmailService
    {

        string  templateFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EmailTemplates");
        string inviteSubject = "You're invited to dinner for Come dine with Macmillan!";
        string notifySubject = "Come dine with Macmillan - your guest have voted!";


        public void InviteEmail(List<string> recipients, string recipeId) 
        {
            string path = templateFolderPath + @"\InviteEmail.cshtml";

            var model = new EmailModel { Name = "Ellie", HostName = "Mohammad", InviteToken= recipeId };

            var template = new TemplateService();

            var emailBody = template.Parse(File.ReadAllText(path),model,null,null);

            this.SendEmail(recipients, inviteSubject, emailBody);

        }


        public void NotityEmail(List<string> recipients)
        {
            string path = templateFolderPath + @"\NotifyEmail.cshtml";

            var model = new EmailModel { HostName = "Mohammad" };

            var template = new TemplateService();

            var emailBody = template.Parse(File.ReadAllText(path), model, null, null);

            this.SendEmail(recipients, notifySubject, emailBody);

        }


        private void SendEmail(List<string> recipients , string subject , string message)
        {
            // Create the email object first, then add the properties.
            var myMessage = new SendGridMessage();

            // Add the message properties.
            myMessage.From = new MailAddress("mohammadsalman@hotmail.com");

            // Add multiple addresses to the To field.
            //List<String> recipients = new List<String>
            //    {
            //        @"Mac Recipe <MacRecipe_it24@mailinator.com>",

            //    };

            myMessage.AddTo(recipients);

            myMessage.Subject = subject;


            myMessage.Html = message;
            myMessage.Text = message;


            // Create network credentials to access your SendGrid account
            var username = "azure_53bd6fe4f76e58059d0a3fa78038c8d9@azure.com";
            var pswd = "Password1";



            var credentials = new NetworkCredential(username, pswd);
            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);


            transportWeb.Deliver(myMessage);



        }

    }
}