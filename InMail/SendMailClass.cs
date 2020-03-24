using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SendMailClass{
    internal class FunctionCall{

        #region variables

        #region Getting user info
        static string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Documents.txt";
        static string UserName = File.ReadLines(Documents).Skip(0).Take(1).First();
        static string UserEmail = File.ReadLines(Documents).Skip(1).Take(1).First();
        #endregion

        #region Variables used by the application
        static Response APIResponse;
        static string APIResponseCode;
        static bool EmailHasBeenSend = false;
        #endregion

        #endregion

        public static string SendFunction(string Recipient, string SubjectVariable, string CC, string BCC, String Messange,string FileName, string AttachmentPath){
            Execute(Recipient, SubjectVariable ,CC,BCC, Messange ,FileName, AttachmentPath).Wait();
            return APIResponseCode;
        }

        static async Task Execute(string Recipient, string SubjectVariable, string CC, string BCC, string Messange,string FileName,string AttachmentPath){
            try{
                //do-while is used for multiple clients
                do{

                    #region Email Values
                    APIResponseCode = "";

                    var apiKey = Environment.GetEnvironmentVariable("InMail_Api_Key");
                    var client = new SendGridClient(apiKey);
                    var from = new EmailAddress(UserEmail, UserName);
                    var subject = SubjectVariable == "" ? "(Κανένα θέμα)" : SubjectVariable;
                    var to = new EmailAddress(Recipient);
                    var plainTextContent = Messange == "" ? " " : Messange; ;
                    var htmlContent = Messange;
                    #endregion

                    var Message = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

                    #region Attachment
                    if (AttachmentPath != ""){
                        var bytes = System.IO.File.ReadAllBytes(AttachmentPath);
                        var File = Convert.ToBase64String(bytes);
                        Message.AddAttachment(FileName, File);
                    }
                    #endregion

                    /*
                    #region CC/BCC
                    if (CC != "") { 
                        Message.AddCcs("anemail@example.com");
                    }
                    if (BCC != ""){
                    Message.AddBccs("anemail@example.com")}
                    #endregion
        */

                    APIResponse = await client.SendEmailAsync(Message).ConfigureAwait(false);
                    APIResponseCode = APIResponse.StatusCode.ToString();
                    EmailHasBeenSend = true;

                    //for debuging purposes
                    //Debug.WriteLine(Convert.ToString(APIResponse)); 
                    //var response = client.SendEmailAsync(Message);
                } while (!EmailHasBeenSend);
            }
            //if mail get any error durning the sending process
            catch (Exception ErrorEncountered) { }
        }
    }
}