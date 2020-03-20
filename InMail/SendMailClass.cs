using System;
using System.IO;
using System.Linq;
using System.Threading;
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

        public static void SendFunction(string Recipient, string SubjectVariable, String Messange,string FileName, string AttachmentPath){
            Execute(Recipient, SubjectVariable , Messange ,FileName, AttachmentPath).Wait();
        }
        

        static async Task Execute(string Recipient, string SubjectVariable , string Messange,string FileName,string AttachmentPath){              

            var apiKey = Environment.GetEnvironmentVariable("InMail_Api_Key");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(UserEmail, UserName);
            var subject = SubjectVariable=="" ? "(Κανένα θέμα)" : SubjectVariable;
            var to = new EmailAddress(Recipient);
            var plainTextContent = Messange == "" ? " " : Messange; ;
            var htmlContent = Messange;

            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent,htmlContent);

            if (AttachmentPath != "") {
            var bytes = File.ReadAllBytes(AttachmentPath);
            var file = Convert.ToBase64String(bytes);
            msg.AddAttachment(FileName, file);
            }

            //var response =await client.SendEmailAsync(msg);
            var response = client.SendEmailAsync(msg);

        }
    }
}