using System;
using System.IO;
using System.Windows.Forms;

namespace InMail{
    public partial class UserInfoForm : Form{
        bool IsValid = false; //global variable for email validation

        public UserInfoForm(){
            
            InitializeComponent();
            UsernameTextbox.Text = Convert.ToString(Environment.UserName);
        }

        private void SaveButton_Click(object sender, EventArgs e){
            try{ 
            string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] lines = { UsernameTextbox.Text , EmailTextbox.Text };
            File.WriteAllLines(Path.Combine(Documents, "Documents.txt"), lines);
                MessageBox.Show("Τα στοιχεία σας εγγράφηκαν επιτυχώς", "Ολοκλήρωση εγγραφής");
                this.Close();
            }
            catch (Exception error){
                MessageBox.Show("Τα στοιχεία σας δεν εγγράφησαν ! \n\nError:"+error.Message , "Ουπς κάτι πήγε λάθος!");
            }
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e){
            FilledTextboxes();
        }

        private void EmailTextbox_TextChanged(object sender, EventArgs e){

            //checks if the email is in correct form
            EmailValidation EValidation=new EmailValidation();
            IsValid = EValidation.IsValidEmail(EmailTextbox.Text);
            //changes color to red if the email given is in wrong format
            if (IsValid) { EmailTextbox.ForeColor = System.Drawing.Color.Black; }
            else { EmailTextbox.ForeColor = System.Drawing.Color.Red; }

            FilledTextboxes();
        }

        private void FilledTextboxes(){
            if ((UsernameTextbox.Text == "")|| (EmailTextbox.Text == "")&&(IsValid)) { SaveButton.Enabled = false; }
            else{ SaveButton.Enabled = true; }
        }
    }
}
