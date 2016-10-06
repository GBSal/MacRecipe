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

            
        public void SendEmail()
        {
            // Create the email object first, then add the properties.
            var myMessage = new SendGridMessage();

            // Add the message properties.
            myMessage.From = new MailAddress("mohammadsalman@hotmail.com");

            // Add multiple addresses to the To field.
            List<String> recipients = new List<String>
                {
                    @"Mohammad Salman <salman_it24@hotmail.com>",
    
                };      

            myMessage.AddTo(recipients);

            myMessage.Subject = "Testing the SendGrid Library";

            //Add the HTML and Text bodies
            myMessage.Html = "<p>Hello World!</p>";
            myMessage.Text = "Hello World plain text!";





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