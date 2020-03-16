using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SendMailClass{
    internal class FunctionCall{

        #region Getting user info
        static string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Documents.txt";
        static string UserName = File.ReadLines(Documents).Skip(0).Take(1).First();
        static string UserEmail = File.ReadLines(Documents).Skip(1).Take(1).First();
        #endregion

        //public static void SendFunction(string SubjectVariable, string Recipient, String Messange,Attachment Attached){
        //    Execute(SubjectVariable, Recipient, Messange, Attached).Wait();
        //}
        //static async Task Execute(string SubjectVariable,string Recipient,String Messange,Attachment Attached){

        public static void SendFunction(string SubjectVariable, string Recipient, String Messange){
            Execute(SubjectVariable, Recipient, Messange).Wait();
        }

        static async Task Execute(string SubjectVariable, string Recipient, String Messange){

            var apiKey = Environment.GetEnvironmentVariable("InMail_Api_Key");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(UserEmail, UserName);
            var subject = SubjectVariable;
            var to = new EmailAddress(Recipient);
            var plainTextContent = Messange;
            var htmlContent = Messange;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("c:/path/filename.txt");
            //mail.Attachments.Add(attachment);
        }
    }
}