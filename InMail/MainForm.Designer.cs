using System;

namespace InMail
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.EmailMessangePlaceholder = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.Basic = new System.Windows.Forms.Panel();
            this.RemoveAttachmentButton = new System.Windows.Forms.PictureBox();
            this.AttachedFileNameLabel = new System.Windows.Forms.Label();
            this.AttachmentPicture = new System.Windows.Forms.PictureBox();
            this.MailText = new System.Windows.Forms.TextBox();
            this.SubjectTextbox = new System.Windows.Forms.TextBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.RecipientsLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.CCBCCPanel = new System.Windows.Forms.Panel();
            this.CloseCCBCC = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BCCLabel = new System.Windows.Forms.Label();
            this.CClabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CCBCCButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.τροποποίησηΣτοιχείωνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.βοήθειαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Basic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveAttachmentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentPicture)).BeginInit();
            this.CCBCCPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseCCBCC)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GreetingLabel.Location = new System.Drawing.Point(160, 30);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(131, 16);
            this.GreetingLabel.TabIndex = 0;
            this.GreetingLabel.Text = "Greeting PlaceHolder";
            // 
            // EmailMessangePlaceholder
            // 
            this.EmailMessangePlaceholder.AutoSize = true;
            this.EmailMessangePlaceholder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EmailMessangePlaceholder.Location = new System.Drawing.Point(3, 26);
            this.EmailMessangePlaceholder.Name = "EmailMessangePlaceholder";
            this.EmailMessangePlaceholder.Size = new System.Drawing.Size(0, 16);
            this.EmailMessangePlaceholder.TabIndex = 1;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EmailTextbox.Location = new System.Drawing.Point(117, 39);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(436, 20);
            this.EmailTextbox.TabIndex = 2;
            this.EmailTextbox.Text = "Παραλήπτης μηνύματος";
            this.EmailTextbox.TextChanged += new System.EventHandler(this.EmailTextbox_TextChanged);
            // 
            // Basic
            // 
            this.Basic.Controls.Add(this.RemoveAttachmentButton);
            this.Basic.Controls.Add(this.AttachedFileNameLabel);
            this.Basic.Controls.Add(this.AttachmentPicture);
            this.Basic.Controls.Add(this.MailText);
            this.Basic.Controls.Add(this.SubjectTextbox);
            this.Basic.Controls.Add(this.SubjectLabel);
            this.Basic.Controls.Add(this.RecipientsLabel);
            this.Basic.Controls.Add(this.SendButton);
            this.Basic.Controls.Add(this.EmailTextbox);
            this.Basic.Controls.Add(this.EmailMessangePlaceholder);
            this.Basic.Controls.Add(this.CCBCCButton);
            this.Basic.Controls.Add(this.CCBCCPanel);
            this.Basic.Location = new System.Drawing.Point(12, 49);
            this.Basic.Name = "Basic";
            this.Basic.Size = new System.Drawing.Size(557, 376);
            this.Basic.TabIndex = 3;
            // 
            // RemoveAttachmentButton
            // 
            this.RemoveAttachmentButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RemoveAttachmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveAttachmentButton.Image = global::InMail.Properties.Resources.Close;
            this.RemoveAttachmentButton.Location = new System.Drawing.Point(44, 351);
            this.RemoveAttachmentButton.Name = "RemoveAttachmentButton";
            this.RemoveAttachmentButton.Size = new System.Drawing.Size(19, 22);
            this.RemoveAttachmentButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoveAttachmentButton.TabIndex = 13;
            this.RemoveAttachmentButton.TabStop = false;
            this.RemoveAttachmentButton.Visible = false;
            this.RemoveAttachmentButton.Click += new System.EventHandler(this.RemoveAttachmentButton_Click);
            // 
            // AttachedFileNameLabel
            // 
            this.AttachedFileNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AttachedFileNameLabel.AutoSize = true;
            this.AttachedFileNameLabel.Location = new System.Drawing.Point(69, 355);
            this.AttachedFileNameLabel.Name = "AttachedFileNameLabel";
            this.AttachedFileNameLabel.Size = new System.Drawing.Size(94, 13);
            this.AttachedFileNameLabel.TabIndex = 12;
            this.AttachedFileNameLabel.Text = "AttachedFileName";
            this.AttachedFileNameLabel.Visible = false;
            // 
            // AttachmentPicture
            // 
            this.AttachmentPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttachmentPicture.Image = global::InMail.Properties.Resources.Paperclip;
            this.AttachmentPicture.Location = new System.Drawing.Point(18, 351);
            this.AttachmentPicture.Name = "AttachmentPicture";
            this.AttachmentPicture.Size = new System.Drawing.Size(20, 22);
            this.AttachmentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AttachmentPicture.TabIndex = 11;
            this.AttachmentPicture.TabStop = false;
            this.AttachmentPicture.Click += new System.EventHandler(this.AttachmentPicture_Click);
            // 
            // MailText
            // 
            this.MailText.Location = new System.Drawing.Point(18, 156);
            this.MailText.Multiline = true;
            this.MailText.Name = "MailText";
            this.MailText.Size = new System.Drawing.Size(535, 192);
            this.MailText.TabIndex = 5;
            this.MailText.Text = "Γράψτε το μήνυμα σας...";
            // 
            // SubjectTextbox
            // 
            this.SubjectTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SubjectTextbox.Location = new System.Drawing.Point(117, 65);
            this.SubjectTextbox.Name = "SubjectTextbox";
            this.SubjectTextbox.Size = new System.Drawing.Size(436, 20);
            this.SubjectTextbox.TabIndex = 3;
            this.SubjectTextbox.Text = "Θέμα μηνύματος\r\n";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SubjectLabel.Location = new System.Drawing.Point(53, 65);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(47, 16);
            this.SubjectLabel.TabIndex = 7;
            this.SubjectLabel.Text = "Θέμα :";
            // 
            // RecipientsLabel
            // 
            this.RecipientsLabel.AutoSize = true;
            this.RecipientsLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RecipientsLabel.Location = new System.Drawing.Point(12, 39);
            this.RecipientsLabel.Name = "RecipientsLabel";
            this.RecipientsLabel.Size = new System.Drawing.Size(89, 16);
            this.RecipientsLabel.TabIndex = 6;
            this.RecipientsLabel.Text = "Παραλήπτης :";
            // 
            // SendButton
            // 
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Location = new System.Drawing.Point(478, 0);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 99;
            this.SendButton.Text = "Αποστολή";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CCBCCPanel
            // 
            this.CCBCCPanel.Controls.Add(this.CloseCCBCC);
            this.CCBCCPanel.Controls.Add(this.textBox2);
            this.CCBCCPanel.Controls.Add(this.BCCLabel);
            this.CCBCCPanel.Controls.Add(this.CClabel);
            this.CCBCCPanel.Controls.Add(this.textBox1);
            this.CCBCCPanel.Location = new System.Drawing.Point(18, 87);
            this.CCBCCPanel.Name = "CCBCCPanel";
            this.CCBCCPanel.Size = new System.Drawing.Size(538, 52);
            this.CCBCCPanel.TabIndex = 9;
            this.CCBCCPanel.Visible = false;
            // 
            // CloseCCBCC
            // 
            this.CloseCCBCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseCCBCC.Image = global::InMail.Properties.Resources.Close;
            this.CloseCCBCC.Location = new System.Drawing.Point(0, 0);
            this.CloseCCBCC.Name = "CloseCCBCC";
            this.CloseCCBCC.Size = new System.Drawing.Size(20, 21);
            this.CloseCCBCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseCCBCC.TabIndex = 12;
            this.CloseCCBCC.TabStop = false;
            this.CloseCCBCC.Visible = false;
            this.CloseCCBCC.Click += new System.EventHandler(this.CloseCCBCC_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(99, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(436, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "BCC";
            // 
            // BCCLabel
            // 
            this.BCCLabel.AutoSize = true;
            this.BCCLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BCCLabel.Location = new System.Drawing.Point(42, 30);
            this.BCCLabel.Name = "BCCLabel";
            this.BCCLabel.Size = new System.Drawing.Size(39, 15);
            this.BCCLabel.TabIndex = 8;
            this.BCCLabel.Text = "BCC :";
            // 
            // CClabel
            // 
            this.CClabel.AutoSize = true;
            this.CClabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CClabel.Location = new System.Drawing.Point(47, 6);
            this.CClabel.Name = "CClabel";
            this.CClabel.Size = new System.Drawing.Size(31, 15);
            this.CClabel.TabIndex = 7;
            this.CClabel.Text = "CC :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(99, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "CC";
            // 
            // CCBCCButton
            // 
            this.CCBCCButton.Location = new System.Drawing.Point(39, 86);
            this.CCBCCButton.Name = "CCBCCButton";
            this.CCBCCButton.Size = new System.Drawing.Size(56, 22);
            this.CCBCCButton.TabIndex = 4;
            this.CCBCCButton.Text = "CC/BCC";
            this.CCBCCButton.UseVisualStyleBackColor = true;
            this.CCBCCButton.Click += new System.EventHandler(this.CCBCCButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.τροποποίησηΣτοιχείωνToolStripMenuItem,
            this.ThemeColorToolStripMenuItem,
            this.βοήθειαToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Menu";
            // 
            // τροποποίησηΣτοιχείωνToolStripMenuItem
            // 
            this.τροποποίησηΣτοιχείωνToolStripMenuItem.Name = "τροποποίησηΣτοιχείωνToolStripMenuItem";
            this.τροποποίησηΣτοιχείωνToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.τροποποίησηΣτοιχείωνToolStripMenuItem.Text = "Τροποποίηση στοιχείων";
            this.τροποποίησηΣτοιχείωνToolStripMenuItem.Click += new System.EventHandler(this.ChangeUserInfoToolStripMenuItem_Click);
            // 
            // ThemeColorToolStripMenuItem
            // 
            this.ThemeColorToolStripMenuItem.Name = "ThemeColorToolStripMenuItem";
            this.ThemeColorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.ThemeColorToolStripMenuItem.Text = "Dark Theme";
            this.ThemeColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeThemeColorToolStripMenuItem_Click);
            // 
            // βοήθειαToolStripMenuItem
            // 
            this.βοήθειαToolStripMenuItem.Name = "βοήθειαToolStripMenuItem";
            this.βοήθειαToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.βοήθειαToolStripMenuItem.Text = "Βοήθεια!";
            this.βοήθειαToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "FileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 437);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Basic);
            this.Controls.Add(this.GreetingLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "InMail";
            this.Basic.ResumeLayout(false);
            this.Basic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveAttachmentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentPicture)).EndInit();
            this.CCBCCPanel.ResumeLayout(false);
            this.CCBCCPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseCCBCC)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.Label EmailMessangePlaceholder;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Panel Basic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThemeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem βοήθειαToolStripMenuItem;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label RecipientsLabel;
        private System.Windows.Forms.TextBox SubjectTextbox;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Panel CCBCCPanel;
        private System.Windows.Forms.Label BCCLabel;
        private System.Windows.Forms.Label CClabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CCBCCButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox MailText;
        private System.Windows.Forms.PictureBox AttachmentPicture;
        private System.Windows.Forms.PictureBox CloseCCBCC;
        private System.Windows.Forms.ToolStripMenuItem τροποποίησηΣτοιχείωνToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Label AttachedFileNameLabel;
        private System.Windows.Forms.PictureBox RemoveAttachmentButton;
    }
}

