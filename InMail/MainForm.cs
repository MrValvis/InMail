using SendMailClass;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InMail
{
    public partial class MainForm : Form {

        #region global variables
        static string FileName,AttachmentPath;
        static bool ErrorEncountered;
        static bool UserEmailIsValid;
        bool IsValid = false; //global variable for email validation--recipient
        static string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Documents.txt";
        static string UserEmail;
        EmailValidation EValidation = new EmailValidation();
        UserInfoForm UIF = new UserInfoForm();

    #endregion


    public MainForm(){
            InitializeComponent();
            
            #region Initialize values
            EmailTextbox.Text = "Πληκτρολογίστε ΕΔΩ το email του παραλήπτη";
            SubjectTextbox.Text = "Θέμα ";

            string Time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            if (Time.Contains("ΠΜ")||(Time.Contains("πμ"))|| (Time.Contains("AM")) || (Time.Contains("am"))){
                GreetingLabel.Text = "Καλημέρα - Ας ετοιμάσουμε ένα νέο μήνυμα !"; }
            else {
                GreetingLabel.Text = "Καλησπέρα - Ας ετοιμάσουμε ένα νέο μήνυμα !"; }

            #endregion

            #region Check if user email exists
            try{
                string UserEmail = File.ReadLines(Documents).Skip(1).Take(1).First();
            }
            catch (Exception e) { 
                MessageBox.Show("Δεν βρέθηκαν τα στοιχεία χρήστη, παρακαλώ συμπληρώστε τα στοιχεία σας και πατήστε αποθήκευση.", "Τα στοιχεία χρήστη δεν βρέθηκαν!");
                UIF.ShowDialog();
            }
            #endregion
            // used for wrong or empty email
            UserEmailIsValid = EValidation.IsValidEmail(UserEmail);
        }

        #region Visual
        #region Color Theme change
        private void ChangeThemeColorToolStripMenuItem_Click(object sender, EventArgs e){
            if (ThemeColorToolStripMenuItem.Text == "Dark Theme"){

                BackColor = Color.Black;
                AttachmentPicture.BackColor = Color.White;
                GreetingLabel.ForeColor = Color.White;
                EmailMessangePlaceholder.ForeColor= Color.White;
                RecipientsLabel.ForeColor = Color.White;
                SubjectLabel.ForeColor = Color.White;
                CClabel.ForeColor = Color.White;
                BCCLabel.ForeColor = Color.White;

                ThemeColorToolStripMenuItem.Text = "White Theme";
            }
            else{
                BackColor = Color.White;
                GreetingLabel.ForeColor = Color.Black;
                EmailMessangePlaceholder.ForeColor = Color.Black;
                RecipientsLabel.ForeColor = Color.Black;
                SubjectLabel.ForeColor = Color.Black;
                CClabel.ForeColor = Color.Black;
                BCCLabel.ForeColor = Color.Black;

                ThemeColorToolStripMenuItem.Text = "Dark Theme";
            }
        }
        #endregion

        #region EmailTextbox
        private void EmailTextbox_TextChanged(object sender, EventArgs e){
            //checks if the email is in correct form
            EmailValidation EValidation = new EmailValidation();
            IsValid = EValidation.IsValidEmail(EmailTextbox.Text);
            //changes color to red if the email given is in wrong format
            if (IsValid) { EmailTextbox.ForeColor = Color.Black; }
            else { EmailTextbox.ForeColor = Color.Red; }


            if ((EmailTextbox.Text == "") || (EmailTextbox.Text == "Πληκτρολογίστε ΕΔΩ το email του παραλήπτη")|| !(IsValid)) {
                SendButton.Enabled = false;
                SendButton.BackColor = Color.LightGray;
            }
            else {
                SendButton.Enabled = true;
                SendButton.BackColor = Color.LightBlue ;
            }
        }
        #endregion

        #region CC/BCC Panel
        private void CCBCCButton_Click(object sender, EventArgs e){
            CCBCCPanel.Visible = true;
            CloseCCBCC.Visible = true;
            CCBCCButton.Visible = false;
            
        }

        private void CloseCCBCC_Click(object sender, EventArgs e){
            CCBCCButton.Visible = true;
            CloseCCBCC.Visible = false;
            CCBCCPanel.Visible = false;
            
        }
        #endregion

        #endregion

        #region Actions{

        #region SendEmail
        private void SendButton_Click(object sender, EventArgs e){
            EmailValidation();
        }
        #region SendEmail function
        void EmailValidation() {
            string UserEmail = File.ReadLines(Documents).Skip(1).Take(1).First();
            UserEmailIsValid = EValidation.IsValidEmail(UserEmail);
            try{
                if (!File.Exists(Documents)){
                    MessageBox.Show("Δεν βρέθηκαν τα στοιχεία χρήστη, παρακαλώ συμπληρώστε τα στοιχεία σας και πατήστε αποθήκευση!","Δεν βρέθηκαν τα στοιχεία σας!");
                    UIF.ShowDialog();
                }
                else if (!UserEmailIsValid){
                    MessageBox.Show("Το email σας δεν είναι έγκυρο, παρακαλώ συμπληρώστε ξανα το email σας.", "Το email χρήστη δεν είναι έγκυρο!");
                    UIF.ShowDialog();  
                }
                else{
                    try {
                        bool ErrorEncountered = false;
                        FunctionCall.SendFunction(EmailTextbox.Text, SubjectTextbox.Text, MailText.Text,  FileName,AttachmentPath);
                    }
                    catch (Exception error) {
                        ErrorEncountered = true;
                        MessageBox.Show("Το μήνυμα δεν στάλθηκε! Δοκιμάστε ξανά.","Αποτυχία αποστολής");
                    }
                    finally{
                        if (!ErrorEncountered){
                            MessageBox.Show("Το μήνυμα σας στάλθηκε επιτυχώς!", "Η αποστολή ολοκληρώθηκε!");
                        }
                    }
                    //FunctionCall.SendFunction(EmailTextbox.Text, SubjectTextbox.Text, MailText.Text,AttachedFile);
                }
            }
            catch (Exception error) { MessageBox.Show("Βρέθηκε κάποιο λάθος \nError : " + error.Message, "Παρουσιάστηκε σφάλμα!"); }
        }

        #endregion
        #endregion

        private void ChangeUserInfoToolStripMenuItem_Click(object sender, EventArgs e){
            UIF.ShowDialog();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e){
            #region Help Messange
            MessageBox.Show("                                                  Βασική εφαρμογή         \n\n\n" +
                "1)Το κόκκινο χρώμα στο email δείχνει οτι δεν είναι στην σωστή μορφή!\n" +
                "1.1) Πρίν αποστείλετε ένα μήνυμα θα πρέπει να έχετε συμπληρώσει το email σας, μπορείτε ανά πάσα στιγμή να τροποποιήσετε το email σας απο την καρτέλα 'Τροποποίηση στοιχείων.'\n\n" +
                "1.2)Για να στείλετε μήνυμα θα πρέπει υποχρεωτικά να έχετε συμπληρώσει το email του παραλήπτη! \n\n" +
                "2)Μπορείτε να πραγματοποιήσετε αλλαγή απο λευκό σε μαύρο φόντο και αντίστροφα με την επιλογή 'White/Black Font'.\n\n\n" +
                "                                Καρτέλα τροποποίησης στοιχείων (χρήστη)         \n\n" +
                "1.1)Όνομα χρήστη : Το σύστημα χρησιμοποιεί το όνομα του υπολογιστή σας σαν default επιλογή μπορείτε να το αλλάξετε αν επιθυμήτε.\n" +
                "1.2)Διεύθηνση e-mail : Για να μπορέσετε να στείλετε μήνυμα θα πρέπει να έχετε συμπληρώσει την διεύθηνση ηλεκτρονικού ταχυδρομείου σας.\n\n\n" +


                "v1.0", "Βοήθεια");
            #endregion
        }

        private void RemoveAttachmentButton_Click(object sender, EventArgs e){
            AttachmentPath = "";
            FileName = "";
            AttachedFileNameLabel.Visible = false;
            RemoveAttachmentButton.Visible = false;
            AttachedFileNameLabel.Text = "" + FileName;

            
        }

        private void AttachmentPicture_Click(object sender, EventArgs e){
            AttachmentPath = "";
            FileName = "";
            //gets the user selected item and returns its absolute path
            if (FileDialog.ShowDialog() == DialogResult.OK) { 
                AttachmentPath = FileDialog.FileName;
                FileName = Path.GetFileName(AttachmentPath);

                //show the file that we have selected as attachment
                AttachedFileNameLabel.Visible = true;
                RemoveAttachmentButton.Visible = true;
                AttachedFileNameLabel.Text = "Επισυναπτόμενο αρχείο : "+FileName;
            }
        }
    }
}
#endregion