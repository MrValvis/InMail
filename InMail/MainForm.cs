using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace InMail
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
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
            if ((EmailTextbox.Text == "") || (EmailTextbox.Text == "Πληκτρολογίστε ΕΔΩ το email του παραλήπτη")) {
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


        //for mail attachments --https://stackoverflow.com/questions/5034503/adding-an-attachment-to-email-using-c-sharp/5034554



    }
}

