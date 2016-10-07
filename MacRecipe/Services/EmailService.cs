using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net;
using System.Net.Mail;
using SendGrid;

namespace MacRecipe.Services
{
    public class SendGridEmailService
    {


        string emailFrom = @"MacRecipe <MacRecipe@Macmillan.org.uk>";



        public void InviteFriends(List<string> recipients  , string message)
        {

            var email = GetEmailMessage(recipients, message);
            email.From = new MailAddress(emailFrom);

            SendMessage(email);
        }


        public void NotifyRecipeSelection(List<string> recipients ,string message)
        {

            var email = GetEmailMessage(recipients, message);
            email.From = new MailAddress(emailFrom);

            SendMessage(email);

        }
        
            
        private void SendMessage(SendGridMessage message)
        {
           

            
            var username = "azure_53bd6fe4f76e58059d0a3fa78038c8d9 @azure.com";

            var pswd = "Password1";

            var credentials = new NetworkCredential(username, pswd);
            
            var transportWeb = new Web(credentials);

            transportWeb.Deliver(message);

        }

        private SendGridMessage GetEmailMessage(List<string> recipients, string message)
        {

            var myMessage = new SendGridMessage();


            myMessage.From = new MailAddress("MacRecipe@macmillan.uk");

            myMessage.AddTo(recipients);

            myMessage.Subject = "";

            //Add the HTML message here
            myMessage.Html = $"<p>{message}</p>";



            return myMessage;
        }



    }
}