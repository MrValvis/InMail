using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace SendMailClass{

    internal class FunctionCall{
        private static void SendFunction(){
            Execute().Wait();
        }

        static async Task Execute(){
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("test@example.com", Environment.UserName);
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("valvisphilip@gmail.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}